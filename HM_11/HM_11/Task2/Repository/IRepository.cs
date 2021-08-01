﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Repository
{
    interface IRepository<T>
    {
        T GetById(Guid id);
        IEnumerable<T> GetObjects();  
        void Create(T moto);
        void Update(T moto);
        void Delete(T moto);
    }
}
