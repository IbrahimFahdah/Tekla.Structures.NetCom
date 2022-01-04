using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IGridCylindricalSurface : IGridSurface
    {
        IArc CylinderBase { get; set; }

        double CylinderHeight { get; set; }
    }
}