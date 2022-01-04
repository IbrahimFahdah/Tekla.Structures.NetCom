using System.Collections;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IProjectInfo
    {
        string Description { get; set; }

        string StartDate { get; set; }

        string EndDate { get; set; }

        string Object { get; set; }

        string Designer { get; set; }

        string Location { get; set; }

        string Address { get; set; }

        string PostalBox { get; set; }

        string Town { get; set; }

        string Region { get; set; }

        string PostalCode { get; set; }

        string Country { get; set; }

        string Builder { get; set; }

        string Name { get; set; }

        string ProjectNumber { get; set; }


        string Info1 { get; set; }

        string Info2 { get; set; }

        string GUID { get; set; }

        bool Modify();

        bool GetUserProperty(string Name, ref string Value);

        bool GetUserProperty(string Name, ref int Value);

        bool GetUserProperty(string Name, ref double Value);

        bool SetUserProperty(string Name, string Value);

        bool SetUserProperty(string Name, double Value);

        bool SetUserProperty(string Name, int Value);

        bool GetIntegerUserProperties(ref Hashtable Values);

        bool GetDoubleUserProperties(ref Hashtable Values);

        bool GetStringUserProperties(ref Hashtable Values);

        bool GetDynamicStringProperty(string Name, ref string Value);

        bool SetDynamicStringProperty(string Name, string Value);
    }
}