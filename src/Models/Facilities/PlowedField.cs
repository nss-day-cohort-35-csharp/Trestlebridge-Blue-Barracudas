using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class PlowedField : IFacility<IPlowed>
    {
        //Ticket #30
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IPlowed> _plants = new List<IPlowed>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IPlowed plant)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource (List<IPlowed> plant) 
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
    }
}