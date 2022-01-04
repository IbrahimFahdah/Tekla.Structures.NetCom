namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IReferenceModelObject : IModelObject
    {
        IReferenceModel GetReferenceModel();

        IReferenceModelObject GetFather();
    }
}