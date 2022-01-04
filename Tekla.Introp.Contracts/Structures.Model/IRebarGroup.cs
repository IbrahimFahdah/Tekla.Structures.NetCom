using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarGroup : IBaseRebarGroup
    {
        IArrayList Polygons { get; set; }

        RebarGroupStirrupTypeEnum StirrupType { get; set; }
    }
}