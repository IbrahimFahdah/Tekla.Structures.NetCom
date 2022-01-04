using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class PositionImpl : TkObjWrapper, IPosition
    {
        private Position TkPosition => (Position)TKObj;

        public PositionImpl(Position position) : base(position)
        {
        }

        public double PlaneOffset
        {
            get => TkPosition.PlaneOffset;
            set => TkPosition.PlaneOffset = value;
        }

        public double DepthOffset
        {
            get => TkPosition.DepthOffset;
            set => TkPosition.DepthOffset = value;
        }
        public double RotationOffset
        {
            get => TkPosition.RotationOffset;
            set => TkPosition.RotationOffset = value;
        }
        public PlaneEnum Plane
        {
            get => (PlaneEnum)TkPosition.Plane;
            set => TkPosition.Plane = (Position.PlaneEnum)value;
        }
        public DepthEnum Depth
        {
            get => (DepthEnum)TkPosition.Depth;
            set => TkPosition.Depth = (Position.DepthEnum)value;
        }
        public RotationEnum Rotation
        {
            get => (RotationEnum)TkPosition.Rotation;
            set => TkPosition.Rotation = (Position.RotationEnum)value;
        }
    }
}