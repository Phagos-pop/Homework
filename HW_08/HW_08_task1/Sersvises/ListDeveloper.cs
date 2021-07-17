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
        static List<IDeveloperServise> Developers = new List<IDeveloperServise>();
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
            MiddleDevelopers.Add(middle);

        }

        public static void AddSeniorDeveloper(string firstName, string lastName, int experience, string gitHub)
        {

            SeniorServise senior = new SeniorServise(firstName, lastName, experience, gitHub);
            SeniorDevelopers.Add(senior);

        }

        public static void AddTeamLeaderDeveloper(string firstName, string lastName, int experience, string gitHub)
        {

            TeamLeaderServise teamLeader = new TeamLeaderServise(firstName, lastName, experience, gitHub);
            TeamLeaderDevelopers.Add(teamLeader);

        }

        public static void AddArchitectDeveloper(string firstName, string lastName, int experience, string gitHub)
        {

            ArchitectServise architect = new ArchitectServise(firstName, lastName, experience, gitHub);
            ArchitechDevelopers.Add(architect);

        }

        public static void PrintAllDevelopers()
        {
            Developers.AddRange(ArchitechDevelopers);
            Developers.AddRange(TeamLeaderDevelopers);
            Developers.AddRange(SeniorDevelopers);
            Developers.AddRange(MiddleDevelopers);
            Developers.AddRange(JuniorDevelopers);
            

            PrintList(Developers);
        }

        //static IOrderedEnumerable<IDeveloperServise> SortList(List<IDeveloperServise> sortDevelop)
        //{
        //    var sortedUsers = sortDevelop.OrderByDescending(u => u.Developer.Experience);
        //    return sortedUsers;
        //}

        static void PrintList(List<IDeveloperServise> printDevelopers)
        {
            foreach (var i in printDevelopers)
            {
                Console.WriteLine($"Company: {Company.CompanyName}, Full Name: {i.Developer.FirstName} {i.Developer.LastName}" +
                   $", Experience: {i.Developer.Experience}, Title: {i.Title},");
                Console.WriteLine($"Salary:{i.Salary} , GitHub: {i.Developer.GitHub}");
            }

        }

    }

}
 