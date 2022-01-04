namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IRebarPropertiesNullable
    {
        string Size { get; set; }

        string Grade { get; set; }

        string Name { get; set; }

        int? Class { get; set; }

        INumberingSeriesNullable NumberingSeries { get; set; }

        double? BendingRadius { get; set; }
    }
}