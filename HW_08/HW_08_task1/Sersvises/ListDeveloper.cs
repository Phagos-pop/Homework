using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_08_task1.Classes;

namespace HW_08_task1.Sersvises
{
    static class ListDeveloper
    {
        static List<JuniorServise> Developers = new List<JuniorServise>();
        static List<JuniorServise> JuniorDevelopers = new List<JuniorServise>();
        static List<MiddleServise> MiddleDevelopers = new List<MiddleServise>();
        static List<SeniorServise> SeniorDevelopers = new List<SeniorServise>();
        static List<TeamLeaderServise> TeamLeaderDevelopers = new List<TeamLeaderServise>();
        static List<ArchitectServise> ArchitechDevelopers = new List<ArchitectServise>();

        public static void AddJuniorDeveloper(string firstName, string lastName, int experience, string gitHub)
        {

            JuniorServise junior = new JuniorServise(firstName, lastName, experience, gitHub);
            JuniorDevelopers.Add(junior);

        }

        public static void AddMiddleDeveloper(string firstName, string lastName, int experience, string gitHub)
        {

            MiddleServise middle = new MiddleServise(firstName, lastName, experience, gitHub);
            JuniorDevelopers.Add(middle);

        }

        public static void AddSeniorDeveloper(string firstName, string lastName, int experience, string gitHub)
        {

            SeniorServise senior = new SeniorServise(firstName, lastName, experience, gitHub);
            JuniorDevelopers.Add(senior);

        }

        public static void AddTeamLeaderDeveloper(string firstName, string lastName, int experience, string gitHub)
        {

            TeamLeaderServise teamLeader = new TeamLeaderServise(firstName, lastName, experience, gitHub);
            JuniorDevelopers.Add(teamLeader);

        }

        public static void AddArchitectDeveloper(string firstName, string lastName, int experience, string gitHub)
        {

            ArchitectServise architect = new ArchitectServise(firstName, lastName, experience, gitHub);
            JuniorDevelopers.Add(architect);

        }

        public static void PrintAllDevelopers()
        {
            Developers.AddRange(JuniorDevelopers);
            Developers.AddRange(SeniorDevelopers);
            Developers.AddRange(MiddleDevelopers);
            Developers.AddRange(TeamLeaderDevelopers);
            Developers.AddRange(ArchitechDevelopers);

            Developers = SortList(Developers).ToList<JuniorServise>();

            foreach (var i in Developers)
            {
                Console.WriteLine($"Company: {Company.CompanyName}, Full Name: {i.Developer.FirstName} {i.Developer.LastName}" +
                   $", Experience: {i.Developer.Experience}, Title: {i.Title},");
                Console.WriteLine($"Salary:{i.Salary} , GitHub: {i.Developer.GitHub}");
            }
            
        }

        static IOrderedEnumerable<JuniorServise> SortList(List<JuniorServise> Develop)
        {
            var sortedUsers = Develop.OrderByDescending(u => u.Developer.Experience);
            return sortedUsers;
        }

    }

}
 