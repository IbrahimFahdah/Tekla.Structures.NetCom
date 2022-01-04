namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IGridSurface : IModelObject
    {
        IGridBase Parent { get; set; }

        string Label { get; set; }

        bool IsMagnetic { get; set; }

        double ExtensionLeft { get; set; }

        double ExtensionRight { get; set; }

        double ExtensionBelow { get; set; }

        double ExtensionAbove { get; set; }

        bool DrawingVisibility { get; set; }

        bool IsManual { get; }
    }
}