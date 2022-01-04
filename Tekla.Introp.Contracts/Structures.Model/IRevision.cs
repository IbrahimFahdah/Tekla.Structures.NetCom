using System;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRevision
    {
        int ReferenceModelId { get; }

        int Id { get; }

        DateTime Time { get; }

        string Hash { get; }

        string FileName { get; }

        bool IsCurrentRevision { get; }

        //Revision(int referenceModelId, int id, DateTime time, string hash, string fileName, bool isCurrentRevision);
    }
}