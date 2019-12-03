using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IMeatProducing, IEggProducing, IFeathering
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;
        private double _featherProduced = 0.5;
        private int _eggsProduced = 7;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.9;
        public string Type { get; } = "Chicken";

        // Methods
        public void Peck()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Bawk Bawk";
        }

        public int GatheringEggs()
        {
            return _eggsProduced;
        }

        public double GatheringFeathers()
        {
            return _featherProduced;
        }
    }
}