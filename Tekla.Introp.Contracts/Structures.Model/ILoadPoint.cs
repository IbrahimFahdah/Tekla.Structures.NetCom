using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILoadPoint : ILoad
    {
        IPoint Position { get; set; }

        IVector P { get; set; }

        IVector Moment { get; set; }
    }
}