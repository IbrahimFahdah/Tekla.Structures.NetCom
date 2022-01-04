using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Introp.Helpers;

namespace Tekla.Structures.Introp.Impl.Structures.Geometry3d
{
    [ComVisible(true)]
    public class PointImpl : TkObjWrapper, IPoint
    {
        private Point Point => (Point)TKObj;

        public PointImpl(Point point) : base(point)
        {
        }

        public PointImpl(double X, double Y, double Z) : base(new Point(X, Y, Z))
        {
        }

        public double X
        {
            get => Point.X;
            set => Point.X = value;
        }

        public double Y
        {
            get => Point.Y;
            set => Point.Y = value;
        }
        public double Z
        {
            get => Point.Z;
            set => Point.Z = value;
        }
    }
}