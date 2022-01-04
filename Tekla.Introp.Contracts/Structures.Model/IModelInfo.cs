using System.Runtime.InteropServices;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public partial class Guids
    {
        public const string IModelInfo = "C5138F9B-475D-47EC-84AB-0F796D837500";
    }

    [Guid(Guids.IModelInfo)]
    public interface IModelInfo
    {
        string ModelName { get; set; }
        double NorthDirection { get; set; }

        string ModelPath { get; set; }

        int CurrentPhase { get; set; }

        bool SharedModel { get; }

        bool SingleUserModel { get; }
    }
}