using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Repository;
using Task2.Models;
using Task2.Storage;

namespace Task2.Repository
{
    class MsSqlEfMotorcycleRepository : IRepository<Motorcycle>
    {
        private readonly MotorcycleContext _context; 
        public MsSqlEfMotorcycleRepository()
        {
            _context = new MotorcycleContext();
        }
        public void Create(Motorcycle moto)
        {
            _context.Motorcycles.Add(moto);
            _context.SaveChanges();
            Log.Information($"{moto} created");
        }

        public void Delete(Motorcycle moto)
        {
            _context.Motorcycles.Remove(moto);
            _context.SaveChanges();
            Log.Information($"{moto} deleted");
        }

        public Motorcycle GetById(Guid id)
        {
            var moto= _context.Motorcycles.FirstOrDefault(moto => moto.Id.Equals(id));
            Log.Information($"{moto} got by id");
            return moto;
        }

        public IEnumerable<Motorcycle> GetObjects()
        {
            Log.Information($"All motorcycles got");
            return _context.Motorcycles;
        }

        public void Update(Motorcycle moto)
        {
            _context.Motorcycles.Update(moto);
            _context.SaveChanges();
            Log.Information($"{moto} updated");
        }
    }
}
