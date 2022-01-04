using Tekla.Introp.Contracts.Forming.Enums;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IReinforcement : IModelObject
    {
        IModelObject Father { get; set; }

        string Grade { get; set; }

        string Name { get; set; }

        int Class { get; set; }

        INumberingSeries NumberingSeries { get; set; }

        IArrayList OnPlaneOffsets { get; set; }

        double FromPlaneOffset { get; set; }

        RebarOffsetTypeEnum StartPointOffsetType { get; set; }

        double StartPointOffsetValue { get; set; }

        RebarOffsetTypeEnum EndPointOffsetType { get; set; }

        double EndPointOffsetValue { get; set; }

        IArrayList RadiusValues { get; set; }

        DeformingType InputPointDeformingState { get; set; }

        IArrayList GetRebarGeometries(RebarGeometryOptionEnum options);

        IArrayList GetRebarGeometries(bool withHooks);

        IArrayList GetRebarGeometriesWithoutClashes(bool withHooks);

        bool IsGeometryValid();

        int GetNumberOfRebars();

        IRebarGeometry GetSingleRebar(int index, bool withHooks);

        IRebarGeometry GetSingleRebarWithoutClash(int index, bool withHooks);

        ISolid GetSolid();

        IPourObject GetFatherPour();

        IPourUnit GetFatherPourUnit();
    }
}