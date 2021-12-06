using System;

namespace StudentsGradeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NewProffesor> studentsList = new List<NewProffesor>();
            List<string> students = new List<string>();
            createMenu(studentsList, students);
        }
        static int addInfo()
        {

            Console.WriteLine("add number of students");
            int numOfStudents = int.Parse(Console.ReadLine());
            return numOfStudents;
        }
        static void addStudentInfo(List<NewProffesor> list, List<string> studentsList)
        {
            for (int i = 0; i < addInfo(); i++) {
                Console.WriteLine("add student name");
                string studdName = Console.ReadLine();
                Console.WriteLine("proffessors name:");
                string proffName = Console.ReadLine();
                int studdId = list.Count;
                Console.WriteLine("add student grades");
                int[] studdGrades = new int[3];
                for (int j = 0; j < studdGrades.Length; j++) {
                    studdGrades[j] = int.Parse(Console.ReadLine());
                }
                NewProffesor proff = new NewProffesor($"{proffName}", $"{studdName}", studdId, studdGrades);
                list.Add(proff);
                studentsList.Add($"proffesor name:{proffName},student name:{studdName},student id:{studdId}, grades:{studdGrades[0]}  grades:{studdGrades[0]}  grades:{studdGrades[0]}");
            }
        }
        static void createFile(List<NewProffesor> list)
        {

            for (int k = 0; k < list.Count; k++) {
                FileStream fs = new FileStream($@"C:\test\proffesor-{list[0].proffName}.txt", FileMode.Append);
                using (StreamWriter sw = new StreamWriter(fs)) {
                    sw.WriteLine($"student name:{list[k].studentName} student grades:{list[k].grades[0]},{list[k].grades[1]},{list[k].grades[2]} studdent id:0{list[k].studentId}");
                }
            }
        }
        static void printFirstAndAvg(List<NewProffesor> studentsList)
        {
            int avg = 0;
            for (int i = 0; i < studentsList.Count; i++) {

                for (int j = 0; j < studentsList[0].grades.Length; j++) {
                    avg = studentsList[0].grades[j] / studentsList[0].grades.Length;
                }
            }
            Console.WriteLine($"student name:{studentsList[0].studentName}, student avg={avg}");
        }
        static void printSecondAndAvg(List<NewProffesor> studentsList)
        {
            int avg = 0;
            for (int i = 0; i < studentsList.Count; i++) {

                for (int j = 0; j < studentsList[1].grades.Length; j++) {
                    avg = studentsList[1].grades[j] / studentsList[1].grades.Length;
                }

            }
            Console.WriteLine($"student name:{studentsList[1].studentName}, student avg={avg}");
        }
        static void printByIndex(List<NewProffesor> studentsList, int userNum)
        {
            Console.WriteLine("choose a student by it's index in the list:");
            int avg = 0;
            for (int i = 0; i < studentsList.Count; i++) {

                for (int j = 0; j < studentsList[userNum].grades.Length; j++) {
                    avg = studentsList[userNum].grades[j] / studentsList[userNum].grades.Length;
                }
            }
            Console.WriteLine($"student name:{studentsList[0].studentName}, student avg={avg}");
        }
        static void createMenu(List<NewProffesor> list, List<string> studentsList)
        {
            Console.Write("welconme to our proffesors program \n1.add a student \n2.save added students \n3.print last proffesor's  first student info\n4. print last proffesor's second student info\n5.show student by it's index\n0.close the program ");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput) {
                case 1:

                    addStudentInfo(list, studentsList);
                    break;
                case 2:
                    createFile(list);
                    Console.WriteLine("\ninfo has been saved as a text file\n");
                    break;
                case 3:
                    printFirstAndAvg(list);
                    break;
                case 4:
                    printSecondAndAvg(list);
                    break;
                case 5:
                    Console.WriteLine($"add a index from 0 to {list.Count-1}");
                    int userNum = int.Parse(Console.ReadLine());
                    printByIndex(list, userNum);
                    break;
                case 0:
                    return;
                default:
                    return;
            }
            createMenu(list, studentsList);
        }
    }
}
