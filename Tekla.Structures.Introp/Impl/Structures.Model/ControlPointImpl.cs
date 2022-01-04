using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class ControlPointImpl : ModelObjectImpl, IControlPoint
    {
        private Tekla.Structures.Model.ControlPoint TkControlPoint => (Tekla.Structures.Model.ControlPoint)TklModelObject;

        public ControlPointImpl(Tekla.Structures.Model.ControlPoint obj) : base(obj)
        {
        }

        public IPoint Point { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}