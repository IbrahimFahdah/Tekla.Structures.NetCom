namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBoltArray : IBoltGroup
    {
        bool AddBoltDistX(double DistX);

        bool AddBoltDistY(double DistY);

        bool RemoveBoltDistX(int Index);

        bool RemoveBoltDistY(int Index);

        int GetBoltDistXCount();

        int GetBoltDistYCount();

        double GetBoltDistX(int Index);

        double GetBoltDistY(int Index);

        bool SetBoltDistX(int Index, double DistX);

        bool SetBoltDistY(int Index, double DistY);
    }
}