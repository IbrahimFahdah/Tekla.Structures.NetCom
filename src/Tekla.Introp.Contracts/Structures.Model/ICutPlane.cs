namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ICutPlane : IBoolean
    {
        IPlane Plane { get; set; }
    }
}