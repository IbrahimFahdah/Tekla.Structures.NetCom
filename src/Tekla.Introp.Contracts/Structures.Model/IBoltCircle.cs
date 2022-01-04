namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBoltCircle : IBoltGroup
    {
        double NumberOfBolts { get; set; }

        double Diameter { get; set; }
    }
}