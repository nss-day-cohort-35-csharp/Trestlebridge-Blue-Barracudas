using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Ostrich":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Pig":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Sheep":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Goat":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Chicken":
                    ChickenHouses[index].AddResource((IChicken)resource);
                    break;
                case "Duck":
                    DuckHouses[index].AddResource((IDuck)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            try
            {
                GrazingFields.Add(field);
                //Ticket #19
                Console.WriteLine("A new grazing field has been created!");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not add a grazing field.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

        }

        public void AddNaturalField(NaturalField field)
        {
            try
            {
                NaturalFields.Add(field);
                //Ticket #29
                Console.WriteLine("A new natural field has been created!");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not add a natural field.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

        }
        public void AddPlowedField(PlowedField field)
        {
            try
            {
                PlowedFields.Add(field);
                //Ticket #30
                Console.WriteLine("A new plowed field has been created!");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not add a plowed field.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

        }
        public void AddChickenHouse(ChickenHouse chickenHouse)
        {
            try
            {
                ChickenHouses.Add(chickenHouse);
                //Ticket #29
                Console.WriteLine("A new chicken house has been created!");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not add a chicken house.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

        }
        public void AddDuckHouse(DuckHouse duckHouse)
        {
            try
            {
                DuckHouses.Add(duckHouse);
                //Ticket #29
                Console.WriteLine("A new duck house has been created!");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not add a duck house.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            NaturalFields.ForEach(nf => report.Append(nf));
            PlowedFields.ForEach(pf => report.Append(pf));
            ChickenHouses.ForEach(ch => report.Append(ch));
            DuckHouses.ForEach(dh => report.Append(dh));

            return report.ToString();
        }
    }
}