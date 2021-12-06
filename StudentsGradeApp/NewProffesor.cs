using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGradeApp
{
    public class NewProffesor
    {
        public string proffName;
        public string studentName;
        public int studentId;
        public int[] grades = new int[3];

        public NewProffesor(string proffName, string studentName, int studentId, int[] grades)
        {
            this.proffName = proffName;
            this.studentName = studentName;
            this.studentId = studentId;
            this.grades = grades;
        }
        public void GetStudents()
        {

        }
    }
}


