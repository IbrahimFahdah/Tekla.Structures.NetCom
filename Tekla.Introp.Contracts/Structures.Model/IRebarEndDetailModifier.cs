using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarEndDetailModifier : IBaseRebarModifier
    {
        IRebarHookDataNullable RebarHook { get; set; }

        IRebarThreadingDataNullable RebarThreading { get; set; }

        IRebarLengthAdjustmentDataNullable RebarLengthAdjustment { get; set; }

        IRebarCrankingNullable RebarCranking { get; set; }

        EndTypeEnum? EndType { get; set; }


        IModelObjectEnumerator GetAffectedBars(AffectedRebarEnum whichEnd);
    }
}