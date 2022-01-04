using System;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ITask : IModelObject
    {
        string Name { get; set; }

        int Completeness { get; set; }

        bool Critical { get; set; }

        bool Local { get; set; }

        IHierarchicObject Scenario { get; set; }

        string Description { get; set; }

        string Url { get; set; }

        DateTime PlannedStartDate { get; set; }

        DateTime PlannedEndDate { get; set; }

        double PlannedWorkAmount { get; set; }

        DateTime ActualStartDate { get; set; }

        DateTime ActualEndDate { get; set; }

        double ActualWorkAmount { get; set; }

        bool AddObjectsToTask(IArrayList ModelObjects);

        bool RemoveObjectsFromTask(IArrayList ModelObjects);

        IModelObjectEnumerator GetFathers();

        IModelObjectEnumerator GetDependencies();
    }
}