using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPlane
    {
        IPoint Origin { get; set; }

        IVector AxisX { get; set; }

        IVector AxisY { get; set; }
    }
}