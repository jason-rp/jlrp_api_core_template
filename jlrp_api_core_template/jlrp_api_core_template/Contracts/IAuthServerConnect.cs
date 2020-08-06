using System.Threading.Tasks;

namespace jlrp_api_core_template.Contracts
{
    public interface IAuthServerConnect
    {
        Task<string> RequestClientCredentialsTokenAsync();
    }
}
