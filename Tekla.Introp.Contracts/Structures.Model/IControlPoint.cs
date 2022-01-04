using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IControlPoint : IModelObject
    {
        IPoint Point { get; set; }
    }
}