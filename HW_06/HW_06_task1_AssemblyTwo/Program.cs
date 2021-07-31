using System;
using HW_06_task1_AssemblyOne;

namespace HW_06_task1_AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();

            //Если не указывать модификатор доступа к классу то автоматически будет private, что означет что в этом проекте нельзя пользоватся этим классом

            motorcycle.maxSpeed = 12;
            motorcycle.vinNumber = "4546";
            motorcycle.odoMetr = 2462;
            Console.WriteLine(motorcycle.maxSpeed);
            motorcycle.StartEngine();


            //Мы не можем изменять или выводить эти поля, так как без прямого указателя модификатора доступа автоматически
            //присваивается модификатор private. Модификатор private дает доступ к полю только из класса в которой эта переменная была создана.
            //Так же мы не можем пользоватся методом, по тем же причинам.

            motorcycle.maxSpeedPublic = 1889;
            motorcycle.StopEnginePublic();

            //Это поле мы можем изменять и выводить, так как она обладает модификатором public. Этот модификатор дает доступ к полю из любого места
            //где представлен класс. Метод тоже нам доступен.

            motorcycle.CheckFuelPrivate();
            motorcycle.vinNumberPrivat = "1315ref21";

            //Явно указаный модификатор доступа private. Поле и метод не доступны

            motorcycle.odoMetrProtected = 196;
            motorcycle.AccelerateProtected();

            //Поле и метод доступны из текущего класса и производных классов. Здесь не доступны

            motorcycle.maxSpeedINternal = 166;
            motorcycle.SlowDownInternal();

            //Поле и метод доступны из любого места текущего проекта. Здесь не доступны

            motorcycle.vinNumberProtectedInternal = "19161";
            motorcycle.StopInPlaceProtectedInternal();

            //Поле и метод доступны из текущей сборки и из производных классов. Здесь доступны

            motorcycle.odoMetrPrivateProtected = 15632;
            motorcycle.StartPrivateProtected();

            //Поле и метод доступны из текущего класса и производных классов, которые определены в этом же проекте. Здесь не доступны

            SportBike sportBike = new SportBike();

            sportBike.maxSpeed = 12;
            sportBike.vinNumber = "4546";
            sportBike.odoMetr = 2462;
            Console.WriteLine(sportBike.maxSpeed);
            sportBike.StartEngine();

            //Аналогично как и в motorcycle. Не явное указание private. Здесь не доступно

            sportBike.maxSpeedPublic = 1889;
            sportBike.StopEnginePublic();

            //Это поле мы можем изменять и выводить, так как она обладает модификатором public. Этот модификатор дает доступ к полю и методу
            // Метод тоже нам доступен.

            sportBike.CheckFuelPrivate();
            sportBike.vinNumberPrivat = "q3211314";

            //Явно указаный модификатор доступа private. Поле и метод не доступны

            sportBike.odoMetrProtected = 196;
            sportBike.AccelerateProtected();

            //Поле и метод доступны из текущего класса и производных классов. Здесь не доступны

            sportBike.maxSpeedINternal = 166;
            sportBike.SlowDownInternal();

            //Поле и метод доступны из любого места текущего проекта. Здесь не доступны

            sportBike.vinNumberProtectedInternal = "19161";
            sportBike.StopInPlaceProtectedInternal();

            //Поле и метод доступны из текущей сборки и из производных классов. Здесь не доступны

            sportBike.odoMetrPrivateProtected = 15632;
            sportBike.StartPrivateProtected();

            //Поле и метод доступны из текущего класса и производных классов, которые определены в этом же проекте. Здесь не доступны
        }
    }
}
