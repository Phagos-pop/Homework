using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class CreditCardAttribute : Attribute
    {
        public int Lenght => 16;
    }
}
