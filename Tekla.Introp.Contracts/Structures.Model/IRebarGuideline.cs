namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarGuideline
    {
        int Id { get; set; }

        IContour Curve { get; set; }

        IRebarSpacing Spacing { get; set; }
    }
}