using System;
using System.Collections;
using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;

namespace Tekla.Structures.Introp.Helpers
{
    [ComVisible(true)]
    public class COMArrayList : IArrayList
    {
        private ArrayList _arrayList = new ArrayList();
        internal ArrayList TkArrayList = new ArrayList();

        public COMArrayList()
        {
        }


        public COMArrayList(ArrayList tkArrayList)
        {
            TkArrayList = tkArrayList;
        }

        public IEnumerator GetEnumerator()
        {
            return _arrayList.GetEnumerator();
        }

        public int Count => _arrayList.Count;

        public object SyncRoot => _arrayList.SyncRoot;

        public bool IsSynchronized => _arrayList.IsSynchronized;

        public int Add(object value)
        {
            TkArrayList.Add(value is ITkObjWrapper tkObjWrapper ? tkObjWrapper.TKObj : value);
            return _arrayList.Add(value);
        }

        public bool Contains(object value)
        {
            return _arrayList.Contains(value);
        }

        public void Clear()
        {
            TkArrayList.Clear();
            _arrayList.Clear();
        }

        public int IndexOf(object value)
        {
            return _arrayList.IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            TkArrayList.Insert(index, value is ITkObjWrapper tkObjWrapper ? tkObjWrapper.TKObj : value);
            _arrayList.Insert(index, value);
        }

        public void Remove(object value)
        {
            TkArrayList.Remove(value is ITkObjWrapper tkObjWrapper ? tkObjWrapper.TKObj : value);
            _arrayList.Remove(value);
        }

        public void RemoveAt(int index)
        {
            TkArrayList.RemoveAt(index);
            _arrayList.RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get => _arrayList[index];
            set => _arrayList[index] = value;
        }

        public bool IsReadOnly => _arrayList.IsReadOnly;

        public bool IsFixedSize => _arrayList.IsFixedSize;

    }
}