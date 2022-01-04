namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarLegFace
    {
        int Id { get; set; }

        double AdditonalOffset { get; set; }

        int LayerOrderNumber { get; set; }

        bool Reversed { get; set; }

        IContour Contour { get; set; }
    }
}