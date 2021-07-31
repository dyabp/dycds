using System.Threading.Tasks;

namespace Dyabp.Cds.Data
{
    public interface ICdsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
