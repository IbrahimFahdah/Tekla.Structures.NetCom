using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IControlCircle : IModelObject
    {
        double Extension { get; set; }

        ControlCircleColorEnum Color { get; set; }

        ControlObjectLineType LineType { get; set; }

        IPoint Point1 { get; set; }

        IPoint Point2 { get; set; }

        IPoint Point3 { get; set; }
    }
}