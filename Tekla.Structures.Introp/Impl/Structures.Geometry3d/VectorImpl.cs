using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Introp.Helpers;

namespace Tekla.Structures.Introp.Impl.Structures.Geometry3d
{
    [ComVisible(true)]
    public class VectorImpl : TkObjWrapper, IVector
    {
        private Vector Vector => (Vector)TKObj;

        public VectorImpl(Vector vector) : base(vector)
        {
        }

        public VectorImpl(double X, double Y, double Z) : base(new Vector(X, Y, Z))
        {
        }
    }
}