namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPolygon : ITkObjWrapper
    {
        IArrayList Points { get; set; }
    }
}