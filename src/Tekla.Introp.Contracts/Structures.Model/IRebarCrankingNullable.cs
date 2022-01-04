using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public class IRebarCrankingNullable
    {
        double? CrankRotation { get; set; }

        double? CrankStraightLength { get; set; }

        public CrankedLengthTypeEnum? CrankedLengthType { get; set; }

        double? CrankedRatio { get; set; }

        double? CrankedDistance { get; set; }

        double? CrankedOffset { get; set; }

        public EndCrankingTypeEnum? CrankingType { get; set; }
    }
}