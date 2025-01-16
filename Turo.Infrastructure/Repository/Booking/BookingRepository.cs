

using Turo.Infrastructure.Persistence;
using Turo.Infrastructure.Repository.Base;

namespace Turo.Infrastructure.Repository
{
    public class BookingRepository : GenericRepository<Turo.Domain.Entities.Booking>, IBookingRepository
    {
        public BookingRepository(AppDbContext context) : base(context)
        {
        }
    }
}
