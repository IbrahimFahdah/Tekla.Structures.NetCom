namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IFitting : IBoolean
    {
        IPlane Plane { get; set; }
    }
}