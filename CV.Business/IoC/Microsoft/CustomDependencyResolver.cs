using System.Data;
using CV.Business.Concrete;
using CV.Business.HashTool;
using CV.Business.Interfaces;
using CV.DataAccess.Concrete.Dapper;
using CV.DataAccess.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CV.Business.IoC.Microsoft
{
    public static class CustomDependencyResolver
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con =>
                new SqlConnection(configuration.GetConnectionString("DbConnection")));

            #region Business

            // services.AddTransient<IValidator<AppUserForUpdateDto>, AppUserForUpdateValidator>();
            services.AddTransient<IAppUserService, AppUserManager>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            // services.AddOptions<HashingOptions>();
            

            #endregion

            #region DataAccess

            services.AddTransient<IAppUserRepository, DpAppUserRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));

            #endregion
        }
    }
}