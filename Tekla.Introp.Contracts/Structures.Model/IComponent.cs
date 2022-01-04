namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IComponent : IBaseComponent, IAssemblable
    {
        bool SetComponentInput(IComponentInput I);

        IComponentInput GetComponentInput();

        IModelObjectEnumerator GetComponents();
    }
}