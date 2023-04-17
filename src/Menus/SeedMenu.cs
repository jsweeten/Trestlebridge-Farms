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
    public class SeedMenu
    {
        public static void PurchaseSeeds(Farm Trestlebridge)
        {
            PloughingField pf = new();
            NaturalField nf = new();
            Sunflower sunflower = new();
            Sesame sesame = new();
            Wildflower wildflower = new();

            int ploughedFieldCapacity = Trestlebridge.Facilities[pf];
            int ploughedFieldSpace = ploughedFieldCapacity
                - Trestlebridge.Plants["Sunflowers"]
                - Trestlebridge.Plants["Sesame"];
            int naturalFieldCapacity = Trestlebridge.Facilities[nf] * nf.Capacity;
            int naturalFieldSpace = naturalFieldCapacity
                - Trestlebridge.Plants["Sesame"]
                - Trestlebridge.Plants["Sunflowers"];

            Console.WriteLine();
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Wildflower");
            Console.WriteLine();
            Console.WriteLine("Choose seeds to purchase:");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    if (Trestlebridge.Facilities[pf] == 0)
                    {
                        Console.WriteLine("You can't sow sesame until you purchase a ploughed field!");
                        Console.ReadKey();
                        break;
                    }
                    else if (ploughedFieldSpace == 0)
                    {
                        Console.WriteLine("Your ploughed fields are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[pf]} ploughed fields and {Trestlebridge.Plants["Sesame"]} sesame plants.");
                        Console.WriteLine($"You have space for {ploughedFieldSpace} more sesame rows.");
                        Console.Write("How many rows of sesame plants would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > ploughedFieldSpace)
                        {
                            Console.WriteLine("You don't have room for that many plants!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Plants["Sesame"] += purchaseAmount;
                            Console.WriteLine("Sesame Added!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 2:
                    if (Trestlebridge.Facilities[pf] == 0 &&
                        Trestlebridge.Facilities[nf] == 0)
                    {
                        Console.WriteLine("You can't sow sunflower until you purchase a field!");
                        Console.ReadKey();
                        break;
                    }
                    else if (ploughedFieldSpace == 0 && naturalFieldSpace == 0)
                    {
                        Console.WriteLine("Your fields are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.Write(@$"You currently have {Trestlebridge.Facilities[pf]} ploughed fields,
{Trestlebridge.Facilities[nf]} natural fields, and {Trestlebridge.Plants["Sunflowers"]} sunflower plants.");
                        Console.WriteLine($"You have space for {ploughedFieldSpace + naturalFieldSpace} more sunflower rows.");
                        Console.Write("How many rows of sunflower would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > (ploughedFieldSpace + naturalFieldSpace))
                        {
                            Console.WriteLine("You don't have room for that many plants!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Plants["Sunflowers"] += purchaseAmount;
                            Console.WriteLine("Sunflowers Added!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 3:
                    if (Trestlebridge.Facilities[nf] == 0)
                    {
                        Console.WriteLine("You can't sow wildflower until you purchase a natural field!");
                        Console.ReadKey();
                        break;
                    }
                    else if (naturalFieldSpace == 0)
                    {
                        Console.WriteLine("Your natural fields are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[nf]} natural fields and {Trestlebridge.Plants["Wildflowers"]} wildflower plants.");
                        Console.WriteLine($"You have space for {naturalFieldSpace} more wildflower rows.");
                        Console.Write("How many rows of wildflower plants would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > naturalFieldSpace)
                        {
                            Console.WriteLine("You don't have room for that many plants!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Plants["Wildflowers"] += purchaseAmount;
                            Console.WriteLine("Wildflowers Added!");
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
