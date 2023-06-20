using System.Net.Quic;

namespace HW6_Clinic;

public class Clinic
{
    public void ChooseTheDoctor(IlnessType ill)
    {
        switch ( ill)
        {
            case IlnessType.Teeth:
                Dentist dentist = new Dentist();
                dentist.Treat();
                break;
            case IlnessType.Eyes:
                Ophthalmologist optha = new Ophthalmologist();
                optha.Treat();
                break;
             case IlnessType.Other:
                Therapist therapist = new Therapist();
                therapist.Treat();
                break;
                
        }
    }
}