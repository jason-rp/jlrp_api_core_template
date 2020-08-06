using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace jlrp_api_core_template.Contracts
{
    public interface IServiceRegistration
    {
        void RegisterAppServices(IServiceCollection services, IConfiguration configuration);
    }
}
