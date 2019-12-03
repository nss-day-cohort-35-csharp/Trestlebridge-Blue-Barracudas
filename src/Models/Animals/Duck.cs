using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IEggProducing, IFeathering, IDuck
    {

        private Guid _id = Guid.NewGuid();
        private double _featherProduced = 0.75;
        private int _eggsProduced = 6;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.8;
        public string Type { get; } = "Duck";

        // Methods
        public void Peck()
        {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack Quack!";
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