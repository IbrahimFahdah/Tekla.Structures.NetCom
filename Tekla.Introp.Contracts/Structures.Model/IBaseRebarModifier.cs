using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBaseRebarModifier : IModelObject
    {
        IRebarSet Father { get; set; }

        IContour Curve { get; set; }

        BarsAffectedEnum BarsAffected { get; set; }

        int FirstAffectedBar { get; set; }
    }
}