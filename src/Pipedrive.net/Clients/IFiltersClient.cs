using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Pipeline API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Pipelines">Pipeline API documentation</a> for more information.
    public interface IFiltersClient
    {
        Task<IReadOnlyList<Filter>> GetAll();

        Task<Filter> Get(long id);

        Task<Filter> Create(NewFilter data);

        Task<Filter> Edit(long id, FilterUpdate data);

        Task Delete(long id);
    }
}
