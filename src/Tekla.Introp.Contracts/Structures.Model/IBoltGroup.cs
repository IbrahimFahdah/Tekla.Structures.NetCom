using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBoltGroup : IModelObject
    {
        double BoltSize { get; set; }

        string BoltStandard { get; set; }

        BoltTypeEnum BoltType { get; set; }

        BoltThreadInMaterialEnum ThreadInMaterial { get; set; }

        double Length { get; set; }

        double CutLength { get; set; }

        double ExtraLength { get; set; }

        double Tolerance { get; set; }

        BoltHoleTypeEnum HoleType { get; set; }

        double SlottedHoleX { get; set; }

        double SlottedHoleY { get; set; }

        BoltRotateSlotsEnum RotateSlots { get; set; }

        IPosition Position { get; set; }

        IOffset StartPointOffset { get; set; }

        IOffset EndPointOffset { get; set; }

        bool Washer1 { get; set; }

        bool Washer2 { get; set; }

        bool Washer3 { get; set; }

        bool Nut1 { get; set; }

        bool Nut2 { get; set; }

        bool Bolt { get; set; }

        bool Hole1 { get; set; }

        bool Hole2 { get; set; }

        bool Hole3 { get; set; }

        bool Hole4 { get; set; }

        bool Hole5 { get; set; }

        IPart PartToBoltTo { get; set; }

        IPart PartToBeBolted { get; set; }

        IArrayList OtherPartsToBolt { get; }

        IPoint FirstPosition { get; set; }

        IPoint SecondPosition { get; set; }

        bool ConnectAssemblies { get; set; }

        IArrayList BoltPositions { get; }

        bool AddOtherPartToBolt(IPart M);

        bool RemoveOtherPartToBolt(IPart M);

        IArrayList GetOtherPartsToBolt();

        ISolid GetSolid();

        ISolid GetSolid(bool withHighAccuracy);

        IPourObject GetFatherPour();

        IPourUnit GetFatherPourUnit();
    }
}