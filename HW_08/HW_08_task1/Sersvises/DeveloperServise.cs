using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_08_task1.Classes;

namespace HW_08_task1
{
    abstract class DeveloperServise
    {
        public Developer Developer = new Developer();
        public int Salary { get; private set; }
        public string Title { get; private set; }

        public DeveloperServise(string firstName, string lastName, int experience, string gitHub)
        {
            Developer.FirstName = firstName;
            Developer.LastName = lastName;
            Developer.Experience = experience;
            Developer.GitHub = gitHub;
            Developer.Responsibilities = SetResponsibilities();
            Salary = CalculateSalary();
            Title = SetTItle();
        }

        public abstract int CalculateSalary();

        public abstract string SetTItle();

        public abstract string[] SetResponsibilities();

    }
    
}
