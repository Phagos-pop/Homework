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
            motorcycle.CreditCardNumber = "9112380004493260";

            var type = typeof(PurchaseMotorcycle);
            foreach (PropertyInfo pi in type.GetProperties())
            {
                foreach (Attribute attribute in pi.GetCustomAttributes())
                {
                    CreditCardAttribute cardAttribute = attribute as CreditCardAttribute;

                    if (cardAttribute == null) continue;

                    if (pi.Name == nameof(PurchaseMotorcycle.CreditCardNumber))
                    {
                        Regex regex = new Regex(@"[\d]");
                        Match match = regex.Match(motorcycle.CreditCardNumber);

                        if (motorcycle.CreditCardNumber.Length != cardAttribute.Lenght ||
                            !(motorcycle.CreditCardNumber[0] == 4 ||
                              motorcycle.CreditCardNumber[0] == 5 ||
                              motorcycle.CreditCardNumber[0] == 9 ) ||
                            match.Success)
                        {
                            throw new Exception("Формат номера кредитной карты не соответствует общепринятым нормам");
                        }
                    }
                }
            }
        }
    }
}
