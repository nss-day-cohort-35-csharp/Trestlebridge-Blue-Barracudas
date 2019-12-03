using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Ostrich");
            Console.WriteLine("3. Pig");
            Console.WriteLine("4. Sheep");
            Console.WriteLine("5. Goat");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            var choiceInput = Console.ReadLine();
            int choice;

            while (!(int.TryParse(choiceInput, out choice) && Convert.ToInt32(choiceInput) > 0 && Convert.ToInt32(choiceInput) < 6))
            {
                Console.WriteLine("Please type a number");
                choiceInput = Console.ReadLine();
            }
            switch (choice)
            {
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                case 2:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                case 3:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                case 4:
                    ChooseGrazingField.CollectInput(farm, new Sheep());
                    break;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    break;
                default:
                    break;
            }
        }
    }
}