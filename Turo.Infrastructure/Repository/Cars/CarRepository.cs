using Microsoft.EntityFrameworkCore;
using Turo.Domain.Entities;
using Turo.Infrastructure.Persistence;
using Turo.Infrastructure.Repository.Base;

namespace Turo.Infrastructure.Repository.Cars
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(AppDbContext  context) : base(context)
        {
        }
    }
}
