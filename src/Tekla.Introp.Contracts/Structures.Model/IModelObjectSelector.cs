using System;
using System.Collections;
using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public partial class Guids
    {
        public const string IModelObjectSelector = "44F35D4D-C38A-4CCC-9946-D181B9BA9EEA";
    }

    [Guid(Guids.IModelObjectSelector)]
    public interface IModelObjectSelector
    {
        IModelObjectEnumerator GetAllObjects();

        IEnumerator GetEnumerator();

        IModelObjectEnumerator GetAllObjectsWithType(ModelObjectEnum Enum);

        IModelObjectEnumerator GetAllObjectsWithType(Type[] TypeFilter);

        IModelObjectEnumerator GetObjectsByBoundingBox(IPoint MinPoint, IPoint MaxPoint);

        IModelObjectEnumerator GetObjectsByFilterName(string FilterName);

        IModelObjectEnumerator GetFilteredObjectsWithType(ModelObjectEnum Enum, string FilterName);

        //todo IModelObjectEnumerator GetObjectsByFilter(FilterExpression FilterExpression);
    }
}