using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompost, INatural
    {
        private double _compostProduced = 30.3;
        public string Type { get; } = "Wildflower";

        public string returnPlantTypeNatural
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

        public override string ToString()
        {
            return $"Wildflowers. Make other plants grow!";
        }
    }
}