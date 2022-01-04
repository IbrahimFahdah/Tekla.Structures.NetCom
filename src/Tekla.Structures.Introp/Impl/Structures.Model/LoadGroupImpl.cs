using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class LoadGroupImpl : ModelObjectImpl, ILoadGroup 
    {
        private Tekla.Structures.Model.LoadGroup TkLoadGroup =>
            (Tekla.Structures.Model.LoadGroup)TklModelObject;

        public LoadGroupImpl(Tekla.Structures.Model.LoadGroup obj) : base(obj)
        {
        }

        public string GroupName { get; set; }
        public LoadGroupType GroupType { get; set; }
        public LoadGroupDirection Direction { get; set; }
        public int Compatible { get; set; }
        public int Incompatible { get; set; }
    }
}