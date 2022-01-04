namespace Tekla.Introp.Contracts
{
    public interface ITkObjWrapper
    {
        object TKObj { get; }

        string TKObjType { get; }
    }
}
