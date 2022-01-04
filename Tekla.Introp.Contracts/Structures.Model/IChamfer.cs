using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IChamfer
    {
        ChamferTypeEnum Type { get; set; }

        double X { get; set; }

        double Y { get; set; }

        double DZ1 { get; set; }

        double DZ2 { get; set; }
    }
}