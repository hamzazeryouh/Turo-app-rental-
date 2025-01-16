using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Infrastructure.Repository;
using Turo.Infrastructure.Repository.Cars;

namespace Turo.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Cars { get; }
        IAgencyRepository Agencies { get; }
        IBookingRepository Bookings { get; }
        IReviewRepository Reviews { get; }
        IUserRepository Users { get; }
        Task<int> SaveChangesAsync();
    }

}
