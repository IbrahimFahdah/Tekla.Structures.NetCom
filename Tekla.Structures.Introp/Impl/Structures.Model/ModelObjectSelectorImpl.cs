using System;
using System.Collections;
using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class ModelObjectSelectorImpl : IModelObjectSelector
    {
        Tekla.Structures.Model.ModelObjectSelector _tkl;

        public ModelObjectSelectorImpl(Tekla.Structures.Model.ModelObjectSelector obj)
        {
            _tkl = obj;
        }

        public IModelObjectEnumerator GetAllObjects()
        {
            return new ModelObjectEnumeratorImpl(_tkl.GetAllObjects());
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllObjects();
        }

        public IModelObjectEnumerator GetAllObjectsWithType(ModelObjectEnum Enum)
        {
            return new ModelObjectEnumeratorImpl(_tkl.GetAllObjectsWithType((Tekla.Structures.Model.ModelObject.ModelObjectEnum)Enum));
        }

        public IModelObjectEnumerator GetAllObjectsWithType(Type[] TypeFilter)
        {
            return new ModelObjectEnumeratorImpl(_tkl.GetAllObjectsWithType(TypeFilter));
        }

        public IModelObjectEnumerator GetObjectsByBoundingBox(IPoint MinPoint, IPoint MaxPoint)
        {
            return new ModelObjectEnumeratorImpl(_tkl.GetObjectsByBoundingBox((Tekla.Structures.Geometry3d.Point)MinPoint.TKObj, (Tekla.Structures.Geometry3d.Point)MaxPoint.TKObj));
        }

        public IModelObjectEnumerator GetObjectsByFilterName(string FilterName)
        {
            return new ModelObjectEnumeratorImpl(_tkl.GetObjectsByFilterName(FilterName));
        }

        public IModelObjectEnumerator GetFilteredObjectsWithType(ModelObjectEnum Enum, string FilterName)
        {
            return new ModelObjectEnumeratorImpl(_tkl.GetFilteredObjectsWithType((Tekla.Structures.Model.ModelObject.ModelObjectEnum)Enum, FilterName));
        }
    }
}