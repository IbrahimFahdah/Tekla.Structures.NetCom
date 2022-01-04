namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ICurvedRebarGroup : IBaseRebarGroup
    {
        IPolygon Polygon { get; set; }
    }
}