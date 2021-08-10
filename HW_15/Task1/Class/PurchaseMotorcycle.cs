using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Attributes;

namespace Task1.Class
{
    sealed class PurchaseMotorcycle
    {
        [CreditCard]
        public string CreditCardNumber { get; set; }
    }
}
