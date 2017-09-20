namespace DD.CBU.Compute.Api.Client.Server20
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts.General;
    using Contracts.Requests;
    using Contracts.Requests.Snapshot;
    using Interfaces;
    using Interfaces.Server20;

    /// <summary>
    /// The server 2.0 accessor.
    /// </summary>
    public class SnapshotAccessor : ISnapshotAccessor
    {
        /// <summary>
        /// The _api client.
        /// </summary>
        private readonly IWebApi _apiClient;

        /// <summary>Initialises a new instance of the <see cref="ServerAccessor"/> class.</summary>
        /// <param name="apiClient">The api client.</param>
        public SnapshotAccessor(IWebApi apiClient)
        {
            _apiClient = apiClient;
        }


        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="serverId">The serve Id</param>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<IEnumerable<SnapshotType>> GetSnapshots(Guid serverId, SnapshotListOptions filteringOptions = null)
        {
            var response = await GetSnapshotsPaginated(serverId, filteringOptions, null);
            return response.items;
        }

        /// <summary>The get mcp 2 deployed servers.</summary>
        /// <param name="serverId">The serve Id</param>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The paging options.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task<PagedResponse<SnapshotType>> GetSnapshotsPaginated(Guid serverId, SnapshotListOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            var response = await _apiClient.GetAsync<snapshots>(
                ApiUris.ListSnapshots(_apiClient.OrganizationId, serverId),
                pagingOptions,
                filteringOptions);

            return new PagedResponse<SnapshotType>
            {
                items = response.snapshot,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?) null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?) null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?) null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?) null
            };
        }
    }
}