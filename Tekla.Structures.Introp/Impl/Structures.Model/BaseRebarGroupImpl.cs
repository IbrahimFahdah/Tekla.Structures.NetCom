using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Introp.Impl.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class BaseRebarGroupImpl : ReinforcementImpl, IBaseRebarGroup
    {
        private IPoint _startPoint;
        private IPoint _endPoint;
        private IArrayList _spacings;
        private IRebarHookData _startHook;
        private IRebarHookData _endHook;

        private BaseRebarGroup TkBaseRebarGroup => (BaseRebarGroup)TklModelObject;

        public BaseRebarGroupImpl(BaseRebarGroup baseRebarGroup) : base(baseRebarGroup)
        {
        }

        public string Size
        {
            get => TkBaseRebarGroup.Size;
            set => TkBaseRebarGroup.Size = value;
        }

        public IRebarHookData StartHook
        {
            get => _startHook ?? (_startHook = new RebarHookDataImpl(new RebarHookData()));
            set => _startHook = value;
        }

        public IRebarHookData EndHook
        {
            get => _endHook ?? (_endHook = new RebarHookDataImpl(new RebarHookData()));
            set => _endHook = value;
        }

        public double StartFromPlaneOffset
        {
            get => TkBaseRebarGroup.StartFromPlaneOffset;
            set => TkBaseRebarGroup.StartFromPlaneOffset = value;
        }

        public double EndFromPlaneOffset
        {
            get => TkBaseRebarGroup.EndFromPlaneOffset;
            set => TkBaseRebarGroup.EndFromPlaneOffset = value;
        }

        public ExcludeTypeEnum ExcludeType
        {
            get => (ExcludeTypeEnum)TkBaseRebarGroup.ExcludeType;
            set => TkBaseRebarGroup.ExcludeType = (Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum)value;
        }

        public RebarGroupSpacingTypeEnum SpacingType
        {
            get => (RebarGroupSpacingTypeEnum)TkBaseRebarGroup.SpacingType;
            set => TkBaseRebarGroup.SpacingType = (Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum)value;
        }

        public IArrayList Spacings
        {
            get => _spacings ?? (_spacings = new COMArrayList(TkBaseRebarGroup.Spacings));
            set => _spacings = value;
        }

        public IPoint StartPoint
        {
            get => _startPoint ?? (_startPoint = new PointImpl(TkBaseRebarGroup.StartPoint));
            set => _startPoint = value;
        }

        public IPoint EndPoint
        {
            get => _endPoint ?? (_endPoint = new PointImpl(TkBaseRebarGroup.EndPoint));
            set => _endPoint = value;
        }
    }
}