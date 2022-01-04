using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarSplitter : IBaseRebarModifier
    {
        StaggerTypeEnum StaggerType { get; set; }

        double StaggerOffset { get; set; }

        double SplitOffset { get; set; }

        SplitTypeEnum SplitType { get; set; }

        IRebarLapping Lapping { get; set; }

        IRebarCranking Cranking { get; set; }


        IModelObjectEnumerator GetAffectedBars(AffectedRebarEnum whichEnd);
    }
}