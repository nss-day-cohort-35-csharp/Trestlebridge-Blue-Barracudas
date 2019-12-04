using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IChicken>
    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();

        private List<IChicken> _chickens = new List<IChicken>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken Houses {shortId} has {this._chickens.Count} chickens\n");
            this._chickens.ForEach(c => output.Append($"   {c}\n"));

            return output.ToString();
        }

        public void AddResource(IChicken chicken)
        {
            _chickens.Add(chicken);
        }

        public void AddResource(List<IChicken> resources)
        {
            throw new NotImplementedException();
        }

        public double GetCount
        {
            get
            {
                return _chickens.Count;
            }
        }
    }
}