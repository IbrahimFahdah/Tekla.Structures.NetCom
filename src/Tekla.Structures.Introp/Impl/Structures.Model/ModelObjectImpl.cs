using System;
using System.Collections;
using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Helpers;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public abstract class ModelObjectImpl : TkObjWrapper, IModelObject
    {
        internal Tekla.Structures.Model.ModelObject TklModelObject => (Tekla.Structures.Model.ModelObject)TKObj;

        protected ModelObjectImpl() : base(null)
        {
        }

        protected ModelObjectImpl(Tekla.Structures.Model.ModelObject obj) : base(obj)
        {
            TKObj = obj;
        }


        public DateTime ModificationTime => TklModelObject.ModificationTime ?? default;

        public bool IsUpToDate { get; }

        public virtual bool Insert()
        {
            return TklModelObject.Insert();
        }

        public virtual bool Select()
        {
            return TklModelObject.Select();
        }

        public virtual bool Modify()
        {
            return TklModelObject.Modify();
        }

        public virtual bool Delete()
        {
            return TklModelObject.Delete();
        }

        public IModelObjectEnumerator GetChildren()
        {
            return new ModelObjectEnumeratorImpl(TklModelObject.GetChildren());
        }

        public IModelObjectEnumerator GetHierarchicObjects()
        {
            return new ModelObjectEnumeratorImpl(TklModelObject.GetHierarchicObjects());
        }

        public bool GetAllUserProperties(out ICOMDictionary values)
        {
            var table = new Hashtable();
            var ret = TklModelObject.GetAllUserProperties(ref table);
            values = Helper.AsComDictionary(table);
            return ret;
        }

        public bool GetIntegerUserProperties(out ICOMDictionary values)
        {
            var table = new Hashtable();
            var ret = TklModelObject.GetIntegerUserProperties(ref table);
            values = Helper.AsComDictionary(table);
            return ret;
        }

        public bool GetDoubleUserProperties(out ICOMDictionary values)
        {
            var table = new Hashtable();
            var ret = TklModelObject.GetDoubleUserProperties(ref table);
            values = Helper.AsComDictionary(table);
            return ret;
        }

        public bool GetStringUserProperties(out ICOMDictionary values)
        {
            var table = new Hashtable();
            var ret = TklModelObject.GetStringUserProperties(ref table);
            values = Helper.AsComDictionary(table);
            return ret;
        }

        public bool GetAllReportProperties(IArrayList stringNames, IArrayList doubleNames, IArrayList integerNames, out ICOMDictionary values)
        {
            var table = new Hashtable();
            var ret = TklModelObject.GetAllReportProperties(stringNames.GetTkArrayList(), doubleNames.GetTkArrayList(), integerNames.GetTkArrayList(), ref table);
            values = Helper.AsComDictionary(table);
            return ret;
        }

        public bool GetIntegerReportProperties(IArrayList names, out ICOMDictionary values)
        {
            var table = new Hashtable();
            var ret = TklModelObject.GetIntegerReportProperties(names.GetTkArrayList(), ref table);
            values = Helper.AsComDictionary(table);
            return ret;
        }

        public bool GetDoubleReportProperties(IArrayList names, out ICOMDictionary values)
        {
            var table = new Hashtable();
            var ret = TklModelObject.GetDoubleReportProperties(names.GetTkArrayList(), ref table);
            values = Helper.AsComDictionary(table);
            return ret;
        }

        public bool GetStringReportProperties(IArrayList names, out ICOMDictionary values)
        {
            var table = new Hashtable();
            var ret = TklModelObject.GetStringReportProperties(names.GetTkArrayList(), ref table);
            values = Helper.AsComDictionary(table);
            return ret;
        }

        public bool GetUserProperty(string name, ref string value)
        {
            return TklModelObject.GetUserProperty(name, ref value);
        }

        public bool GetReportProperty(string name, ref string value)
        {
            return TklModelObject.GetReportProperty(name, ref value);
        }

        public bool GetUserProperty(string name, ref double value)
        {
            return TklModelObject.GetUserProperty(name, ref value);
        }

        public bool GetReportProperty(string name, ref double value)
        {
            return TklModelObject.GetReportProperty(name, ref value);
        }

        public bool GetUserProperty(string name, ref int value)
        {
            return TklModelObject.GetUserProperty(name, ref value);
        }

        public bool GetReportProperty(string name, ref int value)
        {
            return TklModelObject.GetReportProperty(name, ref value);
        }

        public bool GetDynamicStringProperty(string name, ref string value)
        {
            return TklModelObject.GetDynamicStringProperty(name, ref value);
        }

        public bool SetDynamicStringProperty(string name, string value)
        {
            return TklModelObject.SetDynamicStringProperty(name, value);
        }

        public bool SetUserProperty(string name, string value)
        {
            return TklModelObject.SetUserProperty(name, value);
        }

        public bool SetUserProperty(string name, double value)
        {
            return TklModelObject.SetUserProperty(name, value);
        }

        public bool SetUserProperty(string name, int value)
        {
            return TklModelObject.SetUserProperty(name, value);
        }

        public bool SetLabel(string label)
        {
            return TklModelObject.SetLabel(label);
        }
    }
}