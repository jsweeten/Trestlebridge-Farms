using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models;

namespace Trestlebridge.Menus
{
    public class AnimalMenu
    {
        public static void PurchaseAnimals(Farm Trestlebridge)
        {
            Chicken c = new();
            Duck d = new();
            Cow cow = new();
            Goat g = new();
            Ostrich o = new();
            Pig p = new();
            Sheep s = new();
            ChickenCoop coop = new();
            DuckHouse dh = new();
            GrazingField gf = new();
            NaturalField nf = new();
            PloughingField pf = new();

            int ChickenInventory = Trestlebridge.Animals["Chicken"];
            int DuckInventory = Trestlebridge.Animals["Duck"];
            int coopCapacity = Trestlebridge.Facilities[coop] * coop.Capacity;
            int coopSpace = coopCapacity - Trestlebridge.Animals["Chicken"];
            int duckHouseCapacity = Trestlebridge.Facilities[dh] * dh.Capacity;
            int duckHouseSpace = duckHouseCapacity - Trestlebridge.Animals["Duck"];
            int grazingFieldCapacity = Trestlebridge.Facilities[gf] * gf.Capacity;
            int grazingFieldSpace = grazingFieldCapacity
                - Trestlebridge.Animals["Cow"]
                - Trestlebridge.Animals["Pig"]
                - Trestlebridge.Animals["Ostrich"]
                - Trestlebridge.Animals["Sheep"]
                - Trestlebridge.Animals["Goat"];
            Console.WriteLine();
            Console.WriteLine("1. Chicken");
            Console.WriteLine("2. Cow");
            Console.WriteLine("3. Duck");
            Console.WriteLine("4. Goat");
            Console.WriteLine("5. Ostrich");
            Console.WriteLine("6. Pig");
            Console.WriteLine("7. Sheep");
            Console.WriteLine();
            Console.WriteLine("Choose an animal to purchase:");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    if (Trestlebridge.Animals["Chicken"] == 0)
                    {
                        Console.WriteLine("You can't buy chickens until you purchase a chicken coop!");
                        Console.ReadKey();
                        break;
                    }
                    else if ((coopCapacity - Trestlebridge.Animals["Chicken"]) == 0)
                    {
                        Console.WriteLine("Your chicken coops are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[coop]} chicken coops and {Trestlebridge.Animals["Chicken"]} chickens.");
                        Console.WriteLine($"You have space for {(coopCapacity - Trestlebridge.Animals["Chicken"])} chickens.");
                        Console.Write("How many chickens would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > (coopCapacity - Trestlebridge.Animals["Chicken"]))
                        {
                            Console.WriteLine("You don't have room for that many chickens!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Animals["Chicken"] += purchaseAmount;
                            Console.WriteLine("Chickens Added!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 2:
                    if (Trestlebridge.Facilities[gf] == 0)
                    {
                        Console.WriteLine("You can't purchase grazing animals until you purchase a grazing field!");
                        Console.ReadKey();
                        break;
                    }
                    else if (grazingFieldSpace == 0)
                    {
                        Console.WriteLine("Your grazing fields are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[gf]} grazing fields.");
                        Console.WriteLine($"You have space for {grazingFieldSpace} cows.");
                        Console.Write("How many cows would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > grazingFieldSpace)
                        {
                            Console.WriteLine("You don't have room for that many cows!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Animals["Cow"] += purchaseAmount;
                            Console.WriteLine("Cows Added! Moo!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 3:
                    if (Trestlebridge.Facilities[dh] == 0)
                    {
                        Console.WriteLine("You can't buy ducks until you purchase a duck house!");
                        Console.ReadKey();
                        break;
                    }
                    else if ((duckHouseCapacity - Trestlebridge.Facilities[dh]) == 0)
                    {
                        Console.WriteLine("Your duck houses are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[dh]} duck houses and {Trestlebridge.Animals["Ducks"]} ducks.");
                        Console.WriteLine($"You have space for {duckHouseSpace} ducks.");
                        Console.Write("How many ducks would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > duckHouseSpace)
                        {
                            Console.WriteLine("You don't have room for that many ducks!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Animals["Ducks"] += purchaseAmount;
                            Console.WriteLine("Ducks Added! Quack!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 4:
                    if (Trestlebridge.Facilities[gf] == 0)
                    {
                        Console.WriteLine("You can't purchase grazing animals until you purchase a grazing field!");
                        Console.ReadKey();
                        break;
                    }
                    else if (grazingFieldSpace == 0)
                    {
                        Console.WriteLine("Your grazing fields are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[gf]} grazing fields.");
                        Console.WriteLine($"You have space for {grazingFieldSpace} goats.");
                        Console.Write("How many goats would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > grazingFieldSpace)
                        {
                            Console.WriteLine("You don't have room for that many goats!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Animals["Goats"] += purchaseAmount;
                            Console.WriteLine("Goats Added! Baa?!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 5:
                    if (Trestlebridge.Facilities[gf] == 0)
                    {
                        Console.WriteLine("You can't purchase grazing animals until you purchase a grazing field!");
                        Console.ReadKey();
                        break;
                    }
                    else if (grazingFieldSpace == 0)
                    {
                        Console.WriteLine("Your grazing fields are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[gf]} grazing fields.");
                        Console.WriteLine($"You have space for {grazingFieldSpace} ostriches.");
                        Console.Write("How many ostriches would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > grazingFieldSpace)
                        {
                            Console.WriteLine("You don't have room for that many ostriches!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Animals["Ostriches"] += purchaseAmount;
                            Console.WriteLine("Ostriches Added?!?!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 6:
                    if (Trestlebridge.Facilities[gf] == 0)
                    {
                        Console.WriteLine("You can't purchase grazing animals until you purchase a grazing field!");
                        Console.ReadKey();
                        break;
                    }
                    else if (grazingFieldSpace == 0)
                    {
                        Console.WriteLine("Your grazing fields are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[gf]} grazing fields.");
                        Console.WriteLine($"You have space for {grazingFieldSpace} pigs.");
                        Console.Write("How many pigs would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > grazingFieldSpace)
                        {
                            Console.WriteLine("You don't have room for that many pigs!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Animals["Pigs"] += purchaseAmount;
                            Console.WriteLine("Pigs Added! Oink oink!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 7:
                    if (Trestlebridge.Facilities[gf] == 0)
                    {
                        Console.WriteLine("You can't purchase grazing animals until you purchase a grazing field!");
                        Console.ReadKey();
                        break;
                    }
                    else if (grazingFieldSpace == 0)
                    {
                        Console.WriteLine("Your grazing fields are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[gf]} grazing fields.");
                        Console.WriteLine($"You have space for {grazingFieldSpace} sheep.");
                        Console.Write("How many sheep would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > grazingFieldSpace)
                        {
                            Console.WriteLine("You don't have room for that many sheep!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Animals["Sheep"] += purchaseAmount;
                            Console.WriteLine("Sheep Added! Baa!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
            }
        }
    }
}
