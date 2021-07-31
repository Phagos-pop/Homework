using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace HW_07_task3
{
    class Catalog
    {
        string name;
        Guid guid = Guid.NewGuid();
        string category;
        int size;

        public Catalog(string _name, string _category, int _size)
        {
            name = _name;
            category = _category;
            size = _size;
        }
    }
}
