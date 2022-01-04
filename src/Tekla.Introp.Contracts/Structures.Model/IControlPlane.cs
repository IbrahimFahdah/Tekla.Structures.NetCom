namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IControlPlane : IModelObject
    {
        IPlane Plane { get; set; }

        bool IsMagnetic { get; set; }

        string Name { get; set; }
    }
}