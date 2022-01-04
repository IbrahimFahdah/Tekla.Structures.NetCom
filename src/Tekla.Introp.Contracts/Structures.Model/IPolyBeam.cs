using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPolyBeam : IPart
    {
        PolyBeamTypeEnum Type { get; }

        IContour Contour { get; set; }

        bool AddContourPoint(IContourPoint contourPoint);


        IArrayList GetPolybeamCoordinateSystems();
    }
}