using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using ISolid = Tekla.Introp.Contracts.Structures.Model.ISolid;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class WeldImpl : ModelObjectImpl, IWeld
    {
        private Tekla.Structures.Model.Weld TkWeld => (Tekla.Structures.Model.Weld)TklModelObject;

        public WeldImpl(Tekla.Structures.Model.Weld obj) : base(obj)
        {
        }

        public IModelObject MainObject { get; set; }
        public IModelObject SecondaryObject { get; set; }
        public double SizeAbove { get; set; }
        public double AdditionalSizeAbove { get; set; }
        public WeldTypeEnum TypeAbove { get; set; }
        public double AngleAbove { get; set; }
        public double LengthAbove { get; set; }
        public WeldContourEnum ContourAbove { get; set; }
        public WeldFinishEnum FinishAbove { get; set; }
        public double PitchAbove { get; set; }
        public double SizeBelow { get; set; }
        public double AdditionalSizeBelow { get; set; }
        public WeldTypeEnum TypeBelow { get; set; }
        public double AngleBelow { get; set; }
        public double LengthBelow { get; set; }
        public WeldContourEnum ContourBelow { get; set; }
        public WeldFinishEnum FinishBelow { get; set; }
        public double PitchBelow { get; set; }
        public bool ShopWeld { get; set; }
        public bool AroundWeld { get; set; }
        public double RootOpeningAbove { get; set; }
        public double RootFaceAbove { get; set; }
        public double EffectiveThroatAbove { get; set; }
        public int IncrementAmountAbove { get; set; }
        public double RootOpeningBelow { get; set; }
        public double RootFaceBelow { get; set; }
        public double EffectiveThroatBelow { get; set; }
        public int IncrementAmountBelow { get; set; }
        public WeldElectrodeClassificationEnum ElectrodeClassification { get; set; }
        public double ElectrodeStrength { get; set; }
        public double ElectrodeCoefficient { get; set; }
        public WeldProcessTypeEnum ProcessType { get; set; }
        public WeldNDTInspectionEnum NDTInspection { get; set; }
        public bool ConnectAssemblies { get; set; }
        public string ReferenceText { get; set; }
        public string PrefixAboveLine { get; set; }
        public string PrefixBelowLine { get; set; }
        public int WeldNumber { get; }
        public string WeldNumberPrefix { get; set; }
        public WeldIntermittentTypeEnum IntermittentType { get; set; }
        public WeldPlacementTypeEnum Placement { get; set; }
        public WeldPreparationTypeEnum Preparation { get; set; }
        public IArrayList GetWeldGeometries()
        {
            throw new System.NotImplementedException();
        }

        public ISolid GetSolid()
        {
            throw new System.NotImplementedException();
        }

        public WeldPositionEnum Position { get; set; }
        public IVector Direction { get; set; }
        public bool GetLogicalWeld(ref ILogicalWeld LogicalWeld)
        {
            throw new System.NotImplementedException();
        }
    }
}