using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IChicken chicken)
        {
            bool allFull = farm.ChickenHouses.All(house => house.GetCount == house.Capacity);
            if (allFull)
            {
                Console.WriteLine("No facilities available, press enter to continue");
                Console.ReadLine();

            }
            while (!allFull)
            {

                Utils.Clear();

                for (int i = 0; i < farm.ChickenHouses.Count; i++)
                {
                    if (farm.ChickenHouses[i].GetCount != farm.ChickenHouses[i].Capacity)
                        Console.WriteLine($"{i + 1}. Chicken House: {farm.ChickenHouses[i].GetCount} of {farm.ChickenHouses[i].Capacity})");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the chicken where?");

                Console.Write("> ");
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (farm.ChickenHouses[choice - 1].GetCount < farm.ChickenHouses[choice - 1].Capacity)
                    {
                        farm.ChickenHouses[choice - 1].AddResource(chicken);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("This chicken house is full, please choose another one");
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