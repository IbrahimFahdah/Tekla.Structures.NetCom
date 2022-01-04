using Tekla.Introp.Contracts.Structures.Enums;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ISeam : IBaseComponent
    {
        IVector UpVector { get; set; }

        AutoDirectionTypeEnum AutoDirectionType { get; set; }

        bool AutoPosition { get; set; }

        string Code { get; set; }

        int Class { get; set; }

        ConnectionStatusEnum Status { get; }


        bool SetPrimaryObject(IModelObject M);

        IModelObject GetPrimaryObject();

        bool SetSecondaryObject(IModelObject M);

        bool SetSecondaryObjects(IArrayList Secondaries);

        IArrayList GetSecondaryObjects();

        bool SetInputPositions(IPoint StartPoint, IPoint EndPoint);

        bool GetStartAndEndPositions(ref IPoint StartPoint, ref IPoint EndPoint);

        bool SetInputPolygon(IPolygon InputPolygon);

        IPolygon GetInputPolygon();
    }
}