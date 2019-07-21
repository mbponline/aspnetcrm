using System.Threading.Tasks;

namespace AspNetCrm.Data
{
    public interface IAspNetCrmDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
