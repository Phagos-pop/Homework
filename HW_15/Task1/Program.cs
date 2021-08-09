using System;
using System.Reflection;
using Task1.Class;
using Task1.Attributes;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseMotorcycle motorcycle = new PurchaseMotorcycle();
            motorcycle.CreditCardNumber = "5205554392178528";

            var type = typeof(PurchaseMotorcycle);
            foreach(PropertyInfo pi in type.GetProperties())
            {
                foreach (Attribute attribute in pi.GetCustomAttributes())
                {
                    CreditCardAttribute cardAttribute = attribute as CreditCardAttribute;

                    if (cardAttribute == null) continue;

                    Regex regex = new Regex(@"[\D]");
                    Match match = regex.Match(motorcycle.CreditCardNumber);

                    if (motorcycle.CreditCardNumber.Length != cardAttribute.Lenght ||
                        !(motorcycle.CreditCardNumber[0] == '9' ||
                          motorcycle.CreditCardNumber[0] == '5' ||
                          motorcycle.CreditCardNumber[0] == '4') ||
                        match.Success)
                    {
                        throw new Exception("Формат номера кредитной карты не подходит под общепринятые стандарты");
                    }
                }
            }
        }
    }
}
