namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IDeformingData
    {
        double Angle { get; set; }

        double Angle2 { get; set; }

        double Cambering { get; set; }

        double Shortening { get; set; }
    }
}