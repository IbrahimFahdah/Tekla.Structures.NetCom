using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IHierarchicDefinition : IModelObject
    {
        string Name { get; set; }

        string CustomType { get; set; }

        HierarchicDefinitionTypeEnum HierarchyType { get; set; }

        IHierarchicDefinition Father { get; set; }

        string HierarchyIdentifier { get; set; }

        bool Drawable { get; set; }

        IArrayList HierarchicChildren { get; set; }

        bool AddObjects(IArrayList Objects);

        bool RemoveObjects(IArrayList Objects);
    }
}