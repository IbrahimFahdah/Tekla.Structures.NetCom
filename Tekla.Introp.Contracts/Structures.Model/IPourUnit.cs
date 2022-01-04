namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPourUnit : IModelObject
    {
        string Name { get; set; }


        IModelObjectEnumerator GetObjects();

        IPourObject GetPourObject();
    }
}