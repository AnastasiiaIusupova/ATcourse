namespace HW6_Clinic;

public class Doctor
{
    
    public virtual void Treat(string name)
    {
        name = name;
        Console.WriteLine($"You need a doctor{name}");
    }
}