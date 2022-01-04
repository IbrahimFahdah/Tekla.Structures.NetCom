using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using ISolid = Tekla.Introp.Contracts.Structures.Model.ISolid;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class BoltArrayImpl : ModelObjectImpl, IBoltArray
    {
        private Tekla.Structures.Model.BoltArray TkBoltArray => (Tekla.Structures.Model.BoltArray)TklModelObject;

        public BoltArrayImpl(Tekla.Structures.Model.BoltArray obj) : base(obj)
        {
        }
        public double BoltSize { get; set; }
        public string BoltStandard { get; set; }
        public BoltTypeEnum BoltType { get; set; }
        public BoltThreadInMaterialEnum ThreadInMaterial { get; set; }
        public double Length { get; set; }
        public double CutLength { get; set; }
        public double ExtraLength { get; set; }
        public double Tolerance { get; set; }
        public BoltHoleTypeEnum HoleType { get; set; }
        public double SlottedHoleX { get; set; }
        public double SlottedHoleY { get; set; }
        public BoltRotateSlotsEnum RotateSlots { get; set; }
        public IPosition Position { get; set; }
        public IOffset StartPointOffset { get; set; }
        public IOffset EndPointOffset { get; set; }
        public bool Washer1 { get; set; }
        public bool Washer2 { get; set; }
        public bool Washer3 { get; set; }
        public bool Nut1 { get; set; }
        public bool Nut2 { get; set; }
        public bool Bolt { get; set; }
        public bool Hole1 { get; set; }
        public bool Hole2 { get; set; }
        public bool Hole3 { get; set; }
        public bool Hole4 { get; set; }
        public bool Hole5 { get; set; }
        public IPart PartToBoltTo { get; set; }
        public IPart PartToBeBolted { get; set; }
        public IArrayList OtherPartsToBolt { get; }
        public IPoint FirstPosition { get; set; }
        public IPoint SecondPosition { get; set; }
        public bool ConnectAssemblies { get; set; }
        public IArrayList BoltPositions { get; }
        public bool AddOtherPartToBolt(IPart M)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveOtherPartToBolt(IPart M)
        {
            throw new System.NotImplementedException();
        }

        public IArrayList GetOtherPartsToBolt()
        {
            throw new System.NotImplementedException();
        }

        public ISolid GetSolid()
        {
            throw new System.NotImplementedException();
        }

        public ISolid GetSolid(bool withHighAccuracy)
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

        public bool AddBoltDistX(double DistX)
        {
            throw new System.NotImplementedException();
        }

        public bool AddBoltDistY(double DistY)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveBoltDistX(int Index)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveBoltDistY(int Index)
        {
            throw new System.NotImplementedException();
        }

        public int GetBoltDistXCount()
        {
            throw new System.NotImplementedException();
        }

        public int GetBoltDistYCount()
        {
            throw new System.NotImplementedException();
        }

        public double GetBoltDistX(int Index)
        {
            throw new System.NotImplementedException();
        }

        public double GetBoltDistY(int Index)
        {
            throw new System.NotImplementedException();
        }

        public bool SetBoltDistX(int Index, double DistX)
        {
            throw new System.NotImplementedException();
        }

        public bool SetBoltDistY(int Index, double DistY)
        {
            throw new System.NotImplementedException();
        }
    }
}