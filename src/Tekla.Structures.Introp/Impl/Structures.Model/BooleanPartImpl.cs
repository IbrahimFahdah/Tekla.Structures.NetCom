using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class BooleanPartImpl : ModelObjectImpl, IBooleanPart
    {
        private Tekla.Structures.Model.BooleanPart TkBooleanPart =>
            (Tekla.Structures.Model.BooleanPart)TklModelObject;

        public BooleanPartImpl(Tekla.Structures.Model.BooleanPart obj) : base(obj)
        {
        }

        public IModelObject Father { get; set; }
        public BooleanTypeEnum Type { get; set; }
        public IPart OperativePart { get; set; }
        public bool SetOperativePart(IPart Part)
        {
            throw new System.NotImplementedException();
        }
    }
}