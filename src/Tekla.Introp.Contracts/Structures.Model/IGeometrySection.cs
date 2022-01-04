namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IGeometrySection
    {
        int Index { get; }

        IGeometryNode GeometryNode { get; }
    }
}