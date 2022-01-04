using System.Collections;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IComponentInput : ICollection, IEnumerable
    {
        bool AddOneInputPosition(IPoint P);

        bool AddTwoInputPositions(IPoint Position1, IPoint Position2);

        bool AddInputPolygon(IPolygon P);

        bool AddInputObject(IModelObject M);

        bool AddInputObjects(IArrayList Objects);
    }
}