using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Helpers;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public abstract class BaseComponentImpl : ModelObjectImpl, IBaseComponent
    {
        private Tekla.Structures.Model.BaseComponent TkBaseComponent => (Tekla.Structures.Model.BaseComponent)TKObj;

        protected IArrayList SecondaryObjects = new COMArrayList();
        protected IModelObject PrimaryObject;

        protected BaseComponentImpl()
        {
        }

        protected BaseComponentImpl(Tekla.Structures.Model.BaseComponent obj) : base(obj)
        {
        }

        public string Name
        {
            get => TkBaseComponent.Name;
            set => TkBaseComponent.Name = value;
        }

        public int Number
        {
            get => TkBaseComponent.Number;
            set => TkBaseComponent.Number = value;
        }

        public void SetAttribute(string AttrName, string StrValue)
        {
            TkBaseComponent.SetAttribute(AttrName, StrValue);
        }

        public void SetAttribute(string AttrName, int Value)
        {
            TkBaseComponent.SetAttribute(AttrName, Value);
        }

        public void SetAttribute(string AttrName, double DValue)
        {
            TkBaseComponent.SetAttribute(AttrName, DValue);
        }

        public bool GetAttribute(string AttrName, ref string StrValue)
        {
            return TkBaseComponent.GetAttribute(AttrName, ref StrValue);
        }

        public bool GetAttribute(string AttrName, ref int Value)
        {
            return TkBaseComponent.GetAttribute(AttrName, ref Value);
        }

        public bool GetAttribute(string AttrName, ref double DValue)
        {
            return TkBaseComponent.GetAttribute(AttrName, ref DValue);
        }

        public bool LoadAttributesFromFile(string Filename)
        {
            return TkBaseComponent.LoadAttributesFromFile(Filename);
        }
    }
}