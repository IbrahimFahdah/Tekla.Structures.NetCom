using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ISpiralBeam : IPart
    {
        IPoint StartPoint { get; set; }

        IPoint RotationAxisBasePoint { get; set; }

        IPoint RotationAxisUpPoint { get; set; }

        double TotalRise { get; set; }

        double RotationAngle { get; set; }

        double TwistAngleStart { get; set; }

        double TwistAngleEnd { get; set; }

        IPoint RotationCenterPoint { get; }

        IVector RotationAxisDirection { get; }

        IPoint EndPoint { get; }
    }
}