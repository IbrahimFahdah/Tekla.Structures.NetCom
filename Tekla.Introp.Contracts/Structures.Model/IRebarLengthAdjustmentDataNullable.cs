using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarLengthAdjustmentDataNullable
    {
        LengthAdjustmentTypeEnum? AdjustmentType { get; set; }

        double? AdjustmentLength { get; set; }
    }
}