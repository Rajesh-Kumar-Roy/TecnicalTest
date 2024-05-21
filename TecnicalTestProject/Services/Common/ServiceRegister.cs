using Microsoft.Extensions.DependencyInjection;
using Service.Contract.Base;
using Service.Services;

namespace Service.Common
{
    public static class ServiceRegister
    {
        public static void AddRegisterServices(this IServiceCollection services) =>
           services.AddTransient<IUnitOfWork, UnitOfWork>()
             .AddAutoMapper(typeof(AutoMapperProfile));
    }
}
