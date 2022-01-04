using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarGeometry
    {
        IPolyLine Shape { get; }

        double Diameter { get; }

        IArrayList BendingRadiuses { get; }
    }
}