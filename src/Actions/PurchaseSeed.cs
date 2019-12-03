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
                // case 1:
                //     ChooseGrazingField.CollectInput(farm, new Sunflo());
                //     break;
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