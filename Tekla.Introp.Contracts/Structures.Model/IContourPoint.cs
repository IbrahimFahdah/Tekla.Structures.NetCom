using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IContourPoint : IPoint
    {
        IChamfer Chamfer { get; set; }

        void SetPoint(IPoint P);
    }
}