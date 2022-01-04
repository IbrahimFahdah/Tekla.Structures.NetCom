namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarThreadingDataNullable
    {
        string ThreadingType { get; set; }

        double? Length { get; set; }

        double? ExtraFabricationLength { get; set; }
    }
}