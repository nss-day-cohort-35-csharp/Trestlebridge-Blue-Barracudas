using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, INatural plant)
        {
            bool allFull = farm.NaturalFields.All(field => field.GetCount == field.Capacity);
            if (allFull)
            {
                Console.WriteLine("Facilities are all full, press enter to continue");
                Console.ReadLine();

            }
            while (!allFull)
            {

                Utils.Clear();

                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    Console.Write($"{i + 1}. Natural Field: Total Rows: {Math.Floor(farm.NaturalFields[i].GetCount/6)} out of 10 (");

                    farm.NaturalFields[i].listPlants();

                    Console.WriteLine(")");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the plants where?");

                Console.Write("> ");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (farm.NaturalFields[choice - 1].GetCount < farm.NaturalFields[choice - 1].Capacity)
                    {
                        farm.NaturalFields[choice - 1].AddResource(plant);
                        Console.WriteLine("You planted in a Natural Field, press Enter to continue");
                        Console.ReadLine();
                        break;

                    }
                    else
                    {
                        Console.WriteLine("This facility is full, please choose another one");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wrong input, please chose another.");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();

                }

                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);
            }

        }
    }
}