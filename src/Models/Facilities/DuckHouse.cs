using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IDuck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IDuck> _ducks = new List<IDuck>();

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

            output.Append($"Duck Houses {shortId} has {this._ducks.Count} ducks\n");
            this._ducks.ForEach(d => output.Append($"   {d}\n"));

            return output.ToString();
        }

        public void AddResource(IDuck duck)
        {
            _ducks.Add(duck);
        }

        public void AddResource(List<IDuck> resources)
        {
            throw new NotImplementedException();
        }

        public double GetCount
        {
            get
            {
                return _ducks.Count;
            }
        }
    }
}