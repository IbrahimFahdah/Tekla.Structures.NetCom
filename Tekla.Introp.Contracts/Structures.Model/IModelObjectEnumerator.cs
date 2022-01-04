using System.Collections;
using System.Runtime.InteropServices;

namespace Tekla.Introp.Contracts.Structures.Model
{
    [Guid("72A3F839-E196-4501-9AAB-3A3767C20A6C")]
    public interface IModelObjectEnumerator : IEnumerator
    {
        new bool MoveNext();

        new object Current { get; }

        new void Reset();
    }
}