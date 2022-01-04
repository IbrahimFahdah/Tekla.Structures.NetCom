using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IAssembly : IModelObject
    {
        string Name { get; set; }

        INumberingSeries AssemblyNumber { get; set; }

        IModelObject GetMainPart();

        bool SetMainPart(IPart Part);

        IArrayList GetSecondaries();

        bool Add(IAssemblable Object);

        bool Add(IArrayList Assemblables);

        bool Remove(IModelObject Object);

        bool Add(IAssembly Assembly);

        IAssembly GetAssembly();

        IArrayList GetSubAssemblies();

        AssemblyTypeEnum GetAssemblyType();

        IPourObject GetFatherPour();

        IPourUnit GetFatherPourUnit();
    }
}