using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06_task2
{
    internal class Motorcycle
    {
        readonly Guid guidMotorcycle =Guid.NewGuid();
        string model = null;
        string manufacturer = null;
        DateTime date = new DateTime();
        int mileage = default;
        Engine engine = new Engine();

        enum TypeEngine
        {
            ElectricalEngine,
            HybridEngine,
            GasolineEngine
        }
        private class Engine
        {
            public int engineVolume = default;
            public TypeEngine type = new TypeEngine();
            public int horsePower = default;

            internal static Engine CreateEngine()
            {
                Engine engine = new Engine();
                do
                {
                    Console.WriteLine("Введите обьем мотоцикла: ");
                    engine.engineVolume = Convert.ToInt32(Console.ReadLine());
                } while (engine.engineVolume < 125 && engine.engineVolume > 3200);

                do
                {
                    Console.WriteLine("Введите мощность мотоцикла: ");
                    engine.horsePower = Convert.ToInt32(Console.ReadLine());
                } while (engine.horsePower < 50 && engine.horsePower > 300);
                return engine;
            }
            internal static void PrintEngine()
            {

            }
        }        
        internal void Create()
        {
            do
            {
                Console.WriteLine("Введите модель мотоцикла: ");
                model = Console.ReadLine();
            } while (model == null);

            do
            {
                Console.WriteLine("Введите фирму производитель мотоцикла: ");
                manufacturer = Console.ReadLine();
            } while (manufacturer == null);

            date = DateTime.Today;

            do
            {
                Console.WriteLine("Введите пробег мотоцикла: ");
                mileage = Convert.ToInt32(Console.ReadLine());
            } while (mileage > 100 && mileage < 0);

            engine = Engine.CreateEngine();
        }

        internal static Motorcycle[] GetMotorcycleArray(Motorcycle motorcycle_1, Motorcycle motorcycle_2, Motorcycle motorcycle_3)
        {
            Motorcycle[] arrayOfMotorcycle = new Motorcycle[3];

            arrayOfMotorcycle[0] = motorcycle_1;
            arrayOfMotorcycle[1] = motorcycle_2;
            arrayOfMotorcycle[2] = motorcycle_3;

            return arrayOfMotorcycle;
        }
        internal static void PrintMotorcycleArray(Motorcycle[] arrayOfMotorcycle)
        {
            for (int i = 0; i < arrayOfMotorcycle.Length; i++)
            {
                Console.Write($"{i+1}.");
                Console.WriteLine($"\t Мотоцикл (Производитель): \"{arrayOfMotorcycle[i].manufacturer}\", Модель: {arrayOfMotorcycle[i].model}, ");
                Console.WriteLine($"\t Vin Number (Идентификатор): \"{arrayOfMotorcycle[i].guidMotorcycle}, Год: {arrayOfMotorcycle[i].date.Year}");
                Console.WriteLine($"\t {i}.1 Двигатель(Объем): \"{arrayOfMotorcycle[i].engine.engineVolume}\", Мощность: \"{arrayOfMotorcycle[i].engine.horsePower}");
               
            }
        }
    }
}
