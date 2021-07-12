using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_task1
{
    class StudentAndTeacherTest
    {
        public static void CreatePersonAndSyaHello()
        {
            Person person = new Person();
            Console.WriteLine("Hello");
        }
        public static void CreateStudentAndSetAge()
        {
            Student student = new Student();
            student.SetAge(21);
            Console.WriteLine("Greet");
            student.ShowAge();
        }
        public static void CreateTeaherAndExplain()
        {
            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Explain();
        }
    }
}
