using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IClashCheckData
    {
        IModelObject Object1 { get; }

        IModelObject Object2 { get; }

        ClashTypeEnum Type { get; }

        double Overlap { get; }
    }
}