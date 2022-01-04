namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface ICOMDictionary
    {
        object[] Keys();
        object[] Values();
        void Set(object key, object value);
    }
}