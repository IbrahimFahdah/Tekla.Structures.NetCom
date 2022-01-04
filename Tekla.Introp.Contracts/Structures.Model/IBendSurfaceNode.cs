namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBendSurfaceNode : IGeometryNode
    {
        IBendSurface Surface { get; }
    }
}