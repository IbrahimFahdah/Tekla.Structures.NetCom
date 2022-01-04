using System.Collections;
using System.Linq;

namespace Tekla.Structures.Introp.Helpers
{
    internal class Helper
    {
        public static COMDictionary AsComDictionary(Hashtable hashtable)
        {
            var ret = new COMDictionary();

            var dic = hashtable
                .Cast<DictionaryEntry>()
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var item in dic)
            {
                ret.Set(item.Key, item.Value);
            }

            return ret;
        }
    }
}
