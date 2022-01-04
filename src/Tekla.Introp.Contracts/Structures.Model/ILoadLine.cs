using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILoadLine : ILoad
    {
        IPoint Position1 { get; set; }

        IPoint Position2 { get; set; }

        IVector P1 { get; set; }

        IVector P2 { get; set; }

        double Torsion1 { get; set; }

        double Torsion2 { get; set; }

        LineLoadFormEnum LoadForm { get; set; }

        double DistanceA { get; set; }

        double DistanceB { get; set; }
    }
}