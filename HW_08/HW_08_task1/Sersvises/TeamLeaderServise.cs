using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_08_task1.Classes;

namespace HW_08_task1
{
    sealed class TeamLeaderServise : JuniorServise
    {

        public TeamLeaderServise(string firstName, string lastName, int experience, string gitHub) : base(firstName, lastName, experience, gitHub)
        {

        }

        protected override int CalculateSalary()
        {
            return Company.BaseSalary * Company.TeamLeaderCoefficient + Company.TeamLeaderPrize ;
        }

        protected override string SetTItle()
        {
            return "Team Leader";
        }

        protected override string[] SetResponsibilities()
        {
            return Responsibilities.TeamLeaderResponsibilities;
        }

    }

}
