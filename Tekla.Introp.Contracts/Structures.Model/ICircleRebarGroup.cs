using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ICircleRebarGroup : IBaseRebarGroup
    {
        IPolygon Polygon { get; set; }

        CircleRebarGroupStirrupTypeEnum StirrupType { get; set; }
    }
}