using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;

namespace Tekla.Structures.Introp.Helpers
{
    [ComVisible(true)]
    public class COMDictionary : ICOMDictionary
    {
        private Dictionary<object, object> _dict = new Dictionary<object, object>();

        [return: MarshalAs(UnmanagedType.SafeArray)]
        public object[] Keys()
        {
            return _dict.Keys.ToArray();
        }

        [return: MarshalAs(UnmanagedType.SafeArray)]
        public object[] Values()
        {
            return _dict.Values.ToArray();
        }

        public object Get(string key)
        {
            return _dict[key];
        }

        public void Set(object key, object value)
        {
            if (!_dict.ContainsKey(key))
                _dict.Add(key, value);
            else
                _dict[key] = value;
        }
    }
}