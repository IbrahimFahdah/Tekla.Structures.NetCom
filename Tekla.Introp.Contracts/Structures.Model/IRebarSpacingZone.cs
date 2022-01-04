using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarSpacingZone
    {
        int NumberOfSpaces { get; set; }

        double Spacing { get; set; }

        double Length { get; set; }

        SpacingEnum NumberOfSpacesType { get; set; }

        SpacingEnum SpacingType { get; set; }

        LengthEnum LengthType { get; set; }
    }
}