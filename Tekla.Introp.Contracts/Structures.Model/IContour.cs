namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IContour
    {
        IArrayList ContourPoints { get; set; }

        void AddContourPoint(IContourPoint Point);

        bool CalculatePolygon(out Geometry3d.IPolygon polygon);
    }
}