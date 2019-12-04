using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ProcessEggs
    {
        public static void CollectInput(Farm farm)
        {

            var totalChickens = farm.ChickenHouses.Select(house => house.GetCount).Sum();
            var totalDucks = farm.DuckHouses.Select(house => house.GetCount).Sum();
            var totalOstriches = farm.GrazingFields.Select(house => house.GetOstrichCount).Sum();

            Console.WriteLine($"1. Process Chicken Eggs ({totalChickens} chickens)");
            Console.WriteLine($"2. Process Duck Eggs ({totalDucks} duck)");
            Console.WriteLine($"3. Process Ostrich Eggs ({totalOstriches} ostriches)");

            // Console.WriteLine();
            // Console.WriteLine("What are you buying today?");

            // Console.Write("> ");
            // var choiceInput = Console.ReadLine();
            // int choice;

            // switch (choice)
            // {
            //     case 2:
            //         ChooseGrazingField.CollectInput(farm, new Cow());
            //         break;
            //     case 5:
            //         ChooseGrazingField.CollectInput(farm, new Ostrich());
            //         break;
            //     case 6:
            //         ChooseGrazingField.CollectInput(farm, new Pig());
            //         break;
            //     default:
            //         break;
            // }
        }


    }
}