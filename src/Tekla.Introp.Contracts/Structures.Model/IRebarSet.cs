using System.Collections.Generic;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarSet : IModelObject
    {
        IRebarProperties RebarProperties { get; set; }

        List<IRebarLegFace> LegFaces { get; set; }

        List<IRebarGuideline> Guidelines { get; set; }

        int LayerOrderNumber { get; set; }


        IModelObjectEnumerator GetRebarSetAdditions();

        IModelObjectEnumerator GetRebarModifiers();

        IModelObjectEnumerator GetReinforcements();
    }
}