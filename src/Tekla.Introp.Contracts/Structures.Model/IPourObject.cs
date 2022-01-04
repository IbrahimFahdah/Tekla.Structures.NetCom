namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPourObject : IModelObject, IAssemblable
    {
        int Class { get; set; }

        string PourNumber { get; set; }

        string PourType { get; set; }

        string ConcreteMixture { get; set; }

        ISolid GetSolid();

        IPolymeshEnumerator GetPourPolymeshes();

        IModelObjectEnumerator GetParts();

        IModelObjectEnumerator GetObjects();

        IPourUnit GetFatherPourUnit();

        IModelObjectEnumerator GetSurfaceObjects();
    }
}