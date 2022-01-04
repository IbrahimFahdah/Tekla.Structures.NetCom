using System;
using System.Collections;
using Tekla.Introp.Contracts;

namespace Tekla.Structures.Introp.Helpers
{
    internal static class IArrayListExt
    {
        public static ArrayList GetTkArrayList(this IArrayList list)
        {
            if (list is COMArrayList comList)
            {
                return comList.TkArrayList;
            }

            throw new NotSupportedException();
        }
    }
}