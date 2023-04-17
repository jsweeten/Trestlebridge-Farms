using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models;

namespace Trestlebridge.Menus
{
    internal class ProcessingMenu
    {
        public static void ProcessResources(Farm Trestlebridge)
        {
            Console.WriteLine();
            Console.WriteLine("1. Seed Harvester");
            Console.WriteLine("2. Meat Processor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Harvester");
            Console.WriteLine();
            Console.WriteLine("Choose equipment to use:");
            int input = Int32.Parse(Console.ReadLine());

            Sunflower sunflower = new();
            Sesame sesame = new();
            Wildflower wildflower = new();
            NaturalField nf = new();
            PloughingField pf = new();



            switch (input)
            {
                case 1:
                    if (Trestlebridge.Plants["Sunflowers"] == 0 && Trestlebridge.Plants["Sesame"] == 0 && Trestlebridge.Plants["Wildflowers"] == 0)
                    {
                        Console.WriteLine("You have no plants!");
                        break;
                    };
                    Console.WriteLine("");
                    Console.WriteLine("Which field would you like to harvest for seeds?");
                    Console.WriteLine();
                    Console.WriteLine("1. Natural Field");
                    Console.WriteLine("2. Ploughed Field");
                    input = Int32.Parse(Console.ReadLine());

                    if (input == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Which plant would you like to harvest?");
                        Console.WriteLine();
                        Console.WriteLine($"1. Sunflowers: {Trestlebridge.Plants["Sunflowers"]}");
                        Console.WriteLine($"2. Wildflowers: {Trestlebridge.Plants["Wildflowers"]}");
                        Console.WriteLine();
                        input = Int32.Parse(Console.ReadLine());

                        if (input == 1)
                        {
                        Console.WriteLine("How many would you like to harvest?");
                        Console.WriteLine($"You have {Trestlebridge.Plants["Sunflowers"]} sunflowers");
                        int amount = Int32.Parse(Console.ReadLine());
                            if (amount <= Trestlebridge.Plants["Sunflowers"])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Sunflowers Harvested.");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number less than or equal to total amount.");
                            }
                        }
                        else if (input == 2)
                        {
                        Console.WriteLine("How many would you like to harvest?");
                        Console.WriteLine($"You have {Trestlebridge.Plants["Wildflowers"]} wildflowers");
                        int amount = Int32.Parse(Console.ReadLine());
                            if (amount <= Trestlebridge.Plants["Wildflowers"])
                            {
                                Trestlebridge.UpdateInventory("Wildflowers", amount);
                                Console.WriteLine();
                                Console.WriteLine("Wildflowers Harvested.");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number less than or equal to total amount.");
                            }
                        }

                    }
                    else if (input == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Sunflowers: {Trestlebridge.Plants["Sunflowers"]}");
                        Console.WriteLine($"Sesame: {Trestlebridge.Plants["Sesame"]}");
                        Console.WriteLine();
                        input = Int32.Parse(Console.ReadLine());

                        foreach (var plant in Trestlebridge.Plants)
                        {
                            if (plant.Key == "Sunflowers" || plant.Key == "Sesame")
                            {
                                string keyToString = plant.Key.ToString();
                                ploughedFieldList.Add(plant.Key, plant.Value);
                            }
                        }
                        int i = 1;
                        foreach (var plant in ploughedFieldList)
                        {
                            Console.WriteLine($"{i}. {plant.Key}");
                            Console.WriteLine();
                            Console.WriteLine("Each plant produces:");
                            Console.WriteLine();
                            foreach (var product in plant.Key.Product)
                            {
                                Console.WriteLine($"{product.Value} {product.Key}");
                            }
                            i++;
                        }
                        Console.Write("Choose a plant to harvest from the list above: ");
                        input = Int32.Parse(Console.ReadLine());
                        var ChosenPlant = new KeyValuePair<IPlant, int>();
                        for (int j = 0; j < ploughedFieldList.Count; j++)
                        {
                            ChosenPlant = ploughedFieldList.ElementAt(j);
                            Console.WriteLine($"You chose {ChosenPlant.Key}");
                        }

                        Console.WriteLine("How many would you like to harvest?");
                        int amount = Int32.Parse(Console.ReadLine());

                        Trestlebridge.Plants[ChosenPlant.Key] -= amount;

                        foreach (var product in ChosenPlant.Key.Product)
                        {
                            foreach (var inv in Trestlebridge.Products)
                            {
                                if (inv.Key == product.Key.ToString())
                                {
                                    double adjustedValue = product.Value * amount;
                                    Trestlebridge.UpdateInventory(inv.Key, adjustedValue);
                                    break;
                                }
                            }
                        }

                        Console.WriteLine("Transaction Complete!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Improper input. Please try again.");
                        break;
                    }
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                    //case 3: Console.WriteLine();
                    //    break;
                    //case 4: Console.WriteLine();
                    //    break;
                    //case 5: Console.WriteLine();
                    //    break;
            }
        }
    }
}
