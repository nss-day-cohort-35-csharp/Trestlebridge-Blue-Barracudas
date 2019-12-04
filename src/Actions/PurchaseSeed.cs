using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class PurchaseSeed
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sunflower");
            Console.WriteLine("2. Wildflower");
            Console.WriteLine("3. Sesame");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            var choiceInput = Console.ReadLine();
            int choice;

            while (!(int.TryParse(choiceInput, out choice) && Convert.ToInt32(choiceInput) > 0 && Convert.ToInt32(choiceInput) < 4))
            {
                Console.WriteLine("Please type a number");
                choiceInput = Console.ReadLine();
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Choose a field for the Sunflower");
                    Console.WriteLine("1. Natural Field");
                    Console.WriteLine("2. Plowed Field");
                    var choiceInput2 = Console.ReadLine();
                    int chosen;

                    while (!(int.TryParse(choiceInput2, out chosen) && Convert.ToInt32(choiceInput2) > 0 && Convert.ToInt32(choiceInput2) < 3))
                    {

                        Console.WriteLine("Please type a valid number");
                        choiceInput2 = Console.ReadLine();

                    }
                    if (chosen == 1)
                    {
                        ChooseNaturalField.CollectInput(farm, new Sunflower());
                    }
                    else if (chosen == 2)
                    {
                        ChoosePlowedField.CollectInput(farm, new Sunflower());

                    }

                    break;
                case 2:
                    ChooseNaturalField.CollectInput(farm, new Wildflower());
                    break;
                case 3:
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    break;
                default:
                    break;
            }
        }
    }
}