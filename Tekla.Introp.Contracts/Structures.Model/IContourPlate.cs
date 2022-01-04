using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IContourPlate : IPart
    {
        ContourPlateTypeEnum Type { get; }

        IContour Contour { get; set; }


        bool AddContourPoint(IContourPoint contourPoint);
    }
}