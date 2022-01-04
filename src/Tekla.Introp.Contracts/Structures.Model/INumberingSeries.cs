namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface INumberingSeries : ITkObjWrapper
    {
        string Prefix { get; set; }

        int StartNumber { get; set; }
    }
}