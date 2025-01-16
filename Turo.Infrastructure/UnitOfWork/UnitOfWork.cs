using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Infrastructure.Persistence;
using Turo.Infrastructure.Repository.Booking;
using Turo.Infrastructure.Repository;
using Turo.Infrastructure.Repository.Cars;
using Turo.Infrastructure.Repository.Review;

namespace Turo.Infrastructure.UnitOfWork
{
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
