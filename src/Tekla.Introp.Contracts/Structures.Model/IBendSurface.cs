using System.Collections.Generic;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBendSurface
    {
        bool InwardCurved { get; }

        ILine IntersectionLine { get; }

        IVector EndFaceNormal1 { get; }

        IVector EndFaceNormal2 { get; }

        ILine CenterLine { get; }

        IVector RotationAxis { get; }

        List<IPoint> LateralBoundary1 { get; }

        List<IPoint> LateralBoundary2 { get; }

        ILineSegment SideBoundary1 { get; set; }

        ILineSegment SideBoundary2 { get; set; }
    }
}