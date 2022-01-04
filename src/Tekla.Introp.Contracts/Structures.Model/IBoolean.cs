using System.Runtime.InteropServices;

namespace Tekla.Introp.Contracts.Structures.Model
{
    [Guid("1B66A905-9650-4F3C-9361-1BDB12F9712C")]
    public interface IBoolean : IModelObject
    {
        IModelObject Father { get; set; }
    }
}