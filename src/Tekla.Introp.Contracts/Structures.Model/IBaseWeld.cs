using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBaseWeld : IModelObject
    {
        IModelObject MainObject { get; set; }

        IModelObject SecondaryObject { get; set; }

        double SizeAbove { get; set; }

        double AdditionalSizeAbove { get; set; }

        WeldTypeEnum TypeAbove { get; set; }

        double AngleAbove { get; set; }

        double LengthAbove { get; set; }

        WeldContourEnum ContourAbove { get; set; }

        WeldFinishEnum FinishAbove { get; set; }

        double PitchAbove { get; set; }

        double SizeBelow { get; set; }

        double AdditionalSizeBelow { get; set; }

        WeldTypeEnum TypeBelow { get; set; }

        double AngleBelow { get; set; }

        double LengthBelow { get; set; }

        WeldContourEnum ContourBelow { get; set; }

        WeldFinishEnum FinishBelow { get; set; }

        double PitchBelow { get; set; }

        bool ShopWeld { get; set; }

        bool AroundWeld { get; set; }


        double RootOpeningAbove { get; set; }

        double RootFaceAbove { get; set; }

        double EffectiveThroatAbove { get; set; }

        int IncrementAmountAbove { get; set; }

        double RootOpeningBelow { get; set; }

        double RootFaceBelow { get; set; }

        double EffectiveThroatBelow { get; set; }

        int IncrementAmountBelow { get; set; }

        WeldElectrodeClassificationEnum ElectrodeClassification { get; set; }

        double ElectrodeStrength { get; set; }

        double ElectrodeCoefficient { get; set; }

        WeldProcessTypeEnum ProcessType { get; set; }

        WeldNDTInspectionEnum NDTInspection { get; set; }

        bool ConnectAssemblies { get; set; }

        string ReferenceText { get; set; }

        string PrefixAboveLine { get; set; }

        string PrefixBelowLine { get; set; }

        int WeldNumber { get; }

        string WeldNumberPrefix { get; set; }

        WeldIntermittentTypeEnum IntermittentType { get; set; }

        WeldPlacementTypeEnum Placement { get; set; }

        WeldPreparationTypeEnum Preparation { get; set; }

        IArrayList GetWeldGeometries();

        ISolid GetSolid();
    }
}