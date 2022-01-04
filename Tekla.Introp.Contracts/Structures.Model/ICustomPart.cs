using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ICustomPart : IBaseComponent, IAssemblable
    {
        IPosition Position { get; set; }

        bool SetInputPositions(IPoint StartPoint, IPoint EndPoint);

        bool GetStartAndEndPositions(ref IPoint StartPoint, ref IPoint EndPoint);

        IModelObjectEnumerator GetComponents();
    }
}