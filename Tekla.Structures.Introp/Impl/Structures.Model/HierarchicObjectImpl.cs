using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class HierarchicObjectImpl : ModelObjectImpl, IHierarchicObject
    {
        private Tekla.Structures.Model.HierarchicObject TkHierarchicObject =>
            (Tekla.Structures.Model.HierarchicObject)TklModelObject;

        public HierarchicObjectImpl(Tekla.Structures.Model.HierarchicObject obj) : base(obj)
        {
        }

        public string Name { get; set; }
        public IHierarchicDefinition Definition { get; set; }
        public IHierarchicObject Father { get; set; }
        public IArrayList HierarchicChildren { get; set; }
        public bool AddObjects(IArrayList Objects)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveObjects(IArrayList Objects)
        {
            throw new System.NotImplementedException();
        }
    }
}