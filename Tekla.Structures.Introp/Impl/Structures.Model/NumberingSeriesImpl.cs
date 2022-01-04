using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Structures.Introp.Helpers;
using Tekla.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class NumberingSeriesImpl : TkObjWrapper, INumberingSeries
    {
        private NumberingSeries TkNumberingSeries => (NumberingSeries)TKObj;

        public NumberingSeriesImpl() : base(new NumberingSeries())
        {
        }

        public NumberingSeriesImpl(string Prefix, int Number) : this()
        {
            TkNumberingSeries.Prefix = Prefix;
            TkNumberingSeries.StartNumber = Number;
        }

        public NumberingSeriesImpl(NumberingSeries numberingSeries) : base(numberingSeries)
        {
        }

        public string Prefix
        {
            get => TkNumberingSeries.Prefix;
            set => TkNumberingSeries.Prefix = value;
        }

        public int StartNumber
        {
            get => TkNumberingSeries.StartNumber;
            set => TkNumberingSeries.StartNumber = value;
        }
    }
}