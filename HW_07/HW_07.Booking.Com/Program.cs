using System;
using HW_07.Booking.Com.Models;

namespace HW_07.Booking.Com
{
    class Program
    {
        static void Main(string[] args)
        {
            Boking boking = new Boking();
            boking.Registration();
            boking.Book();
            boking.Purchase()
        }
    }
}
