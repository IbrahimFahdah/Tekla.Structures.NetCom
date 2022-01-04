using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarHookDataNullable
    {
        RebarHookShapeEnum? Shape { get; set; }

        double? Angle { get; set; }

        double? Radius { get; set; }

        double? Length { get; set; }

        double? Rotation { get; set; }
    }
}