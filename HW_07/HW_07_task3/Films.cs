using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_task3
{
    class Films :Catalog
    {
        string director;
        string mainActor;
        string mainActress;
        
        public Films (string _director, string _mainActor, 
            string _mainActress, string _name, 
            string _category, int _size) :base(_name,_category,_size)
        {
            director = _director;
            mainActor = _mainActor;
            mainActress = _mainActress;
        }
    }
}
