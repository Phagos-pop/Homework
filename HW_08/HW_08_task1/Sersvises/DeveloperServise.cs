using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_08_task1.Classes;

namespace HW_08_task1
{
    interface IDeveloperServise
    {
        public Developer Developer { get; set; }

        public int Salary { get; set; }

        public string Title { get; set; }

        public abstract int CalculateSalary();

        public abstract string SetTItle();

        public abstract string[] SetResponsibilities();

    }

}
