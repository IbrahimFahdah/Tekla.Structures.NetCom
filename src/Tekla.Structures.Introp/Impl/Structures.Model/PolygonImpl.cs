using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class PolygonImpl : TkObjWrapper, IPolygon
    {
        private Polygon TkPolygon => (Polygon)TKObj;

        private IArrayList _points;

        public PolygonImpl() : base(new Polygon())
        {
        }

        public PolygonImpl(Polygon polygon) : base(polygon)
        {
        }

        public IArrayList Points
        {
            get => _points ?? (_points = new COMArrayList(TkPolygon.Points));
            set => _points = value;
        }
    }
}