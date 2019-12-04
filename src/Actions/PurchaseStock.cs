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
            Console.WriteLine("1. Chicken");
            Console.WriteLine("2. Cow");
            Console.WriteLine("3. Duck");
            Console.WriteLine("4. Goat");
            Console.WriteLine("5. Ostrich");
            Console.WriteLine("6. Pig");
            Console.WriteLine("7. Sheep");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            var choiceInput = Console.ReadLine();
            int choice;

            while (!(int.TryParse(choiceInput, out choice) && Convert.ToInt32(choiceInput) > 0 && Convert.ToInt32(choiceInput) < 8))
            {
                Console.WriteLine("Please type a number");
                choiceInput = Console.ReadLine();
            }
            switch (choice)
            {
                case 2:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                case 6:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                case 7:
                    ChooseGrazingField.CollectInput(farm, new Sheep());
                    break;
                case 4:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    break;
                case 1:
                    ChooseChickenHouse.CollectInput(farm, new Chicken());
                    break;
                case 3:
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    break;
                default:
                    break;
            }
        }
    }
}