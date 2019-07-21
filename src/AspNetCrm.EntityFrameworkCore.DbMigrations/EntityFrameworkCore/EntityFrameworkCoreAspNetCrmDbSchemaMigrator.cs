using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCrm.Data;
using Volo.Abp.DependencyInjection;

namespace AspNetCrm.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreAspNetCrmDbSchemaMigrator 
        : IAspNetCrmDbSchemaMigrator, ITransientDependency
    {
        private readonly AspNetCrmMigrationsDbContext _dbContext;

        public EntityFrameworkCoreAspNetCrmDbSchemaMigrator(AspNetCrmMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}