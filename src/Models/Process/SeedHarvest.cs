using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Process
{
    public class SeedHarvest : IEquipment
    {
        public double ProcessCapacity { get; } = 5;
        public double ResourceList { get; set; } = 0;

    }

}