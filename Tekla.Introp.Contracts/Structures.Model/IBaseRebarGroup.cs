using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBaseRebarGroup : IReinforcement
    {
        string Size { get; set; }

        IRebarHookData StartHook { get; set; }

        IRebarHookData EndHook { get; set; }

        double StartFromPlaneOffset { get; set; }

        double EndFromPlaneOffset { get; set; }

        ExcludeTypeEnum ExcludeType { get; set; }

        RebarGroupSpacingTypeEnum SpacingType { get; set; }

        IArrayList Spacings { get; set; }

        IPoint StartPoint { get; set; }

        IPoint EndPoint { get; set; }
    }
}