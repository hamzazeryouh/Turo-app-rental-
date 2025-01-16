

namespace Turo.Infrastructure.Repository
{

    using Turo.Infrastructure.Persistence;
    using Turo.Infrastructure.Repository.Base;
    using Turo.Domain.Entities;
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
