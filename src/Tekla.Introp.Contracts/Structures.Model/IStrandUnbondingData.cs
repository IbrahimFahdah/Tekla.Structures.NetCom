namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IStrandUnbondingData
    {
        int StrandIndex { get; set; }

        double FromStart { get; set; }

        double MiddleToStart { get; set; }

        double MiddleToEnd { get; set; }

        double FromEnd { get; set; }
    }
}