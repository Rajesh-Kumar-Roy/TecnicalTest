using Microsoft.Extensions.DependencyInjection;
using Repository.Contract.IRepository;
using Repository.DataContext;
using Repository.Repositories;

namespace Repository.Common
{
    public static class RepoistoryRegister
    {
        public static void AddRepositoryServices(this IServiceCollection services) =>
            services.AddSingleton<DapperContext>()
            .AddTransient<ICorporateCustomerRepository, CorporateCustomerRepository>()
            .AddTransient<IIndividualCustomerRepository, IndividualCustomerRepository>()
            .AddTransient<ICustomerTypeRepository, CustomerTypeRepository>()
            .AddTransient<IProductServiceRepository, ProductServiceRepository>()
            .AddTransient<IMeetingMinutesMasterRepository, MeetingMinutesMasterRepository>()
            .AddTransient<IMeetingMinutesDetailsRepository, MeetingMinuteDetailsRepository>();
    }
}
