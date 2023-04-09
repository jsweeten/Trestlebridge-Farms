using System;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Trestlebridge.Menus
{
    public class Menus
    {
        // Main Menu
        public static void MainMenu(Farm Trestlebridge)
        {
            Utils.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Create Facility");
            Console.WriteLine("2. Purchase Animals");
            Console.WriteLine("3. Purchase Seeds");
            Console.WriteLine("4. Processing Options");
            Console.WriteLine();
            Console.WriteLine("0. Inventory");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Choose A FARMS Option:");
            var input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Utils.Clear();
                    FacilityMenu(Trestlebridge);
                    break;
                case 2:
                    Utils.Clear();
                    AnimalPurchaseMenu(Trestlebridge);
                    break;
                case 3:
                    Utils.Clear();
                    SeedPurchaseMenu(Trestlebridge);
                    break;
                case 4:
                    Utils.Clear();
                    ProcessingMenu(Trestlebridge);
                    break;
                case 0:
                    Utils.Clear();
                    Trestlebridge.InventoryReport();
                    break;
            }
        }

        // Create Facility Menu
        public static void FacilityMenu(Farm Trestlebridge)
        {
            Console.WriteLine();
            Console.WriteLine("1. Grazing Field:");
            Console.WriteLine("Stores: Cows, Pigs, Goats, and Ostriches");
            Console.WriteLine("Capacity: 20");
            Console.WriteLine();
            Console.WriteLine("2. Ploughed Field:");
            Console.WriteLine("Stores: Sunflowers and Sesame");
            Console.WriteLine("Capacity: 13 rows of plants, 5 plants per row");
            Console.WriteLine();
            Console.WriteLine("3. Natural Field:");
            Console.WriteLine("Stores: Sunflowers and Wildflowers");
            Console.WriteLine("Capacity: 10 rows, 6 plants per row");
            Console.WriteLine();
            Console.WriteLine("4. Chicken Coop:");
            Console.WriteLine("Stores: Chickens");
            Console.WriteLine("Capacity: 15");
            Console.WriteLine();
            Console.WriteLine("5. Duck House:");
            Console.WriteLine("Stores: Ducks");
            Console.WriteLine("Capacity: 12");
            Console.WriteLine();
            Console.WriteLine("Choose a facility to create:");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    var grazeField = new GrazingField();
                    Trestlebridge.AddGrazingField(grazeField);
                    Console.WriteLine("New Grazing Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 2:
                    var ploughField = new PloughingField();
                    Trestlebridge.AddPloughingField(ploughField);
                    Console.WriteLine("New Ploughing Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 3:
                    var naturalField = new NaturalField();
                    Trestlebridge.AddNaturalField(naturalField);
                    Console.WriteLine("New Natural Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 4:
                    var chickenCoop = new ChickenCoop();
                    Trestlebridge.AddChickenCoop(chickenCoop);
                    Console.WriteLine("New Chicken Coop Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 5:
                    var duckHouse = new DuckHouse();
                    Trestlebridge.AddDuckHouse(duckHouse);
                    Console.WriteLine("New Duck House Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
            }
        }

        //Animal Purchase Menu
        public static void AnimalPurchaseMenu(Farm Trestlebridge)
        {
            int coopCapacity = Trestlebridge.ChickenCoops.Count * 15;
            int coopSpace = coopCapacity - Trestlebridge.Chickens;
            int duckHouseCapacity = Trestlebridge.DuckHouses.Count * 12;
            int duckHouseSpace = duckHouseCapacity - Trestlebridge.Ducks;
            int grazingFieldCapacity = Trestlebridge.GrazingFields.Count * 20;
            int grazingFieldSpace = grazingFieldCapacity
                - Trestlebridge.Cows
                - Trestlebridge.Pigs
                - Trestlebridge.Ostriches
                - Trestlebridge.Sheep
                - Trestlebridge.Goats;
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
                    if (Trestlebridge.ChickenCoops.Count == 0)
                    {
                        Console.WriteLine("You can't buy chickens until you purchase a chicken coop!");
                        Console.ReadKey();
                        break;
                    }
                    else if (coopSpace == 0)
                    {
                        Console.WriteLine("Your chicken coops are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.ChickenCoops.Count} chicken coops and {Trestlebridge.Chickens} chickens.");
                        Console.WriteLine($"You have space for {coopSpace} chickens.");
                        Console.Write("How many chickens would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > coopSpace)
                        {
                            Console.WriteLine("You don't have room for that many chickens!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                        Trestlebridge.Chickens += purchaseAmount;
                        Console.WriteLine("Chickens Added!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Utils.Clear();
                        break;
                        }
                    }
                case 2:
                    if (Trestlebridge.GrazingFields.Count == 0)
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
                        Console.WriteLine($"You currently have {Trestlebridge.GrazingFields.Count} grazing fields.");
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
                            Trestlebridge.Cows += purchaseAmount;
                            Console.WriteLine("Cows Added! Moo!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 3:
                    if (Trestlebridge.DuckHouses.Count == 0)
                    {
                        Console.WriteLine("You can't buy ducks until you purchase a duck house!");
                        Console.ReadKey();
                        break;
                    }
                    else if (coopSpace == 0)
                    {
                        Console.WriteLine("Your duck houses are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.DuckHouses.Count} duck houses and {Trestlebridge.Ducks} ducks.");
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
                            Trestlebridge.Ducks += purchaseAmount;
                            Console.WriteLine("Ducks Added! Quack!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 4:
                    if (Trestlebridge.GrazingFields.Count == 0)
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
                        Console.WriteLine($"You currently have {Trestlebridge.GrazingFields.Count} grazing fields.");
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
                            Trestlebridge.Goats += purchaseAmount;
                            Console.WriteLine("Goats Added! Baa?!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 5:
                    if (Trestlebridge.GrazingFields.Count == 0)
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
                        Console.WriteLine($"You currently have {Trestlebridge.GrazingFields.Count} grazing fields.");
                        Console.WriteLine($"You have space for {grazingFieldSpace} ostriches.");
                        Console.Write("How many cows would you like to purchase?  ");
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
                            Trestlebridge.Ostriches += purchaseAmount;
                            Console.WriteLine("Ostriches Added?!?!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 6:
                    if (Trestlebridge.GrazingFields.Count == 0)
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
                        Console.WriteLine($"You currently have {Trestlebridge.GrazingFields.Count} grazing fields.");
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
                            Trestlebridge.Pigs += purchaseAmount;
                            Console.WriteLine("Pigs Added! Oink oink!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 7:
                    if (Trestlebridge.GrazingFields.Count == 0)
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
                        Console.WriteLine($"You currently have {Trestlebridge.GrazingFields.Count} grazing fields.");
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
                            Trestlebridge.Sheep += purchaseAmount;
                            Console.WriteLine("Sheep Added! Baa!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
            }
        }

        //Seed Purchase Menu
        public static void SeedPurchaseMenu(Farm Trestlebridge)
        {
            int ploughedFieldCapacity = Trestlebridge.PloughingFields.Count * 13;
            int ploughedFieldSpace = ploughedFieldCapacity
                - Trestlebridge.Sesame
                - Trestlebridge.Sunflower;
            int naturalFieldCapacity = Trestlebridge.NaturalFields.Count * 10;
            int naturalFieldSpace = naturalFieldCapacity
                - Trestlebridge.Wildflower
                - Trestlebridge.Sunflower;

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
                    if (Trestlebridge.PloughingFields.Count == 0)
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
                        Console.WriteLine($"You currently have {Trestlebridge.PloughingFields.Count} ploughed fields and {Trestlebridge.Sesame * 5} sesame plants.");
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
                            Trestlebridge.Sesame += purchaseAmount;
                            Console.WriteLine("Sesame Added!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 2:
                    if (Trestlebridge.PloughingFields.Count == 0 &&
                        Trestlebridge.NaturalFields.Count == 0)
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
                        Console.Write(@$"You currently have {Trestlebridge.PloughingFields.Count} ploughed fields,
{Trestlebridge.NaturalFields.Count} natural fields, and {Trestlebridge.Sunflower * 5} sunflower plants.");
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
                            Trestlebridge.Sunflower += purchaseAmount;
                            Console.WriteLine("Sunflower Added!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
                case 3:
                    if (Trestlebridge.NaturalFields.Count == 0)
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
                        Console.WriteLine($"You currently have {Trestlebridge.NaturalFields.Count} natural fields and {Trestlebridge.Wildflower * 6} wildflower plants.");
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
                            Trestlebridge.Wildflower += purchaseAmount;
                            Console.WriteLine("Wildflower Added!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Utils.Clear();
                            break;
                        }
                    }
            }
        }

        //Processing Menu
        public static void ProcessingMenu(Farm Trestlebridge)
        {
            Console.WriteLine();
            Console.WriteLine("1. Seed Harvester");
            Console.WriteLine("2. Meat Processor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Harvester");
            Console.WriteLine();
            Console.WriteLine("Choose equipment to use:");
        }
    }
}
