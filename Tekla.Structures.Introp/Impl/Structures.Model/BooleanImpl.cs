using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public abstract class BooleanImpl : ModelObjectImpl, IBoolean
    {
        public IModelObject Father { get; set; }
    }
}