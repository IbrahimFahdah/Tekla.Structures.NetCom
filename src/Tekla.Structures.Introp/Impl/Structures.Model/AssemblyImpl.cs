using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class AssemblyImpl : ModelObjectImpl, IAssembly
    {
        private Tekla.Structures.Model.Assembly TkAssembly => (Tekla.Structures.Model.Assembly)TklModelObject;

        public AssemblyImpl(Tekla.Structures.Model.Assembly obj) : base(obj)
        {
        }

        public string Name { get; set; }
        public INumberingSeries AssemblyNumber { get; set; }
        public IModelObject GetMainPart()
        {
            throw new System.NotImplementedException();
        }

        public bool SetMainPart(IPart Part)
        {
            throw new System.NotImplementedException();
        }

        public IArrayList GetSecondaries()
        {
            throw new System.NotImplementedException();
        }

        public bool Add(IAssemblable Object)
        {
            throw new System.NotImplementedException();
        }

        public bool Add(IArrayList Assemblables)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(IModelObject Object)
        {
            throw new System.NotImplementedException();
        }

        public bool Add(IAssembly Assembly)
        {
            throw new System.NotImplementedException();
        }

        public IAssembly GetAssembly()
        {
            throw new System.NotImplementedException();
        }

        public IArrayList GetSubAssemblies()
        {
            throw new System.NotImplementedException();
        }

        public AssemblyTypeEnum GetAssemblyType()
        {
            throw new System.NotImplementedException();
        }

        public IPourObject GetFatherPour()
        {
            throw new System.NotImplementedException();
        }

        public IPourUnit GetFatherPourUnit()
        {
            throw new System.NotImplementedException();
        }
    }
}