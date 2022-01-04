using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarHookData
    {
        RebarHookShapeEnum Shape { get; set; }

        double Angle { get; set; }

        double Radius { get; set; }

        double Length { get; set; }
    }
}