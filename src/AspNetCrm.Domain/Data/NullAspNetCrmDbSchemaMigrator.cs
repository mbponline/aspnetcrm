using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AspNetCrm.Data
{
    /* This is used if database provider does't define
     * IAspNetCrmDbSchemaMigrator implementation.
     */
    public class NullAspNetCrmDbSchemaMigrator : IAspNetCrmDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}