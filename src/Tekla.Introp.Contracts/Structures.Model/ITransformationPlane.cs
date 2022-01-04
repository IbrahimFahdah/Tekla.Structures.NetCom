using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ITransformationPlane
    {
        IMatrix TransformationMatrixToGlobal { get; }

        IMatrix TransformationMatrixToLocal { get; }
    }
}