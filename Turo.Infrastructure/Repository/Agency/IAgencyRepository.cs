
namespace Turo.Infrastructure.Repository
{
    using Turo.Domain.Entities;
    using Turo.Infrastructure.Repository.Base;
    public interface IAgencyRepository : IGenericRepository<Agency>
    {
        Task<Agency> GetAgencyWithLocationsAsync(int agencyId);
    }
}
