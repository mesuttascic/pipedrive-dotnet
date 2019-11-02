using System.Collections.Generic;
using System.Threading.Tasks;
using Pipedrive.Helpers;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Pipeline API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Pipelines">Pipeline API documentation</a> for more information.
    class FiltersClient : ApiClient, IFiltersClient
    {
        /// <summary>
        /// Initializes a new Pipeline API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public FiltersClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<IReadOnlyList<Filter>> GetAll()
        {
            return ApiConnection.GetAll<Filter>(ApiUrls.Filters());
        }

        public Task<Filter> Get(long id)
        {
            return ApiConnection.Get<Filter>(ApiUrls.Filters(id));
        }

        public Task<Filter> Create(NewPipeline data)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Filter> Edit(long id, PipelineUpdate data)
        {
            throw new System.NotImplementedException();
        }
    }
}
