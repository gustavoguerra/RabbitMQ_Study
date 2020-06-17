using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Repository.Repository;

namespace API.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void DependencyInsection(this IServiceCollection services)
        {
            services.AddSingleton<IPaymentRepository, PaymentRepository>();
        }
    }
}
