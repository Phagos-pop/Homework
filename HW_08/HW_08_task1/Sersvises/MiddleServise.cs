using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_08_task1.Classes;

namespace HW_08_task1
{
    sealed class MiddleServise : IDeveloperServise
    {

        public Developer Developer { get; set; }
        public int Salary { get; set; }
        public string Title { get; set; }

        public MiddleServise(string firstName, string lastName, int experience, string gitHub)
        {
            Developer = new Developer();
            Developer.FirstName = firstName;
            Developer.LastName = lastName;
            Developer.Experience = experience;
            Developer.GitHub = gitHub;
            Developer.Responsibilities = SetResponsibilities();
            Salary = CalculateSalary();
            Title = SetTItle();
        }

        public int CalculateSalary()
        {
            return Company.BaseSalary * Company.MiddleCoefficient;
        }

        public string SetTItle()
        {
            return "Middle";
        }

        public string[] SetResponsibilities()
        {
            return Responsibilities.MiddleResponsibilities;
        }

    }

}
