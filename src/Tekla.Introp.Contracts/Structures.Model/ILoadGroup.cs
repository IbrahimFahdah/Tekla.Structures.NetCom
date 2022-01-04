using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILoadGroup : IModelObject
    {
        string GroupName { get; set; }

        LoadGroupType GroupType { get; set; }

        LoadGroupDirection Direction { get; set; }

        int Compatible { get; set; }

        int Incompatible { get; set; }
    }
}