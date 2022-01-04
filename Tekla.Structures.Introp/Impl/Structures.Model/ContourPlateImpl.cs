using System.Runtime.InteropServices;
using Tekla.Introp.Contracts;
using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model;
using Tekla.Introp.Contracts.Structures.Model.Enums;
using ISolid = Tekla.Introp.Contracts.Structures.Model.ISolid;

namespace Tekla.Structures.Introp.Impl.Structures.Model
{
    [ComVisible(true)]
    public class ContourPlateImpl : ModelObjectImpl, IContourPlate
    {
        private Tekla.Structures.Model.ContourPlate TkContourPlate => (Tekla.Structures.Model.ContourPlate)TklModelObject;

        public ContourPlateImpl(Tekla.Structures.Model.ContourPlate obj) : base(obj)
        {
        }

        public IProfile Profile { get; set; }
        public IMaterial Material { get; set; }
        public IDeformingData DeformingData { get; set; }
        public INumberingSeries PartNumber { get; set; }
        public INumberingSeries AssemblyNumber { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Finish { get; set; }
        public CastUnitTypeEnum CastUnitType { get; set; }
        public int PourPhase { get; set; }
        public IPosition Position { get; set; }
        public ISolid GetSolid()
        {
            throw new System.NotImplementedException();
        }

        public ISolid GetSolid(SolidCreationTypeEnum solidCreationType)
        {
            throw new System.NotImplementedException();
        }

        IAssembly GetAssembly()
        {
            throw new System.NotImplementedException();
        }

        public string GetPartMark()
        {
            throw new System.NotImplementedException();
        }

        public IArrayList GetCenterLine(bool withCutsFittings)
        {
            throw new System.NotImplementedException();
        }

        public IArrayList GetReferenceLine(bool withCutsFittings)
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetComponents()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetBooleans()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetBolts()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetWelds()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetReinforcements()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetSurfaceTreatments()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetSurfaceObjects()
        {
            throw new System.NotImplementedException();
        }

        public IModelObjectEnumerator GetPours()
        {
            throw new System.NotImplementedException();
        }

        public ICoordinateSystem GetDSTVCoordinateSystem()
        {
            throw new System.NotImplementedException();
        }

        IAssembly IAssemblable.GetAssembly()
        {
            throw new System.NotImplementedException();
        }

        public ContourPlateTypeEnum Type { get; }
        public IContour Contour { get; set; }
        public bool AddContourPoint(IContourPoint contourPoint)
        {
            throw new System.NotImplementedException();
        }
    }
}