using System;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
using System.Collections.Generic;
using Trestlebridge.Models.Plants;
using System.Linq;

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
                    Trestlebridge.AddGrazingField();
                    Console.WriteLine("New Grazing Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 2:
                    Trestlebridge.AddPloughingField();
                    Console.WriteLine("New Ploughing Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 3:
                    Trestlebridge.AddNaturalField();
                    Console.WriteLine("New Natural Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 4:
                    Trestlebridge.AddChickenCoop();
                    Console.WriteLine("New Chicken Coop Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 5:
                    Trestlebridge.AddDuckHouse();
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

            int ChickenInventory = Trestlebridge.Animals[c];
            int DuckInventory = Trestlebridge.Animals[d];
            int coopCapacity = Trestlebridge.Facilities[coop] * coop.Capacity;
            int coopSpace = coopCapacity - Trestlebridge.Animals[c];
            int duckHouseCapacity = Trestlebridge.Facilities[dh] * dh.Capacity;
            int duckHouseSpace = duckHouseCapacity - Trestlebridge.Animals[d];
            int grazingFieldCapacity = Trestlebridge.Facilities[gf] * gf.Capacity;
            int grazingFieldSpace = grazingFieldCapacity
                - Trestlebridge.Animals[cow]
                - Trestlebridge.Animals[p]
                - Trestlebridge.Animals[o]
                - Trestlebridge.Animals[s]
                - Trestlebridge.Animals[g];
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
                    if (Trestlebridge.Animals[c] == 0)
                    {
                        Console.WriteLine("You can't buy chickens until you purchase a chicken coop!");
                        Console.ReadKey();
                        break;
                    }
                    else if ((coopCapacity - Trestlebridge.Animals[c]) == 0)
                    {
                        Console.WriteLine("Your chicken coops are at capacity!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[coop]} chicken coops and {Trestlebridge.Animals[c]} chickens.");
                        Console.WriteLine($"You have space for {(coopCapacity - Trestlebridge.Animals[c])} chickens.");
                        Console.Write("How many chickens would you like to purchase?  ");
                        var purchaseAmount = Int32.Parse(Console.ReadLine());
                        if (purchaseAmount > (coopCapacity - Trestlebridge.Animals[c]))
                        {
                            Console.WriteLine("You don't have room for that many chickens!");
                            Console.WriteLine("Please lower your purchase amount.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Trestlebridge.Animals[c] += purchaseAmount;
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
                            Trestlebridge.Animals[cow] += purchaseAmount;
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
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[dh]} duck houses and {Trestlebridge.Animals[d]} ducks.");
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
                            Trestlebridge.Animals[d] += purchaseAmount;
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
                            Trestlebridge.Animals[g] += purchaseAmount;
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
                            Trestlebridge.Animals[o] += purchaseAmount;
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
                            Trestlebridge.Animals[p] += purchaseAmount;
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
                            Trestlebridge.Animals[s] += purchaseAmount;
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
            PloughingField pf = new();
            NaturalField nf = new();
            Sunflower sunflower = new();
            Sesame sesame = new();
            Wildflower wildflower = new();
            
            int ploughedFieldCapacity = Trestlebridge.Facilities[pf];
            int ploughedFieldSpace = ploughedFieldCapacity
                - Trestlebridge.Plants[sunflower]
                - Trestlebridge.Plants[sesame];
            int naturalFieldCapacity = Trestlebridge.Facilities[nf] * nf.Capacity;
            int naturalFieldSpace = naturalFieldCapacity
                - Trestlebridge.Plants[sesame]
                - Trestlebridge.Plants[sunflower];

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
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[pf]} ploughed fields and {Trestlebridge.Plants[sesame]} sesame plants.");
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
                            Trestlebridge.Plants[sesame] += purchaseAmount;
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
{Trestlebridge.Facilities[nf]} natural fields, and {Trestlebridge.Plants[sunflower]} sunflower plants.");
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
                            Trestlebridge.Plants[sunflower] += purchaseAmount;
                            Console.WriteLine("Sunflower Added!");
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
                        Console.WriteLine($"You currently have {Trestlebridge.Facilities[nf]} natural fields and {Trestlebridge.Plants[wildflower]} wildflower plants.");
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
                            Trestlebridge.Plants[wildflower] += purchaseAmount;
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
            int input = Int32.Parse(Console.ReadLine());

            Sunflower sunflower = new();
            Sesame sesame = new();
            Wildflower wildflower = new();
            NaturalField nf = new();
            PloughingField pf = new();

            

            switch (input)
            {
                case 1:
                    if (Trestlebridge.Plants[sunflower] == 0 && Trestlebridge.Plants[sesame] == 0 && Trestlebridge.Plants[wildflower] == 0)
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
                        foreach (var plant in Trestlebridge.Plants)
                        {
                            if (plant.Key.Location == nf)
                            {
                                Console.WriteLine($"{plant.Key}: {plant.Value}");
                                Console.WriteLine($"Produces {plant.Key.Product}");
                                Console.WriteLine();
                            }
                        }
                        input = Int32.Parse(Console.ReadLine());
                    }
                    else if (input == 2)
                    {
                        var ploughedFieldList = new Dictionary<IPlant, int>();

                        foreach (var plant in Trestlebridge.Plants)
                        {
                            if (plant.Key.Location == pf)
                            {
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
                        
                        Trestlebridge.Plants[ChosenPlant.Key] =- amount;
                        
                        foreach (var product in  ChosenPlant.Key.Product)
                        {
                            Trestlebridge.Products[product.Key] =+ amount;
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
