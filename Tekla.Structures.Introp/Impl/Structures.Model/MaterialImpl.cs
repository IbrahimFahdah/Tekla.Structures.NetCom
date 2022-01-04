using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class MaterialImpl : TkObjWrapper, IMaterial
    {
        private Material TkMaterial => (Material)TKObj;

        public MaterialImpl(Material material) : base(material)
        {
        }

        public string MaterialString
        {
            get => TkMaterial.MaterialString;
            set => TkMaterial.MaterialString = value;
        }
    }
}