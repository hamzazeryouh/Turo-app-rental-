using Microsoft.EntityFrameworkCore;
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
    public class AgencyRepository : GenericRepository<Agency>, IAgencyRepository
    {
        public AgencyRepository(AppDbContext context) : base(context) { }

        public async Task<Agency> GetAgencyWithLocationsAsync(int agencyId)
        {
            return await _context.Agencies
                .Include(a => a.Locations)
                .FirstOrDefaultAsync(a => a.Id == agencyId);
        }
    }
}
