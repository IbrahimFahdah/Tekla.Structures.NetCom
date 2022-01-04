using System;
using System.Collections.Generic;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IReferenceModel : IModelObject
    {
        string Filename { get; set; }

        string ActiveFilePath { get; }

        IPoint Position { get; set; }

        double Scale { get; set; }

        VisibilityEnum Visibility { get; set; }

        Guid BasePointGuid { get; set; }

        double Rotation { get; set; }

        IModelObjectEnumerator GetConvertedObjects();

        bool RefreshFile();

        List<IRevision> GetRevisions();

        IReferenceModelObject GetReferenceModelObjectByExternalGuid(string externalGuid);

        bool SetAsCurrentRevision(IRevision revision);

        bool SetAsCurrentRevision(int modelId, int revisionId);

        IRevision GetCurrentRevision();
    }
}