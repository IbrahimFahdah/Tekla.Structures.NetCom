using System.Drawing;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ISurfaceTreatment : IModelObject
    {
        SurfaceTypeEnum Type { get; set; }

        SurfaceColorEnum Color { get; set; }

        IMaterial Material { get; set; }

        IPosition Position { get; set; }

        IContour Polygon { get; set; }

        Point StartPoint { get; set; }

        Point EndPoint { get; set; }

        IPart Father { get; set; }

        double Thickness { get; set; }

        string Name { get; set; }

        string Class { get; set; }

        bool CutByFatherBooleans { get; set; }

        string TypeName { get; set; }
    }
}