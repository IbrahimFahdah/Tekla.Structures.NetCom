using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarSplice : IModelObject
    {
        IReinforcement RebarGroup1 { get; set; }

        IReinforcement RebarGroup2 { get; set; }

        RebarSpliceTypeEnum Type { get; set; }

        double LapLength { get; set; }

        double Offset { get; set; }

        double Clearance { get; set; }

        RebarSpliceBarPositionsEnum BarPositions { get; set; }
    }
}