using System;

namespace HW6_Clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic();
            Patient patient = new Patient("Alex", IlnessType.Eyes);
            
            clinic.ChooseTheDoctor(patient.illPatient);

        }
    }
}