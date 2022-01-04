using System.Collections.Generic;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarSpacing
    {
        List<IRebarSpacingZone> Zones { get; set; }

        double StartOffset { get; set; }

        double EndOffset { get; set; }

        OffsetEnum StartOffsetType { get; set; }

        OffsetEnum EndOffsetType { get; set; }

        bool StartOffsetIsAutomatic { get; set; }

        bool EndOffsetIsAutomatic { get; set; }

        bool InheritFromPrimary { get; set; }
    }
}