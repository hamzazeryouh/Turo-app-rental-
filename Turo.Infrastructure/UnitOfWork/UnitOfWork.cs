using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Infrastructure.Persistence;
using Turo.Infrastructure.Repository.Cars;

namespace Turo.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext  _context;
        public ICarRepository Cars { get; }

        public UnitOfWork(AppDbContext  context, ICarRepository carRepository)
        {
            _context = context;
            Cars = carRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
