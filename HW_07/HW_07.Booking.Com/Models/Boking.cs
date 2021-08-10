using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07.Booking.Com.Models
{
    sealed class Boking 
    {
        Catalog catalog = new Catalog();
        Person person;

        public void Registration()
        {
            person = new Person();
        }
        public void Seach()
        {            
            catalog.Seach();
        }
        public void Book()
        {
            Seach();
        }
        public void Purchase()
        {
            Seach();
        }
    }
}
