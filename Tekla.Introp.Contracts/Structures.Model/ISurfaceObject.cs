using Tekla.Introp.Contracts.Common.Geometry.Shapes;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ISurfaceObject : IModelObject
    {
        IFacetedBrep Polymesh { get; set; }

        string Class { get; set; }

        string Name { get; set; }

        bool CreateHoles { get; set; }

        string Type { get; set; }

        IModelObject Father { get; set; }
    }
}