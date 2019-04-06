using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Student
    {
        private int id; // the grey color is because now is fully protected
        private string name;
        private DateTime dob;

        //propfull

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public Student()
        {

        }

        public Student(int id, string name, DateTime dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        public string GetStudentName()
        {
            string studentName = "";

            studentName = id.ToString() + " -- " + name + " -- " + dob;

            return studentName;
        }


    }
}
