using System;
using System.Linq;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();

            if (farm.GrazingFields.Count > 0)
            {
                for (int i = 0; i < farm.GrazingFields.Count; i++)
                {
                    int animalCount = farm.GrazingFields[i].CountAnimals();


                    Console.WriteLine($"{i + 1}. Grazing Field ({animalCount} animals).");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the {animal.GetType().Name} where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.GrazingFields[choice - 1].AddResource(animal);

                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);
            }
            else
            {
                Console.WriteLine("No grazing fields present.  Please add a grazing field and try again.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

        }
    }
}