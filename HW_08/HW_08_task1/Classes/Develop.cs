using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_task1.Classes
{
    class Developer
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Experience { get; set; }
        public string[] Responsibilities { get; set; }
        public string GitHub { get; set; }

        public Developer()
        {
            Id = Guid.NewGuid();
        }
    }
}
