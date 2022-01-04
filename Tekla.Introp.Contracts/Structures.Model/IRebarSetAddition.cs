using System.Collections.Generic;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarSetAddition : IModelObject
    {
        List<IRebarLegFace> LegFaces { get; set; }

        IRebarSet Father { get; set; }
    }
}