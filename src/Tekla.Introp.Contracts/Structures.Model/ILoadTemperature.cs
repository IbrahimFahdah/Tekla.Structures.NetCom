using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILoadTemperature : ILoad
    {
        IPoint Position1 { get; set; }

        IPoint Position2 { get; set; }

        double TemperatureChangeForAxialElongation { get; set; }

        double TemperatureDifferentialTopToBottom { get; set; }

        double TemperatureDifferentialSideToSide { get; set; }

        double InitialAxialElongation { get; set; }
    }
}