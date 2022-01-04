namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IGridPlane : IGridSurface
    {
        IPlane Plane { get; set; }
    }
}