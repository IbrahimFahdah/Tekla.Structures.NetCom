using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class RebarHookDataImpl : IRebarHookData
    {
        private Tekla.Structures.Model.RebarHookData _rebarHookData;

        public RebarHookDataImpl(Tekla.Structures.Model.RebarHookData rebarHookData)
        {
            _rebarHookData = rebarHookData;
        }


        public RebarHookShapeEnum Shape
        {
            get => (RebarHookShapeEnum)_rebarHookData.Shape;
            set => _rebarHookData.Shape = (Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum)value;
        }

        public double Angle
        {
            get => _rebarHookData.Angle;
            set => _rebarHookData.Angle = value;
        }
        public double Radius
        {
            get => _rebarHookData.Radius;
            set => _rebarHookData.Radius = value;
        }
        public double Length
        {
            get => _rebarHookData.Length;
            set => _rebarHookData.Length = value;
        }
    }
}