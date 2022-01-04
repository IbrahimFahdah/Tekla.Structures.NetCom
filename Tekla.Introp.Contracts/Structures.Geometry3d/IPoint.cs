namespace Tekla.Introp.Contracts.Structures.Geometry3d
{
    public interface IPoint : ITkObjWrapper
    {
        double X
        {
            get;
            set;
        }

        double Y
        {
            get;
            set;
        }

        double Z
        {
            get;
            set;
        }
    }
}