using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_task1.Classes
{
    static class Responsibilities
    {
        public static string[] JuniorResponsibilities = 
            { "Основы программирования", "Язык программирования C#", "OOP", "ASP.NET", "Англиский язык на уровне A2" };
        public static string[] MiddleResponsibilities =
            { "Тоже что и Junior", "Уметь самостоятельно решать сложные задачи",
            "Знать, что такое шаблоны проектирования и зачем они нужны.", "Навыки командной работы", "Англиский язык на уровне B1" };
        public static string[] SeniorResponsibilities = 
            { "Тоже что и Midle", "Умеет строить стену абстракций между предметной областью и используемыми технологиями библиотеками", 
            "Пишет код понятно, компактно, структурированно, без копипасты;", "Код сеньера в условиях быстро меняющихся требований становится только лучше",
            "Англиский язык на уровне B2" };
        public static string[] TeamLeaderResponsibilities = 
            { "Тоже что и Senior", "Планировать задачи", "Писать технической документации", "Вершить код-ревью","Англиский язык на уровне С1" };
        public static string[] ArchitectResponsibilities =
            { "Тоже что и Senior", "Технологическое исследование и прототипирование", "Прояснение требований к проекту и коммуникация с заказчиком", "Создание архитектуры конечного продукта","Англиский язык на уровне С1" };
    }
}
