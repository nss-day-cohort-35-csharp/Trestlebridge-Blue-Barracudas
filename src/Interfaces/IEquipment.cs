using System.Collections.Generic;

namespace Trestlebridge.Interfaces
{
    public interface IEquipment
    {
        double ProcessCapacity { get; }

        double ResourceList { get; set; }

    }
}