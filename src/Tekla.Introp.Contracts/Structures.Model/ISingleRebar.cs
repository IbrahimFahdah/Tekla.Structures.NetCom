namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ISingleRebar : IReinforcement
    {
        string Size { get; set; }

        IRebarHookData StartHook { get; set; }

        IRebarHookData EndHook { get; set; }

        IPolygon Polygon { get; set; }


        IRebarSet GetRebarSet();
    }
}