using System.Collections;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ISolid : Geometry3d.ISolid
    {
        IPoint MinimumPoint { get; }

        IPoint MaximumPoint { get; }

        IArrayList Intersect(ILineSegment line);

        IArrayList Intersect(IPoint point1, IPoint point2);

        IEnumerator IntersectAllFaces(IPoint point1, IPoint point2, IPoint point3);

        IEnumerator GetAllIntersectionPoints(IPoint point1, IPoint point2, IPoint point3);

        IFaceEnumerator GetFaceEnumerator();

        IEdgeEnumerator GetEdgeEnumerator();

        IShellEnumerator GetCutPart(ISolid CuttingPart);
    }
}