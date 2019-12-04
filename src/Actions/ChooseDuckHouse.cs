using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IDuck duck)
        {
            bool allFull = farm.DuckHouses.All(house => house.GetCount == house.Capacity);
            if (allFull)
            {
                Console.WriteLine("No facilities available, press enter to continue");
                Console.ReadLine();

            }
            while (!allFull)
            {

                Utils.Clear();

                for (int i = 0; i < farm.DuckHouses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Duck House: {farm.DuckHouses[i].GetCount} of {farm.DuckHouses[i].Capacity}");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the duck where?");

                Console.Write("> ");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (farm.DuckHouses[choice - 1].GetCount < farm.DuckHouses[choice - 1].Capacity)
                    {
                        farm.DuckHouses[choice - 1].AddResource(duck);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("This duck house is full, please choose another one");
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