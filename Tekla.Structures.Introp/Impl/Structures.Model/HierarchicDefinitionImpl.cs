using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class HierarchicDefinitionImpl : ModelObjectImpl, IHierarchicDefinition
    {
        private Tekla.Structures.Model.HierarchicDefinition TkHierarchicDefinition =>
            (Tekla.Structures.Model.HierarchicDefinition)TklModelObject;

        public HierarchicDefinitionImpl(Tekla.Structures.Model.HierarchicDefinition obj) : base(obj)
        {
        }

        public string Name { get; set; }
        public string CustomType { get; set; }
        public HierarchicDefinitionTypeEnum HierarchyType { get; set; }
        public IHierarchicDefinition Father { get; set; }
        public string HierarchyIdentifier { get; set; }
        public bool Drawable { get; set; }
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