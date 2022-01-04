namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBentPlate : IPart
    {
        IConnectiveGeometry Geometry { get; set; }

        double Thickness { get; }
    }
}