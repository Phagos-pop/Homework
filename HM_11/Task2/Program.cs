using Serilog;
using System;
using Task2.Models;
using Task2.Repository;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramStart();
            TestRepository(new MockMotorcycleRepository());
            TestRepository(new MsSqlAdoMotorcycleRepository());
            TestRepository(new MsSqlEfMotorcycleRepository());
        }

        private static void TestRepository(IMotorcycleRepository repository)
        {
            var moto = new Motorcycle
            {
                Id = Guid.NewGuid(),
                Name = "Honda CBR-600",
                Model = "CBR-600",
                Year = new DateTime(2000, 1, 1),
                Odometre = 56000
            };
            repository.CreateMotorcycle(moto);

            var moto1 = repository.GetMotorcycles();

            var moto2 = repository.GetMotorcycleById(moto.Id);

            moto.Name = "Yamaha";
            repository.UpdateMotorcycle(moto);
            var moto3 = repository.GetMotorcycleById(moto.Id);
            repository.DeleteMotorcycle(moto);

            var moto4 = repository.GetMotorcycles();
        }

        private static void ProgramStart()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("../../../Logs/log.txt", rollingInterval: RollingInterval.Hour)
                .CreateLogger();

            var type = typeof(Program);

            Log.Information($"Program: {type.Assembly.FullName}, namespace: {type.Namespace}");
        }

        private static void PrintInfo(string str)
        {
            Log.Information($"Started write to console");
            Console.WriteLine(str);
        }
    }
}
