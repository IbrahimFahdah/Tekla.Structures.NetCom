using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarStrand : IReinforcement
    {
        string Size { get; set; }

        double PullPerStrand { get; set; }

        IArrayList Patterns { get; set; }

        IArrayList Unbondings { get; set; }

        IPoint StartPoint { get; set; }

        IPoint EndPoint { get; set; }
    }
}