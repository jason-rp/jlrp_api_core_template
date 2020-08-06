using System.Threading.Tasks;

namespace jlrp_api_core_template.Contracts
{
    public interface IApiConnect
    {
        Task<TResponse> PostDataAsync<TResponse, TRequest>(string endPoint, TRequest request);
        Task<TResponse> GetDataAsync<TResponse>(string endPoint);
    }
}
