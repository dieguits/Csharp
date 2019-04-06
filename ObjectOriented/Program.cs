using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.GetStudentName());

            student.Id = 7468;
            student.Name = "Diego Perez";
            student.Dob = new DateTime(2019, 04, 06);

            Console.WriteLine(student.GetStudentName());

            Console.ReadKey();
        }
    }
}
