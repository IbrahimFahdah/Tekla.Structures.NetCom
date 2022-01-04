
namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IGeometryNode
    {
        bool IsAutomatic { get; }

        void AcceptVisitor(IGeometryNodeVisitor visitor);

        IGeometryNode Clone();
    }
}