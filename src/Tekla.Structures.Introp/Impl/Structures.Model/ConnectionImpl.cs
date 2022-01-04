using System.Collections;
using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Introp.Impl.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class ConnectionImpl : BaseComponentImpl, Tekla.Introp.Contracts.Structures.Model.IConnection
    {
        private Connection TkConnection => (Connection)TklModelObject;

        private IVector _upVector;

        public ConnectionImpl() : base(new Connection())
        {
        }

        public ConnectionImpl(Connection obj) : base(obj)
        {
        }


        public int Class
        {
            get => TkConnection.Class;
            set => TkConnection.Class = value;
        }

        public IVector UpVector
        {
            get => _upVector ?? (_upVector = new VectorImpl(TkConnection.UpVector));
            set => _upVector = value;
        }

        public Tekla.Introp.Contracts.Structures.Enums.AutoDirectionTypeEnum AutoDirectionType
        {
            get => (Tekla.Introp.Contracts.Structures.Enums.AutoDirectionTypeEnum)TkConnection.AutoDirectionType;
            set => TkConnection.AutoDirectionType = (AutoDirectionTypeEnum)value;
        }

        public Tekla.Introp.Contracts.Structures.Enums.PositionTypeEnum PositionType
        {
            get => (Tekla.Introp.Contracts.Structures.Enums.PositionTypeEnum)TkConnection.PositionType;
            set => TkConnection.PositionType = (PositionTypeEnum)value;
        }

        public string Code
        {
            get => TkConnection.Code;
            set => TkConnection.Code = value;
        }

        public Tekla.Introp.Contracts.Structures.Enums.ConnectionStatusEnum Status { get; }

        public bool SetPrimaryObject(IModelObject obj)
        {
            PrimaryObject = obj;
            return TkConnection.SetPrimaryObject(obj.GetTklModelObject());
        }

        public IModelObject GetPrimaryObject()
        {
            return PrimaryObject;
        }

        public bool SetSecondaryObject(IModelObject obj)
        {
            SecondaryObjects.Clear();
            SecondaryObjects.Add(obj);
            return TkConnection.SetSecondaryObject(obj.GetTklModelObject());
        }

        public bool SetSecondaryObjects(IArrayList secondaries)
        {
            var lst = new ArrayList();
            foreach (IModelObject item in secondaries)
            {
                lst.Add(item.GetTklModelObject());
            }

            return TkConnection.SetSecondaryObjects(lst);
        }

        public IArrayList GetSecondaryObjects()
        {
            return SecondaryObjects;
        }
    }
}