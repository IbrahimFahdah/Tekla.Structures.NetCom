namespace Tekla.Introp.Contracts.Structures.Model.Enums
{
    public enum OperationStatus
    {
        Success,
        Failure,
        FacePerpendicularToIntersectionLine,
        PlateIntersectsWithIntersectionLine,
        ExtensionIntersectsWithPlate,
        FacesTooNearEachOther,
        FacesAtAnObtuseAngle,
        UndefinedCurveDirection,
        UnsupportedChamfer,
        InvalidRadius,
        InvalidFacePoints
    }
}