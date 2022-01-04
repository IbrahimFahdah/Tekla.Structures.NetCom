using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class FittingImpl : ModelObjectImpl, IFitting
    {
        private Tekla.Structures.Model.Fitting TkFitting =>
            (Tekla.Structures.Model.Fitting)TklModelObject;

        public FittingImpl(Tekla.Structures.Model.Fitting obj) : base(obj)
        {
        }

        public IModelObject Father { get; set; }
        public IPlane Plane { get; set; }
    }
}