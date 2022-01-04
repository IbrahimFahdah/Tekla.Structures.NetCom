using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Impl.Structures.Model;

namespace Tekla.Structures.Introp.Helpers
{
    internal static class IModelObjectExt
    {
        internal static Tekla.Structures.Model.ModelObject GetTklModelObject(this IModelObject obj)
        {
            return ((ModelObjectImpl)obj).TklModelObject;
        }
    }
}