using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public partial class Guids
    {
        public const string IBeam = "29BB2048-248D-4152-8DC0-3E72152C9E66";
    }

    [Guid(Guids.IBeam)]
    public interface IBeam : IPart
    {
        BeamTypeEnum Type { get; }

        IPoint StartPoint { get; set; }

        IPoint EndPoint { get; set; }
    }
}