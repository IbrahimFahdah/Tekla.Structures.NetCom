using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IChangeData
    {
        IModelObject Object { get; }

        ChangeTypeEnum Type { get; }
    }
}