using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompost, IPlowed, INatural
    {
        private int _seedsProduced = 650;

        private double _compostProduced = 21.6;
        public string Type { get; } = "Sunflower";
        public string returnPlantTypeNatural
        {
            get
            {
                return Type;
            }
        }
        public string returnPlantTypePlowed
        {
            get
            {
                return Type;
            }
        }

        public double GatheringCompost()
        {
            return _compostProduced;
        }

        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Sunflowers. They make me happy!";
        }
    }
}