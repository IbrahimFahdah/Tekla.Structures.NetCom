namespace Tekla.Introp.Contracts.Structures.Model.Enums
{
    public enum PolymeshHealthCheckEnum
    {
        PolymeshLevelError = -2,
        PolymeshUndefined = -1,
        PolymeshOk = 0,
        NumOfVerticesOuterloop = 1,
        NumOfVerticesInnerloop = 2,
        VertexArrayOuterloop = 3,
        VertexArrayInnerloop = 4,
        InnerloopNotInsideOuterloop = 5,
        VertexArrayForListOfEdges = 6,
        NonPlanarOuterloop = 7,
        NonPlanarInnerloop = 8,
        SelfIntersectingOuterloop = 9,
        SelfIntersectingInnerloop = 10,
        LoopNormalsInvalid = 11,
        FaceEdgesInvalidOrientation = 12,
        FaceEdgesPartlyInvalidOrientation = 13,
        MultishellPolymesh = 14,
        MultishellPolymeshByGeometry = 21,
        NumberOfFaces = 0xF,
        VertexArrayUniqueness = 0x10,
        VertexDuplicatesOnPolygon = 17,
        VertexCollinearOnPolygon = 18,
        NonManifoldEdges = 19,
        UnusedVertices = 20
    }
}