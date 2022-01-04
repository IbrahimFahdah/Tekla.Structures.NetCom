using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IWeld : IBaseWeld
    {
        WeldPositionEnum Position { get; set; }

        IVector Direction { get; set; }


        bool GetLogicalWeld(ref ILogicalWeld LogicalWeld);
    }
}