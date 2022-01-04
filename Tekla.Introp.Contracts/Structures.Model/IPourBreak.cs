using Tekla.Introp.Contracts.Common.Geometry.Shapes;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPourBreak : IModelObject
    {
        IFacetedBrep Polymesh { get; set; }
    }
}