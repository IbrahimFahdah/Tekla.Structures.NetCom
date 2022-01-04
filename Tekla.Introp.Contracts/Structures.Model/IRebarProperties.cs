namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarProperties
    {
        string Size { get; set; }

        string Grade { get; set; }

        string Name { get; set; }

        int Class { get; set; }

        INumberingSeries NumberingSeries { get; set; }

        double BendingRadius { get; set; }
    }
}