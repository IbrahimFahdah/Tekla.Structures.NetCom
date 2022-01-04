using Tekla.Introp.Contracts.Structures.Model.ModelInternal;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IGeometryNodeVisitor
    {
        void Visit(IPolygonNode node);

        void Visit(ICylindricalSurfaceNode node);

        void Visit(ISpiralNode node);
    }
}