namespace HW5_classStudent;

public class Student
{
    public int id;
    public string name;
    public int age;
    public int group;
    public int mathMark;
    public int physicalEducationMark;
    public int biologyMark;
    private int reward;

    public Student(int studentId, string studentName, int studentAge, int studentGroup, int studentMathMark, int studentPhysicalEducationMark, int studentBiologyMark, int studentReward)
    {
        id = studentId;
        age = studentAge;
        name = studentName;
        group = studentGroup;
        mathMark = studentMathMark;
        physicalEducationMark = studentPhysicalEducationMark;
        biologyMark = studentBiologyMark;
        reward = studentReward;
    }

    public void SetReward(int newReward)
    {
        reward = newReward > 1 ? newReward : 1;
    }

    public int GetReward()
    {
        return reward;
    }

    public decimal GetAverageMark()
    {
        return (mathMark + biologyMark + physicalEducationMark) / 3M;
    }
}