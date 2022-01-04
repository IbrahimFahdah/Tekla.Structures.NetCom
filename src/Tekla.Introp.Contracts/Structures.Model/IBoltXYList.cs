namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBoltXYList : IBoltGroup
    {
        bool AddBoltDistX(double DistX);

        bool AddBoltDistY(double DistY);

        int GetBoltDistXCount();

        int GetBoltDistYCount();

        double GetBoltDistX(int Index);

        double GetBoltDistY(int Index);
    }
}