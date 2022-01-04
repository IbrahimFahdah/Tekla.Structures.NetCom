using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IGridBase : IModelObject
    {
        bool IsMagnetic { get; set; }

        string Name { get; set; }

        int FontSize { get; set; }

        IPoint Origin { get; set; }
    }
}