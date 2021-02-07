using System.Data;
using CV.Business.ValidationRules.AppUserValidators;
using CV.DataAccess.Concrete.Dapper;
using CV.DataAccess.Interfaces;
using CV.DTO.DTOs.AppUserDtos;
using FluentValidation;
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

            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));

            services.AddTransient<IValidator<AppUserForUpdateDto>, AppUserForUpdateValidator>();
        }
    }
}