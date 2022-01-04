namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRadialGrid : IGridBase
    {
        string RadialCoordinates { get; set; }

        string AngularCoordinates { get; set; }

        string CoordinateZ { get; set; }

        string RadialLabels { get; set; }

        string AngularLabels { get; set; }

        string LabelZ { get; set; }

        double ArcStartExtension { get; set; }

        double AngularLinesStartExtension { get; set; }

        double ExtensionBelowZ { get; set; }

        double ArcEndExtension { get; set; }

        double AngularLinesEndExtension { get; set; }

        double ExtensionAboveZ { get; set; }
    }
}