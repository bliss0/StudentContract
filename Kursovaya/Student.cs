using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    internal class Student
    {
        public String FIO;
        public String dateOfBirth;
        
        public Student(String FIO, String dateOfBirth)
        {
            this.FIO = FIO;
            this.dateOfBirth = dateOfBirth;

        }
    }
}
