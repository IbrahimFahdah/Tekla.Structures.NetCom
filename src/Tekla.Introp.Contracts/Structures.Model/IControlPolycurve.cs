using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IControlPolycurve : IModelObject
    {
        ControlObjectColorEnum Color { get; set; }

        ControlObjectLineType LineType { get; set; }

        IPolycurve Geometry { get; set; }
    }
}