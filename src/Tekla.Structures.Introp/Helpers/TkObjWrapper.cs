using Tekla.Introp.Contracts;

namespace Tekla.Structures.Introp.Helpers
{
    public class TkObjWrapper : ITkObjWrapper
    {
        public TkObjWrapper(object obj)
        {
            TKObj = obj;
        }

        public object TKObj { get; set; }

        public string TKObjType => TKObj.GetType().ToString();
    }
}