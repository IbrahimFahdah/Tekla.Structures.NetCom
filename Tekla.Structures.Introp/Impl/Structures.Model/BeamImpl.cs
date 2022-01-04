using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using Tekla.Structures.Introp.Impl.Structures.Geometry3d;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class BeamImpl : PartImpl, IBeam
    {
        private Tekla.Structures.Model.Beam Tkbeam => (Tekla.Structures.Model.Beam)TklModelObject;

        private IPoint _startPoint;
        private IPoint _endPoint;

        public BeamImpl() : this(BeamTypeEnum.BEAM)
        {

        }

        public BeamImpl(Tekla.Structures.Model.Beam obj) : base(obj)
        {
        }

        public BeamImpl(BeamTypeEnum beamType) : base(new Tekla.Structures.Model.Beam((Tekla.Structures.Model.Beam.BeamTypeEnum)beamType))
        {
        }

        public BeamTypeEnum Type => (BeamTypeEnum)Tkbeam.Type;

        public IPoint StartPoint
        {
            get => _startPoint ?? (_startPoint = new PointImpl(Tkbeam.StartPoint));
            set => _startPoint = value;
        }

        public IPoint EndPoint
        {
            get => _endPoint ?? (_endPoint = new PointImpl(Tkbeam.EndPoint));
            set => _endPoint = value;
        }
    }
}