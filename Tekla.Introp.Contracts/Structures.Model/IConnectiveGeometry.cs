using System.Collections.Generic;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IConnectiveGeometry
    {
        bool IsEmpty();

        IGeometrySectionEnumerator GetGeometryEnumerator();

        IList<IGeometrySection> GetNeighborSections(IGeometrySection geometrySection);

        IList<IGeometrySection> GetGeometryLegSections();

        IList<ILineSegment> GetConnection(IGeometrySection geometrySection1, IGeometrySection geometrySection2);
    }
}