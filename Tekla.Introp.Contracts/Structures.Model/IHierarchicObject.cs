namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IHierarchicObject : IModelObject
    {
        string Name { get; set; }

        IHierarchicDefinition Definition { get; set; }

        IHierarchicObject Father { get; set; }

        IArrayList HierarchicChildren { get; set; }

        bool AddObjects(IArrayList Objects);

        bool RemoveObjects(IArrayList Objects);
    }
}