using System;

namespace Tekla.Introp.Contracts.Structures.Model.Enums
{
    [Flags]
    public enum RebarGeometryOptionEnum
    {
        NONE = 0x0,
        HOOKS = 0x1,
        AVOID_CLASH = 0x2,
        LENGTH_ADJUSTMENTS = 0x4
    }
}