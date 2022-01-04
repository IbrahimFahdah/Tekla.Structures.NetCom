using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Forming.Enums;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Model;
using ISolid = Tekla.Introp.Contracts.Structures.Model.ISolid;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class ReinforcementImpl : ModelObjectImpl, IReinforcement
    {
        private Reinforcement TkReinforcement => (Reinforcement)TklModelObject;

        private IModelObject _father;
        private IArrayList _radiusValues;
        private IArrayList _onPlaneOffsets;

        public ReinforcementImpl(Reinforcement reinforcement) : base(reinforcement)
        {
            NumberingSeries = new NumberingSeriesImpl();
        }

        public IModelObject Father
        {
            get => _father;
            set => _father = value;
        }

        public string Grade
        {
            get => TkReinforcement.Grade;
            set => TkReinforcement.Grade = value;
        }

        public string Name
        {
            get => TkReinforcement.Name;
            set => TkReinforcement.Name = value;
        }


        public int Class
        {
            get => TkReinforcement.Class;
            set => TkReinforcement.Class = value;
        }

        public INumberingSeries NumberingSeries { get; set; }

        public IArrayList OnPlaneOffsets
        {
            get => _onPlaneOffsets ?? (_onPlaneOffsets = new COMArrayList(TkReinforcement.OnPlaneOffsets));
            set => _onPlaneOffsets = value;
        }

        public double FromPlaneOffset
        {
            get => TkReinforcement.FromPlaneOffset;
            set => TkReinforcement.FromPlaneOffset = value;
        }

        public RebarOffsetTypeEnum StartPointOffsetType
        {
            get => (RebarOffsetTypeEnum)TkReinforcement.StartPointOffsetType;
            set => TkReinforcement.StartPointOffsetType = (Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum)value;
        }

        public double StartPointOffsetValue
        {
            get => TkReinforcement.StartPointOffsetValue;
            set => TkReinforcement.StartPointOffsetValue = value;
        }

        public RebarOffsetTypeEnum EndPointOffsetType
        {
            get => (RebarOffsetTypeEnum)TkReinforcement.EndPointOffsetType;
            set => TkReinforcement.EndPointOffsetType = (Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum)value;
        }

        public double EndPointOffsetValue
        {
            get => TkReinforcement.EndPointOffsetValue;
            set => TkReinforcement.EndPointOffsetValue = value;
        }

        public IArrayList RadiusValues
        {
            get => _radiusValues ?? (_radiusValues = new COMArrayList(TkReinforcement.RadiusValues));
            set => _radiusValues = value;
        }

        public DeformingType InputPointDeformingState
        {
            get => (DeformingType)TkReinforcement.InputPointDeformingState;
            set => TkReinforcement.InputPointDeformingState = (Forming.DeformingType)value;
        }

        public IArrayList GetRebarGeometries(RebarGeometryOptionEnum options)
        {
            return new COMArrayList(TkReinforcement.GetRebarGeometries((Reinforcement.RebarGeometryOptionEnum)options));
        }

        public IArrayList GetRebarGeometries(bool withHooks)
        {
            return new COMArrayList(TkReinforcement.GetRebarGeometries(withHooks));
        }

        public IArrayList GetRebarGeometriesWithoutClashes(bool withHooks)
        {
            return new COMArrayList(TkReinforcement.GetRebarGeometriesWithoutClashes(withHooks));
        }

        public bool IsGeometryValid()
        {
            return TkReinforcement.IsGeometryValid();
        }

        public int GetNumberOfRebars()
        {
            return TkReinforcement.GetNumberOfRebars();
        }

        public IRebarGeometry GetSingleRebar(int index, bool withHooks)
        {
            throw new System.NotImplementedException();
        }

        public IRebarGeometry GetSingleRebarWithoutClash(int index, bool withHooks)
        {
            throw new System.NotImplementedException();
        }

        public ISolid GetSolid()
        {
            throw new System.NotImplementedException();
        }

        public IPourObject GetFatherPour()
        {
            throw new System.NotImplementedException();
        }

        public IPourUnit GetFatherPourUnit()
        {
            throw new System.NotImplementedException();
        }
    }
}