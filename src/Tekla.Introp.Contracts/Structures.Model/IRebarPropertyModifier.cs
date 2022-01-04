using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarPropertyModifier : IBaseRebarModifier
    {
        IRebarPropertiesNullable RebarProperties { get; set; }

        GroupingTypeEnum? GroupingType { get; set; }


        IModelObjectEnumerator GetAffectedBars();
    }
}