using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.Repository
{
    class MockMotorcycleRepository : IMotorcycleRepository
    {
        private List<Motorcycle> _motorcycles { get; set; } = new List<Motorcycle>();
        public void CreateMotorcycle(Motorcycle moto)
        {
            if (!_motorcycles.Contains(moto))
            {
                _motorcycles.Add(moto);
                Log.Information($"{moto} created");
            }
        }

        public void DeleteMotorcycle(Motorcycle moto)
        {
            _motorcycles.Remove(moto);
            Log.Information($"{moto} deleted");
        }

        public Motorcycle GetMotorcycleById(Guid id)
        {
            var moto=_motorcycles.FirstOrDefault(moto => moto.Id.Equals(id));
            Log.Information($"{moto} got by id");
            return moto;
        }

        public IEnumerable<Motorcycle> GetMotorcycles()
        {
            Log.Information($"All motorcycles got");
            return _motorcycles;
        }

        public void UpdateMotorcycle(Motorcycle moto)
        {
            var index = _motorcycles.FindIndex(obj=>obj.Equals(moto));
            if (index < 0)
                CreateMotorcycle(moto);
            else
                _motorcycles[index] = moto;
            Log.Information($"{moto} updated");
        }
    }
}
