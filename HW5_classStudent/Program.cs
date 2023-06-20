using System;

namespace HW5_classStudent // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static int PrintBestStudentsInMath(Student[] studentsGroup, bool printResult = true)
        {
            var bestStudent = (Student?) null;
            var maxScore = int.MinValue;
            foreach (var student in studentsGroup)
            {
                if (maxScore < student.mathMark)
                {
                    maxScore = student.mathMark;
                    bestStudent = student;
                }
            }
            
            if(printResult) Console.WriteLine($"{bestStudent?.name}, Math mark: {bestStudent?.mathMark}");

            return maxScore;
        }
        
        private static int PrintBestStudentsInPhysEduc(Student[] studentsGroup, bool printResult = true)
        {
            var bestStudent = (Student?) null;
            var maxScore = int.MinValue;
            foreach (var student in studentsGroup)
            {
                if (maxScore < student.physicalEducationMark)
                {
                    maxScore = student.physicalEducationMark;
                    bestStudent = student;
                }
            }
            
            if(printResult) Console.WriteLine($"{bestStudent?.name}, Math mark: {bestStudent?.physicalEducationMark}");

            return maxScore;
        }

        private static int PrintBestStudentsInBio(Student[] studentsGroup, bool printResult = true)
        {
            var bestStudent = (Student?) null;
            var maxScore = int.MinValue;
            foreach (var student in studentsGroup)
            {
                if (maxScore < student.biologyMark)
                {
                    maxScore = student.biologyMark;
                    bestStudent = student;
                }
            }
            
            if(printResult) Console.WriteLine($"{bestStudent?.name}, Math mark: {bestStudent?.biologyMark}");

            return maxScore;
        }
        public static void PrintAverageMathMark(Student[] studentsGroup)
        {
            decimal total = 0;

            foreach (var student in studentsGroup)
            {
                total += student.mathMark;
            }
            var average = total / studentsGroup.Length;
            Console.WriteLine($"Group{studentsGroup[0].group}, Average math mark: {average}" );
        }
        
        public static void PrintAveragePhysEducMark(Student[] studentsGroup)
        {
            decimal total = 0;

            foreach (var student in studentsGroup)
            {
                total += student.physicalEducationMark;
            }
            var average = total / studentsGroup.Length;
            Console.WriteLine($"Group{studentsGroup[0].group}, Average math mark: {average}" );
        }
        
        public static void PrintAverageBioMark(Student[] studentsGroup)
        {
            decimal total = 0;

            foreach (var student in studentsGroup)
            {
                total += student.biologyMark;
            }
            var average = total / studentsGroup.Length;
            Console.WriteLine($"Group{studentsGroup[0].group}, Average math mark: {average}" );
        }
        public static void PrintAverageMarkByGroup(Student[] studentsGroup)
        {
            var total = 0M;
            for (var i = 0; i <= studentsGroup.Length - 1; i++)
            {
                total += studentsGroup[i].GetAverageMark();
            }
            var average = total / studentsGroup.Length;

            Console.WriteLine($"Avearage mark of group{studentsGroup[0].group} - Math, PhysicalEducation, Biology - {average}" );
        }

        public static void RewardBestStudentInGroup(Student[] studentsGroup)
        {
            var maxAverageMark = decimal.MinValue;
            foreach (var student in studentsGroup)
            {
                if (maxAverageMark < student.GetAverageMark())
                {
                    maxAverageMark = student.GetAverageMark();
                }
            }

            var rand = new Random();
            foreach (var student in studentsGroup)
            {
                if (student.GetAverageMark() == maxAverageMark)
                {
                    var previousReward = student.GetReward();
                    student.SetReward(rand.Next(1, 101));
                    Console.WriteLine($"Best student {student.name} in {student.group} has {student.GetReward()} reward (had {previousReward}) with {student.GetAverageMark()} average mark");
                }
            }
        }

        // public static void BestMathResult(Student[] studentsGroup)
        // {
        //     Random rand = new Random();
        //     int maxMathValue = 0;
        //     string studentName = "?";
        //     var studentRew = new Student();
        //     int studentReword = studentsGroup[0].reward;
        //
        //     for (int i = 0; i <= studentsGroup.Length - 1; i++)
        //     {
        //         if (studentsGroup[i].mathMark > maxMathValue)
        //         {
        //             // найден больший элемент
        //             maxMathValue = studentsGroup[i].mathMark;
        //             studentName = studentsGroup[i].name;
        //             // studentRew.Reward = 
        //             studentReword = studentsGroup[i].reward;
        //         }
        //     }
        //
        //     IncreaseReword(ref studentRew.Reward); // как увеличит reword в вне этой функции?
        //     Console.WriteLine($"{studentName}, Math mark:{maxMathValue}, Increase reword: { studentRew.Reward}");
        // }
        //
        // public static int IncreaseReword(int studentReword)
        // {
        //     Random rand = new Random();
        //     studentReword = studentReword + rand.Next(1, 100);
        //     return studentReword;
        // }

        
        static void Main(string[] args)
        {
            Random rand = new Random();

            Student[] groupOne = new Student[]
            {
                new Student(1, "Anna", 26, 1, rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100)),
                new Student ( 2,  "Alina",  26,  1, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11),rand.Next(1, 100)),
                new Student ( 3,  "Vika",  26,  1, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100)),
                new Student ( 4,  "Masha",  26,  1, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11),rand.Next(1, 100)),
                new Student ( 5,  "Misha",  26,  1, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11),rand.Next(1, 100))
            };
            
            Student[] groupTwo = new Student[]
            {
                new Student(1, "Sam", 26, 2, rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100)),
                new Student ( 2,  "Ali",  26,  2, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100)),
                new Student ( 3,  "Alan",  26,  2, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11),  rand.Next(1, 100)),
                new Student ( 4,  "Mino",  26,  2, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11),  rand.Next(1, 100)),
                new Student ( 5,  "Mone",  26,  2, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100))
            };
            
            Student[] groupThree = new Student[]
            {
                new Student(1, "Zak", 24, 3, rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100)),
                new Student ( 2,  "Mike",  25,  3, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100)),
                new Student ( 3,  "Vika",  26,  3, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100)),
                new Student ( 4,  "Masha",  23,  3, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100)),
                new Student ( 5,  "Misha",  26,  3, rand.Next(1,11), rand.Next(1, 11), rand.Next(1, 11), rand.Next(1, 100))
            };

            foreach (var group in new[] { groupOne, groupTwo, groupThree })
            {
                PrintBestStudentsInMath(group);
                PrintAverageMathMark(group);

                PrintBestStudentsInPhysEduc(group);
                PrintAveragePhysEducMark(group);

                PrintBestStudentsInBio(group);
                PrintAverageBioMark(group);

                PrintAverageMarkByGroup(group);
                RewardBestStudentInGroup(group);
            }
        }
    }
}