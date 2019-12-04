using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Process
{
    public class EggGather : IEquipment
    {
        public double ProcessCapacity { get; } = 15;
        public double ResourceList { get; set; } = 0;

    }

}