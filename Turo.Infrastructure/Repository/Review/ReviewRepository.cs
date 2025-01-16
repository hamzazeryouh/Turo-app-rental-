using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turo.Domain.Entities;
using Turo.Infrastructure.Persistence;
using Turo.Infrastructure.Repository.Base;

namespace Turo.Infrastructure.Repository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext context) : base(context) { }
    }
}
