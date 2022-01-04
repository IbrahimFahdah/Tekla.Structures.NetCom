using System.Runtime.InteropServices;
using Tekla.Introp.Contracts.Structures.Geometry3d;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public partial class Guids
    {
        public const string IModel = "00870BD6-8779-4534-B8B0-F2E1DFF7BB4A";
        public const string CLSID_Model = "4378D242-7D40-441D-8743-B93068C43B30";
    }

    [Guid(Guids.IModel)]
    public interface IModel
    {
        bool GetConnectionStatus();
        IModelInfo GetInfo();
        IModelObjectSelector GetModelObjectSelector();
        bool CommitChanges();

        IBeam CreateBeam();
        IConnection CreateConnection();
        IVector CreateVector(double X, double Y, double Z);
        IPoint CreatePoint(double X, double Y, double Z);
        IPolygon CreatePolygon();
        IRebarGroup CreateRebarGroup();
    }

    [ComImport]
    [CoClass(typeof(ModelClass))]
    [Guid(Guids.IModel)]
    public interface Model : IModel
    {
    }

    [ComImport]
    [Guid(Guids.CLSID_Model)]
    public class ModelClass
    {
    }
}