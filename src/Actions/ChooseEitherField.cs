using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseEitherField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        {
            Utils.Clear();
            if (farm.PlowingFields.Count > 0 || farm.NaturalFields.Count > 0)
            {
                for (int i = 0; i < farm.PlowingFields.Count; i++)
                {
                    int plantCount = farm.PlowingFields[i].CountPlants();

                    Console.WriteLine($"{i + 1}. Plowing Field ({plantCount} rows of plants).");
                }

                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    int plantCount = farm.NaturalFields[i].CountPlants();

                    Console.WriteLine($"{i + 1 + farm.PlowingFields.Count}. Natural Field ({plantCount} rows of plants).");
                }

                Console.WriteLine();

                // How can I output the type of plant chosen here?
                Console.WriteLine($"Place the {plant.GetType().Name} where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                if (choice <= farm.PlowingFields.Count())
                {
                    farm.PlowingFields[choice - 1].AddResource(plant);
                }
                else if (choice > farm.PlowingFields.Count() && choice <= farm.PlowingFields.Count() + farm.NaturalFields.Count())
                {
                    farm.NaturalFields[choice - 1].AddResource(plant);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Press enter to return to main menu.  You suck.");
                    Console.ReadLine();
                }

                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(plant, choice);
            }
            else
            {
                Console.WriteLine("No plowing fields present.  Please add a plowing field and try again.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
        }
    }
}