using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBentPlateGeometrySolver
    {
        IConnectiveGeometry AddLeg(IConnectiveGeometry geometry, IContour polygon, BendShape bendShape);

        IConnectiveGeometry AddLeg(IConnectiveGeometry geometry, IContour polygon);

        IConnectiveGeometry AddLeg(IConnectiveGeometry geometry, IContour polygon, double radius);

        IConnectiveGeometry AddLeg(IConnectiveGeometry geometry, IContour polygon, double largestRadius,
            double halfAperture);

        IConnectiveGeometry AddLeg(IConnectiveGeometry geometry, ILineSegment segment1, IContour polygon,
            ILineSegment segment2, BendShape bendShape);

        IConnectiveGeometry AddLeg(IConnectiveGeometry geometry, ILineSegment segment1, IContour polygon,
            ILineSegment segment2);

        IConnectiveGeometry AddLeg(IConnectiveGeometry geometry, ILineSegment segment1, IContour polygon,
            ILineSegment segment2, double radius);

        IConnectiveGeometry AddLeg(IConnectiveGeometry geometry, ILineSegment segment1, IContour polygon,
            ILineSegment segment2, double largestRadius, double halfAperture);

        IConnectiveGeometry RemoveLeg(IConnectiveGeometry geometry, IGeometrySection legSection);

        IConnectiveGeometry ModifyBendSurface(IConnectiveGeometry geometry, IGeometrySection bendSection,
            IBendSurface surface);

        IConnectiveGeometry ModifyCylindricalSurface(IConnectiveGeometry geometry, IGeometrySection cylindricalSection,
            ICylindricalSurface surface);

        IConnectiveGeometry ModifyRadius(IConnectiveGeometry geometry, IGeometrySection cylindricalSection,
            double radius);

        IConnectiveGeometry ModifyConicalRadiuses(IConnectiveGeometry geometry, IGeometrySection conicalSection,
            double radius1, double radius2);

        IConnectiveGeometry ScaleConeSection(IConnectiveGeometry geometry, IGeometrySection conicalSection,
            double scale);

        IConnectiveGeometry ModifyPolygon(IConnectiveGeometry geometry, IGeometrySection polygonSection,
            IContour points);

        IConnectiveGeometry SetMainSection(IGeometrySection newMainSection, IConnectiveGeometry geometry);

        IConnectiveGeometry SetBendAngle(double angle, IGeometrySection sectionToSetAngle,
            IGeometrySection sectionToMove, IConnectiveGeometry geometry);
    }
}