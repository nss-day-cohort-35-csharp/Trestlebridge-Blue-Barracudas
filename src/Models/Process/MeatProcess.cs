using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Process
{
    public class MeatProcess : IEquipment
    {
        public double ProcessCapacity { get; } = 7.0;
        public double ResourceList { get; set; } = 0;

    }

}