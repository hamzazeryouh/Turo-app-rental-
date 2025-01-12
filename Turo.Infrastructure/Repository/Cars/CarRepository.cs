using Microsoft.EntityFrameworkCore;
using Turo.Domain.Entities;
using Turo.Infrastructure.Repository.Base;

namespace Turo.Infrastructure.Repository.Cars
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(DbContext context) : base(context)
        {
        }
    }
}
