namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IGrid : IGridBase
    {
        string CoordinateX { get; set; }

        string CoordinateY { get; set; }

        string CoordinateZ { get; set; }

        string LabelX { get; set; }

        string LabelY { get; set; }

        string LabelZ { get; set; }

        double ExtensionLeftX { get; set; }

        double ExtensionLeftY { get; set; }

        double ExtensionLeftZ { get; set; }

        double ExtensionRightX { get; set; }

        double ExtensionRightY { get; set; }

        double ExtensionRightZ { get; set; }


        int Color { get; set; }
    }
}