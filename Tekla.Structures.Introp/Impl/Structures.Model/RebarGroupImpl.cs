using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class RebarGroupImpl : BaseRebarGroupImpl, IRebarGroup
    {
        private RebarGroup TkRebarGroup => (RebarGroup)TklModelObject;

        private IArrayList _polygons;

        public RebarGroupImpl() : this(new RebarGroup())
        {

        }

        public RebarGroupImpl(RebarGroup obj) : base(obj)
        {
        }

        public IArrayList Polygons
        {
            get => _polygons ?? (_polygons = new COMArrayList(TkRebarGroup.Polygons));
            set => _polygons = value;
        }

        public RebarGroupStirrupTypeEnum StirrupType
        {
            get => (RebarGroupStirrupTypeEnum)TkRebarGroup.StirrupType;
            set => TkRebarGroup.StirrupType = (RebarGroup.RebarGroupStirrupTypeEnum)value;
        }
    }
}