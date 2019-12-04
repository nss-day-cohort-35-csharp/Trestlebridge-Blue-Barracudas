using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Process
{
    public class Composter : IEquipment
    {
        public double ProcessCapacity { get; } = 8;
        public double ResourceList { get; set; } = 0;

    }

}