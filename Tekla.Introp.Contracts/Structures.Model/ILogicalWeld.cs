namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILogicalWeld : IBaseWeld
    {
        bool AddWeld(IBaseWeld Weld);

        IBaseWeld GetMainWeld();

        bool SetMainWeld(IBaseWeld Weld);

        bool RemoveWeld(IBaseWeld Weld);

        bool Explode();

        bool Select(IBaseWeld ChildWeld);
    }
}