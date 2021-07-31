using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_task3
{
    class MusicFiles : Catalog
    {
        string singer;
        int lenght;

        public MusicFiles (string _singer, int _lenght, string _name,
            string _category, int _size) : base(_name, _category, _size)
        {
            singer = _singer;
            lenght = _lenght;
        }

        public void Play()
        {

        }

        public void RetrieveInformation()
        {

        }
    }
}
