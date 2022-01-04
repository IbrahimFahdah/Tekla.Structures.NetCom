using System;

namespace Tekla.Introp.Contracts.Structures.Model.Enums
{
    [Flags]
    public enum PolymeshCheckerFlags
    {
        None = 0x0,
        LoopVertexUnique = 0x800,
        VerticesOnSameEdge = 0x1,
        OuterloopPlanarity = 0x2,
        OuterloopSelfIntersection = 0x4,
        InnerloopPlanarity = 0x8,
        InnerloopSelfIntersection = 0x10,
        InnerloopInsideOuterloop = 0x100,
        LoopNormalValidity = 0x20,
        FaceEdgeOrientation = 0x40,
        Multishellness = 0x80,
        MultishellnessGeometrical = 0x4000,
        VerticesOnSamePosition = 0x200,
        UnusedVertices = 0x400,
        NonManifoldEdges = 0x1000,
        NullFaces = 0x2000,
        All = 0x1FF
    }
}