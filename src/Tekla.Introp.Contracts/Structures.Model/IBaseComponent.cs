namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IBaseComponent : IModelObject
    {
        string Name { get; set; }

        int Number { get; set; }

        void SetAttribute(string AttrName, string StrValue);

        void SetAttribute(string AttrName, int Value);

        void SetAttribute(string AttrName, double DValue);

        bool GetAttribute(string AttrName, ref string StrValue);

        bool GetAttribute(string AttrName, ref int Value);

        bool GetAttribute(string AttrName, ref double DValue);

        bool LoadAttributesFromFile(string Filename);
    }
}