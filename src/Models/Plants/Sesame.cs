using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IResource, ISeedProducing, IPlowed
    {
        private int _seedsProduced = 520;
        public string Type { get; } = "Sesame";
        public string returnPlantTypePlowed
        {
            get
            {
                return Type;
            }
        }

        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Sesame. Yum";
        }
    }
}