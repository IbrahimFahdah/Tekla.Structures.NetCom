namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface INumberingSeriesNullable
    {
        string Prefix { get; set; }

        int? StartNumber { get; set; }
    }
}