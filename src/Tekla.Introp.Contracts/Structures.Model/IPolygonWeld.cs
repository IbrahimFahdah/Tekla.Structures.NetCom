namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPolygonWeld : IBaseWeld
    {
        IPolygon Polygon { get; set; }

        bool GetLogicalWeld(ref ILogicalWeld LogicalWeld);
    }
}