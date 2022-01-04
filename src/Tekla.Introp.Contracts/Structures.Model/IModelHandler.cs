namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IModelHandler
    {
        bool CreateNewSingleUserModel(string ModelName, string ModelFolder, string Template = "");

        bool CreateNewMultiUserModel(string ModelName, string ModelFolder, string ServerName);

        bool Save(string Comment = "", string User = "");

        bool Open(string ModelFolder, bool OpenAutoSaved = false);

        void Close();

        bool IsModelSaved();

        bool IsModelAutoSaved(string ModelFolder);
    }
}