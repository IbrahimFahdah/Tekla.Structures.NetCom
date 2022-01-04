using System;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBasePoint
    {
        int Id { get; set; }

        Guid Guid { get; set; }

        string InitialGuid { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        string CoordinateSystem { get; set; }

        double NorthSouth { get; set; }

        double EastWest { get; set; }

        double Elevation { get; set; }

        double Latitude { get; set; }

        double Longitude { get; set; }

        double LocationInModelX { get; set; }

        double LocationInModelY { get; set; }

        double LocationInModelZ { get; set; }

        double AngleToNorth { get; set; }

        bool IsProjectBasePoint { get; set; }

        bool IsCurrentBasePoint { get; set; }

        bool IsScopedCurrentBasePoint { get; }

        bool Insert();

        bool Modify();

        bool Delete();

        IDisposable SetAsCurrent();

        ICoordinateSystem GetCoordinateSystem(CoordinateSystemType CoordsysType = CoordinateSystemType.GLOBAL);

        Tuple<bool, int, int, int> GetCompoundPlaneAngleLatitude();

        Tuple<bool, int, int, int> GetCompoundPlaneAngleLongitude();

        IPoint ConvertToBasePoint(IPoint point);

        IPoint ConvertFromBasePoint(IPoint point);

        IPoint ConvertToBasePoint(IBasePoint basePoint, IPoint point);

        IPoint ConvertFromBasePoint(IBasePoint basePoint, IPoint point);
    }
}