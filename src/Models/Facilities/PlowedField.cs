using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlowed>
    {
        //Ticket #30
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();

        private List<IPlowed> _plants = new List<IPlowed>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IPlowed plant)
        {
            // TODO: implement this...
            _plants.Add(plant);
        }

        public void AddResource(List<IPlowed> plant)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plants.Count} plants.\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
        public double GetCount
        {
            get
            {
                return _plants.Count;
            }
        }
        public void listPlants()
        {
            var sunflowerSortedList = _plants.Where(sunflower => sunflower.returnPlantTypePlowed == "Sunflower");
            Console.Write($"Sunflower: {sunflowerSortedList.Count()} ");

            var sesameSortedList = _plants.Where(sesame => sesame.returnPlantTypePlowed == "Sesame");
            Console.Write($"Sesame: {sesameSortedList.Count()} ");
        }
    }
}