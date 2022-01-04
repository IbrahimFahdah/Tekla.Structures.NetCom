using System;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPointCloud
    {
        Guid Guid { get; set; }

        string OriginalPath { get; set; }

        string Url { get; set; }

        string Name { get; set; }

        Guid LocationBy { get; set; }

        bool UseAutoCreatedBasePoint { get; set; }

        IAABB BoundingBox { get; }

        double Scale { get; set; }


        bool Attach();

        bool AttachComplete();

        bool Detach();

        bool Select();
    }
}