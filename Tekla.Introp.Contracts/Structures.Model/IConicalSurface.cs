using System;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IConicalSurface : IBendSurface
    {
        Tuple<double, double> Radiuses { get; }

        IPoint Apex { get; }
    }
}