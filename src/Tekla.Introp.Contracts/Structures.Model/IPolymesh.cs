using Tekla.Introp.Contracts.Common.Geometry.Shapes;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPolymesh
    {
        IFacetedBrep Brep { get; set; }
    }
}