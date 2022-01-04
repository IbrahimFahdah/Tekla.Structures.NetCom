namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IWorkPlaneHandler
    {
        ITransformationPlane GetCurrentTransformationPlane();

        bool SetCurrentTransformationPlane(ITransformationPlane TransformationPlane);
    }
}