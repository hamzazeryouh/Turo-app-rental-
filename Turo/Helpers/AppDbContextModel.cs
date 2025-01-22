using Microsoft.EntityFrameworkCore.Metadata;
using Turo.Infrastructure.Persistence;

namespace Turo.Helpers
{
    public static class AppDbContextModel
    {
        public static IModel Instance { get; } = new Turo.Persistence.CompiledModels.AppDbContextModel();
    }

}
