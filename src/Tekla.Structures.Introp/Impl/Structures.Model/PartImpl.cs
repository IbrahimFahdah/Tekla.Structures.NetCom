using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using Tekla.Structures.Model;
using IAssemblable = Tekla.Introp.Contracts.Structures.Model.IAssemblable;
using ISolid = Tekla.Introp.Contracts.Structures.Model.ISolid;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public abstract class PartImpl : ModelObjectImpl, IPart
    {
        private Part TkPart => (Beam)TklModelObject;

        private IPosition _position;
        private IProfile _profile;
        private IMaterial _material;

        protected PartImpl()
        {
        }

        protected PartImpl(Part obj) : base(obj)
        {
        }

        public IProfile Profile
        {
            get => _profile ?? (_profile = new ProfileImpl(TkPart.Profile));
            set => _profile = value;
        }

        public IMaterial Material
        {
            get => _material ?? (_material = new MaterialImpl(TkPart.Material));
            set => _material = value;
        }

        public IDeformingData DeformingData { get; set; }

        public INumberingSeries PartNumber { get; set; }

        public INumberingSeries AssemblyNumber { get; set; }

        public string Name
        {
            get => TkPart.Name;
            set => TkPart.Name = value;
        }

        public string Class
        {
            get => TkPart.Class;
            set => TkPart.Class = value;
        }

        public string Finish
        {
            get => TkPart.Finish;
            set => TkPart.Finish = value;
        }

        public CastUnitTypeEnum CastUnitType
        {
            get => (CastUnitTypeEnum)TkPart.CastUnitType;
            set => TkPart.CastUnitType = (Tekla.Structures.Model.Part.CastUnitTypeEnum)value;
        }

        public int PourPhase
        {
            get => TkPart.PourPhase;
            set => TkPart.PourPhase = value;
        }

        public IPosition Position
        {
            get => _position ?? (_position = new PositionImpl(TkPart.Position));
            set => _position = value;
        }

        public ISolid GetSolid()
        {
            throw new System.NotImplementedException();
        }

        public ISolid GetSolid(SolidCreationTypeEnum solidCreationType)
        {
            throw new System.NotImplementedException();
        }

        IAssembly GetAssembly()
        {
            throw new System.NotImplementedException();
        }

        public string GetPartMark()
        {
            throw new System.NotImplementedException();
        }

        public IArrayList GetCenterLine(bool withCutsFittings)
        {
            throw new System.NotImplementedException();
        }

        public IArrayList GetReferenceLine(bool withCutsFittings)
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetComponents()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetBooleans()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetBolts()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetWelds()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetReinforcements()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetSurfaceTreatments()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetSurfaceObjects()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetPours()
        {
            throw new System.NotImplementedException();
        }

        public ICoordinateSystem GetDSTVCoordinateSystem()
        {
            throw new System.NotImplementedException();
        }

        IAssembly IAssemblable.GetAssembly()
        {
            throw new System.NotImplementedException();
        }
    }
}