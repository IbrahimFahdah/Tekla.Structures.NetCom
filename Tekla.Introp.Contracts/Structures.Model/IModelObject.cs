using System;
using System.Runtime.InteropServices;

namespace Tekla.Introp.Contracts.Structures.Model
{
    public partial class Guids
    {
        public const string IModelObject = "EDFB934B-F264-470C-96D0-FFEABDB1FE63";
    }

    [Guid(Guids.IModelObject)]
    public interface IModelObject
    {
        DateTime ModificationTime { get; }

        bool IsUpToDate { get; }

        bool Insert();

        bool Select();

        bool Modify();

        bool Delete();

        IModelObjectEnumerator GetChildren();

        //BaseComponent GetFatherComponent();

        IModelObjectEnumerator GetHierarchicObjects();

        bool GetAllUserProperties(out ICOMDictionary values);

        bool GetIntegerUserProperties(out ICOMDictionary values);

        bool GetDoubleUserProperties(out ICOMDictionary values);

        bool GetStringUserProperties(out ICOMDictionary values);

        bool GetAllReportProperties(IArrayList stringNames, IArrayList doubleNames, IArrayList integerNames,
            out ICOMDictionary values);

        bool GetIntegerReportProperties(IArrayList names, out ICOMDictionary values);

        bool GetDoubleReportProperties(IArrayList names, out ICOMDictionary values);

        bool GetStringReportProperties(IArrayList names, out ICOMDictionary values);

        bool GetUserProperty(string name, ref string value);

        bool GetReportProperty(string name, ref string value);

        bool GetUserProperty(string name, ref double value);

        bool GetReportProperty(string name, ref double value);

        bool GetUserProperty(string name, ref int value);

        bool GetReportProperty(string name, ref int value);

        bool GetDynamicStringProperty(string name, ref string value);

        bool SetDynamicStringProperty(string name, string value);

        bool SetUserProperty(string name, string value);

        bool SetUserProperty(string name, double value);

        bool SetUserProperty(string name, int value);

        //CoordinateSystem GetCoordinateSystem();

        //bool SetPhase(Phase phase);

        //bool GetPhase(out Phase phase);

        bool SetLabel(string label);
    }
}