using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILoadUniform : ILoad
    {
        IPolygon Polygon { get; set; }

        IVector P1 { get; set; }

        double DistanceA { get; set; }
    }
}