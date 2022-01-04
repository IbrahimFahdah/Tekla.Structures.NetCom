using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBooleanPart : IBoolean
    {
        BooleanTypeEnum Type { get; set; }

        IPart OperativePart { get; set; }


        bool SetOperativePart(IPart Part);
    }
}