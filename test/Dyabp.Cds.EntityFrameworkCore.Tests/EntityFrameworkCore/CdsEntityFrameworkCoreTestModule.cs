using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Dyabp.Cds.EntityFrameworkCore
{
    [DependsOn(
        typeof(CdsEntityFrameworkCoreModule),
        typeof(CdsTestBaseModule),
        typeof(AbpEntityFrameworkCoreSqliteModule)
        )]
    public class CdsEntityFrameworkCoreTestModule : AbpModule
    {
        private SqliteConnection _sqliteConnection;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureInMemorySqlite(context.Services);

            Configure<AbpUnitOfWorkDefaultOptions>(options =>
            {
                options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
            });
        }

        private void ConfigureInMemorySqlite(IServiceCollection services)
        {
            _sqliteConnection = CreateDatabaseAndGetConnection();

            services.Configure<AbpDbContextOptions>(options =>
            {
                options.Configure(context =>
                {
                    context.DbContextOptions.UseSqlite(_sqliteConnection);
                });
            });
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            _sqliteConnection.Dispose();
        }

        private static SqliteConnection CreateDatabaseAndGetConnection()
        {
            var connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<CdsDbContext>()
                .UseSqlite(connection)
                .Options;

            using (var context = new CdsDbContext(options))
            {
                context.GetService<IRelationalDatabaseCreator>().CreateTables();
            }

            // Add the following code --------------
            var optionsForSecondDb = new DbContextOptionsBuilder<CdsSecondDbContext>()
                .UseSqlite(connection)
                .Options;

            using (var context = new CdsSecondDbContext(optionsForSecondDb))
            {
                context.GetService<IRelationalDatabaseCreator>().CreateTables();
            }
            //--------------------------------------

            return connection;
        }
    }
}
