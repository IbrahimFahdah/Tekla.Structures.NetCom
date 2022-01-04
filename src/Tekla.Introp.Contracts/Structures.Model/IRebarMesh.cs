using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarMesh : IReinforcement
    {
        RebarMeshTypeEnum MeshType { get; set; }

        RebarMeshSpacingMethodEnum LongitudinalSpacingMethod { get; set; }

        IPolygon Polygon { get; set; }

        IArrayList LongitudinalDistances { get; set; }

        IArrayList CrossDistances { get; set; }


        double StartFromPlaneOffset { get; set; }

        double EndFromPlaneOffset { get; set; }

        IPoint StartPoint { get; set; }

        IPoint EndPoint { get; set; }

        double LeftOverhangLongitudinal { get; set; }

        double LeftOverhangCross { get; set; }

        double RightOverhangLongitudinal { get; set; }

        double RightOverhangCross { get; set; }

        string LongitudinalSize { get; set; }

        string CrossSize { get; set; }

        double Width { get; set; }

        double Length { get; set; }

        bool CutByFatherPartCuts { get; set; }

        string CatalogName { get; set; }

        RebarMeshCrossBarLocationEnum CrossBarLocation { get; set; }

        IRebarHookData StartHook { get; set; }

        IRebarHookData EndHook { get; set; }
    }
}