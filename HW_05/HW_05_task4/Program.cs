using System;

namespace HW_05_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string addresses = Console.ReadLine();           
            string addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";
            Travel(addresses, "OH 43071");
            Travel(addresses, "NY 56432");
            Travel(addresses, "NY 5643");
        }        
        static void Travel(string addresses, string zipcode)
        {
            string[] arrayOfAddresses = GetArrayOfString(addresses, ',');
            bool test = default;
            if (addresses.Contains(zipcode))
            {
                Console.Write(zipcode + ":");
                string[] arrayOfNumHouse = new string[10];

                for (int i = 0; i < arrayOfAddresses.Length; i++)
                {                    
                    if (arrayOfAddresses[i].Contains(zipcode))
                    {
                        string[] arrayOfOneAddress = GetArrayOfString(arrayOfAddresses[i], ' ');
                        arrayOfNumHouse[i] = arrayOfOneAddress[0];
                        test = zipcode != arrayOfOneAddress[arrayOfOneAddress.Length - 2] + " " + arrayOfOneAddress[arrayOfOneAddress.Length - 1];


                        for (int j = 0; j < arrayOfOneAddress.Length; j++)
                        {
                            if (arrayOfOneAddress[j] != arrayOfNumHouse[i])
                            {
                                if (zipcode.Contains(arrayOfOneAddress[j]) || test)
                                {
                                    break;
                                }
                                Console.Write(arrayOfOneAddress[j] + " ");
                            }
                        }
                        Console.Write("/");                                           
                    }
                }
                for (int i = 0; i < arrayOfNumHouse.Length; i++)
                {
                    if (arrayOfNumHouse[i] != null && !test)
                    {
                        Console.Write(arrayOfNumHouse[i] + ",");
                    }                    
                }
            }
            else
            {
                Console.Write(zipcode + "/");
            }
            Console.WriteLine();
        }
        static string[] GetArrayOfString(string str, char symbol)
        {
            string[] strArray = str.Trim().Split(symbol);
            return strArray;
        }
    }
}
