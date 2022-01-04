using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBrep : IPart
    {
        IPoint StartPoint { get; set; }

        IPoint EndPoint { get; set; }

        IOffset StartPointOffset { get; set; }

        IOffset EndPointOffset { get; set; }
    }
}