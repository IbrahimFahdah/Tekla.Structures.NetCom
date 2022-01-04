using System.Collections.Generic;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ILoftedPlate : IPart
    {
        List<ICurve> BaseCurves { get; set; }

        LoftedPlateFaceTypeEnum FaceType { get; set; }
    }
}