using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILoad : IModelObject
    {
        IIdentifier FatherId { get; set; }

        LoadSpanningEnum Spanning { get; set; }

        IVector PrimaryAxisDirection { get; set; }

        bool AutomaticPrimaryAxisWeight { get; set; }

        double Weight { get; set; }

        double LoadDispersionAngle { get; set; }

        bool CreateFixedSupportConditionsAutomatically { get; set; }

        LoadAttachmentEnum LoadAttachment { get; set; }

        LoadPartNamesEnum PartNames { get; set; }

        string PartFilter { get; set; }

        double BoundingBoxDx { get; set; }

        double BoundingBoxDy { get; set; }

        double BoundingBoxDz { get; set; }

        ILoadGroup Group { get; set; }
    }
}