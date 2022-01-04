namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IClashCheckHandler
    {
        bool RunClashCheck();

        bool StopClashCheck();

        IArrayList GetIntersectionBoundingBoxes(IIdentifier ID1, IIdentifier ID2);
    }
}