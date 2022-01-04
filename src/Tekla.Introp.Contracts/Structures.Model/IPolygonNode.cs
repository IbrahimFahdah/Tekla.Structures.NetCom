namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPolygonNode : IGeometryNode
    {
        IContour Contour { get; }
    }
}