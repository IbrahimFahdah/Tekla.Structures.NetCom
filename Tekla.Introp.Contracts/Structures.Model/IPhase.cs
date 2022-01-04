namespace Tekla.Introp.Contracts.Structures.Model
{
    public interface IPhase
    {
        int PhaseNumber { get; set; }

        string PhaseName { get; set; }

        string PhaseComment { get; set; }

        int IsCurrentPhase { get; set; }

        bool Insert();

        bool Select();

        bool Modify();

        bool Delete();

        bool SetUserProperty(string Name, string Value);

        bool SetUserProperty(string Name, double Value);

        bool SetUserProperty(string Name, int Value);

        bool GetUserProperty(string Name, ref string Value);

        bool GetUserProperty(string Name, ref double Value);

        bool GetUserProperty(string Name, ref int Value);
    }
}