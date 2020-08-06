using jlrp_api_core_template.Data;
using jlrp_api_core_template.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jlrp_api_core_template.Contracts
{
    public interface IPersonManager : IRepository<Person>
    {
        Task<(IEnumerable<Person> Persons, Pagination Pagination)> GetPersonsAsync(UrlQueryParameters urlQueryParameters);

        //Add more class specific methods here when neccessary
    }
}
