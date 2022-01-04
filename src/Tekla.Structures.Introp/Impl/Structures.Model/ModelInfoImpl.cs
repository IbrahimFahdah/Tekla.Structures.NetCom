using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Model;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class ModelInfoImpl : IModelInfo
    {
        Tekla.Structures.Model.ModelInfo _tkl;

        public ModelInfoImpl(Tekla.Structures.Model.ModelInfo obj)
        {
            _tkl = obj;
        }

        public string ModelName
        {
            get => _tkl.ModelName;
            set => _tkl.ModelName = value;
        }

        public double NorthDirection
        {
            get => _tkl.NorthDirection;
            set => _tkl.NorthDirection = value;
        }
        public string ModelPath
        {
            get => _tkl.ModelPath;
            set => _tkl.ModelPath = value;
        }
        public int CurrentPhase
        {
            get => _tkl.CurrentPhase;
            set => _tkl.CurrentPhase = value;
        }
        public bool SharedModel => _tkl.SharedModel;
        public bool SingleUserModel => _tkl.SingleUserModel;
    }
}