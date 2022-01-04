using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPosition : ITkObjWrapper
    {
        double PlaneOffset { get; set; }

        double DepthOffset { get; set; }

        double RotationOffset { get; set; }

        PlaneEnum Plane { get; set; }

        DepthEnum Depth { get; set; }

        RotationEnum Rotation { get; set; }
    }
}