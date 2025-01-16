
namespace Turo.Infrastructure.UnitOfWork
{
    using Turo.Infrastructure.Persistence;
    using Turo.Infrastructure.Repository;
    using Turo.Infrastructure.Repository.Cars;
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IAgencyRepository Agencies => new AgencyRepository(_context);
        public IBookingRepository Bookings => new BookingRepository(_context);
        public ICarRepository Cars => new CarRepository(_context);
        public IReviewRepository Reviews => new ReviewRepository(_context);
        public IUserRepository Users => new UserRepository(_context);
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }

}
