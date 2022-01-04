using Tekla.Introp.Contracts.Structures.Geometry3d;
using Tekla.Introp.Contracts.Structures.Model.Enums;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPart : IModelObject, IAssemblable
    {
        IProfile Profile { get; set; }

        IMaterial Material { get; set; }

        IDeformingData DeformingData { get; set; }

        INumberingSeries PartNumber { get; set; }

        INumberingSeries AssemblyNumber { get; set; }

        string Name { get; set; }

        string Class { get; set; }

        string Finish { get; set; }

        CastUnitTypeEnum CastUnitType { get; set; }

        int PourPhase { get; set; }

        IPosition Position { get; set; }


        ISolid GetSolid();

        ISolid GetSolid(SolidCreationTypeEnum solidCreationType);

        //todo ISolid GetSolid(FormingStates formingStates);

        string GetPartMark();

        IArrayList GetCenterLine(bool withCutsFittings);

        IArrayList GetReferenceLine(bool withCutsFittings);

        IModelObjectEnumerator GetComponents();

        IModelObjectEnumerator GetBooleans();

        IModelObjectEnumerator GetBolts();

        IModelObjectEnumerator GetWelds();

        IModelObjectEnumerator GetReinforcements();

        IModelObjectEnumerator GetSurfaceTreatments();

        IModelObjectEnumerator GetSurfaceObjects();

        IModelObjectEnumerator GetPours();

        ICoordinateSystem GetDSTVCoordinateSystem();
    }
}