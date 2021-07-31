using System;
using HW_08_task1.Sersvises;

namespace HW_08_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDeveloper.AddJuniorDeveloper ("Илья", "Цвирко", 1, "https://github.com/Phagos-pop");
            ListDeveloper.AddMiddleDeveloper ("Влад", "Кашковский", 2, "https://github.com/Phagos-pop");
            ListDeveloper.AddTeamLeaderDeveloper("Александр", "Бельский", 12, "https://github.com/Phagos-pop");
            ListDeveloper.AddSeniorDeveloper("Антон", "Покемон", 4, "https://github.com/Phagos-pop");
            ListDeveloper.AddArchitectDeveloper("Полина", "Макароновна", 5, "https://github.com/Phagos-pop");
            ListDeveloper.PrintAllDevelopers();
            
        }

    }

}
