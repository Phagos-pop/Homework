using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_08_task1.Classes;

namespace HW_08_task1
{
    class JuniorServise : DeveloperServise
    {

        public JuniorServise(string firstName, string lastName, int experience, string gitHub) : base(firstName, lastName, experience, gitHub)
        {
           
        }

        public override int CalculateSalary()
        {
            return Company.BaseSalary;
        }

        public override string SetTItle()
        {
            return "Junior";
        }

        public override string[] SetResponsibilities()
        {
            return Responsibilities.JuniorResponsibilities;
        }

    }

}
