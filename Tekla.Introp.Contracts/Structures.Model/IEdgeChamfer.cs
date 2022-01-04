using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IEdgeChamfer : IBoolean
    {
        IChamfer Chamfer { get; set; }
        IPoint FirstEnd { get; set; }

        IPoint SecondEnd { get; set; }

        ChamferEndTypeEnum FirstChamferEndType { get; set; }

        ChamferEndTypeEnum SecondChamferEndType { get; set; }

        double SecondBevelDimension { get; set; }

        double FirstBevelDimension { get; set; }

        string Name { get; set; }


        //todod EdgeChamfer(IPoint FirstEnd, IPoint SecondEnd);
    }
}