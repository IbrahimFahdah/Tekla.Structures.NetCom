using Tekla.Introp.Contracts.Structures.Enums;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IDetail : IBaseComponent
    {
        int Class { get; set; }

        IVector UpVector { get; set; }

        AutoDirectionTypeEnum AutoDirectionType { get; set; }

        PositionTypeEnum PositionType { get; set; }

        DetailTypeEnum DetailType { get; set; }

        string Code { get; set; }

        ConnectionStatusEnum Status { get; }

        bool SetPrimaryObject(IModelObject M);

        IModelObject GetPrimaryObject();

        bool SetReferencePoint(IPoint ReferencePoint);

        IPoint GetReferencePoint();
    }
}