using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IInputItem
    {
        InputTypeEnum GetInputType();

        object GetData();
    }
}