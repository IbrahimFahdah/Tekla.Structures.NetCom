using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILoadArea : ILoad
    {
        IPoint Position1 { get; set; }

        IPoint Position2 { get; set; }

        IPoint Position3 { get; set; }

        IVector P1 { get; set; }

        IVector P2 { get; set; }

        IVector P3 { get; set; }

        IVector P4 { get; set; }

        AreaLoadFormEnum LoadForm { get; set; }

        double DistanceA { get; set; }
    }
}