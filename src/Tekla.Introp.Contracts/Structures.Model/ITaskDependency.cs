using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ITaskDependency : IModelObject
    {
        int Lag { get; set; }

        bool Local { get; set; }

        ITask Primary { get; set; }

        ITask Secondary { get; set; }

        DependencyTypeEnum DependencyType { get; set; }
    }
}