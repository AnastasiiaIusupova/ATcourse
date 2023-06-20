using System.Net.Mail;

namespace HW6_Clinic;

public enum IlnessType
{
    Eyes,
    Teeth,
    Other
}
public class Patient
{
    private string namePatient;
    public IlnessType illPatient { get; set; }

    public Patient(string name, IlnessType ill)
    {
        namePatient = name;
        illPatient = ill;
    }
}