using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IControlLine : IModelObject
    {
        ILineSegment Line { get; set; }

        bool IsMagnetic { get; set; }

        double Extension { get; set; }

        ControlLineColorEnum Color { get; set; }

        ControlObjectLineType LineType { get; set; }
    }
}