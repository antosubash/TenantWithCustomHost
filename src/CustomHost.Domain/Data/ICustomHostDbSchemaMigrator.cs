using System.Threading.Tasks;

namespace CustomHost.Data
{
    public interface ICustomHostDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
