using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Model;
using Beam = Tekla.Structures.Model.Beam;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class ModelObjectEnumeratorImpl : IModelObjectEnumerator
    {
        ModelObjectEnumerator _tkl;
        private ConcurrentDictionary<ModelObject, IModelObject> _modelObjects = new ConcurrentDictionary<ModelObject, IModelObject>();

        public ModelObjectEnumeratorImpl(ModelObjectEnumerator obj)
        {
            _tkl = obj;
        }

        public bool MoveNext()
        {
            return _tkl.MoveNext();
        }

        public void Reset()
        {
            _tkl.Reset();
        }

        public IModelObject Current
        {
            get
            {
                if (!_modelObjects.ContainsKey(_tkl.Current))
                    _modelObjects[_tkl.Current] = GetModelObjectImpl(_tkl.Current);

                return _modelObjects[_tkl.Current];
            }
        }

        object IModelObjectEnumerator.Current => Current;

        object IEnumerator.Current => Current;

        private ModelObjectImpl GetModelObjectImpl(ModelObject modelObject)
        {
            switch (modelObject)
            {
                case Beam beam:
                    return new BeamImpl(beam);
                case Assembly assembly:
                    return new AssemblyImpl(assembly);
                case ControlPoint controlPoint:
                    return new ControlPointImpl(controlPoint);
                case RebarGroup rebarGroup:
                    return new RebarGroupImpl(rebarGroup);
                case BoltArray boltArray:
                    return new BoltArrayImpl(boltArray);
                case Weld weld:
                    return new WeldImpl(weld);
                case ContourPlate contourPlate:
                    return new ContourPlateImpl(contourPlate);
                case Fitting fitting:
                    return new FittingImpl(fitting);
                case Connection connection:
                    return new ConnectionImpl(connection);
                case BooleanPart booleanPart:
                    return new BooleanPartImpl(booleanPart);
                case HierarchicObject hierarchicObject:
                    return new HierarchicObjectImpl(hierarchicObject);
                case HierarchicDefinition hierarchicDefinition:
                    return new HierarchicDefinitionImpl(hierarchicDefinition);
                case LoadGroup loadGroup:
                    return new LoadGroupImpl(loadGroup);
                default:
                    throw new NotImplementedException($"Could not found wrapper for type {_tkl.Current.GetType()}");
            }
        }
    }
}