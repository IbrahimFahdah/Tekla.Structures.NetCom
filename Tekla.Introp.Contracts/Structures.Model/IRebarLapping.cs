using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarLapping
    {
        double LapLength { get; set; }

        LapSideEnum LapSide { get; set; }

        LapPlacementEnum LapPlacement { get; set; }

        LappingTypeEnum LappingType { get; set; }
    }
}