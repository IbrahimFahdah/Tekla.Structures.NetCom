using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarCranking
    {
        CrankSideEnum CrankSide { get; set; }

        double CrankRotation { get; set; }

        double CrankStraightLength { get; set; }

        CrankedLengthTypeEnum CrankedLengthType { get; set; }

        double CrankedRatio { get; set; }

        double CrankedDistance { get; set; }

        double CrankedOffset { get; set; }

        CrankingTypeEnum CrankingType { get; set; }
    }
}