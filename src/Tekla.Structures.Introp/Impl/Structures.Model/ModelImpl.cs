using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Impl.Structures.Geometry3d;
using IPolygon = Tekla.Introp.Contracts.Structures.Model.IPolygon;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    [Guid(Guids.CLSID_Model)]
    public class ModelImpl : Tekla.Introp.Contracts.Structures.Model.IModel
    {
        private Tekla.Structures.Model.Model _model;

        public ModelImpl()
        {
            _model = new Tekla.Structures.Model.Model();
        }

        public bool GetConnectionStatus()
        {
            return _model.GetConnectionStatus();
        }

        public IModelInfo GetInfo()
        {
            return new ModelInfoImpl(_model.GetInfo());
        }

        public IModelObjectSelector GetModelObjectSelector()
        {
            return new ModelObjectSelectorImpl(_model.GetModelObjectSelector());
        }

        public bool CommitChanges()
        {
            return _model.CommitChanges();
        }

        public IBeam CreateBeam()
        {
            return new BeamImpl();
        }

        public Tekla.Introp.Contracts.Structures.Model.IConnection CreateConnection()
        {
            return new ConnectionImpl();
        }

        public IVector CreateVector(double X, double Y, double Z)
        {
            return new VectorImpl(X, Y, Z);
        }

        public IPoint CreatePoint(double X, double Y, double Z)
        {
            return new PointImpl(X, Y, Z);
        }

        public IPolygon CreatePolygon()
        {
            return new PolygonImpl();
        }

        public IRebarGroup CreateRebarGroup()
        {
            return new RebarGroupImpl();
        }
    }
}
