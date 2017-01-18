using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Client.Interfaces;
using DD.CBU.Compute.Api.Client.Interfaces.Account20;
using DD.CBU.Compute.Api.Contracts.Directory;
using DD.CBU.Compute.Api.Contracts.General;
using DD.CBU.Compute.Api.Contracts.Requests;
using DD.CBU.Compute.Api.Contracts.Requests.Account20;

namespace DD.CBU.Compute.Api.Client.Account20
{
    /// <summary>
    /// he 2.X Account Accessor
    /// </summary>
    public class UserAccessor : IUserAccessor
    {
        /// <summary>
        /// The _api client.
        /// </summary>
        private readonly IWebApi _apiClient;

        /// <summary>Initialises a new instance of the <see cref="UserAccessor"/> class.</summary>
        /// <param name="apiClient">The api client.</param>
        public UserAccessor(IWebApi apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>
        /// Get the account details for current user.
        /// </summary>
        /// <returns></returns>
        public async Task<UserType> GetMyUser()
        {
            return await _apiClient.GetAsync<UserType>(ApiUris.GetMyUser());
        }

        /// <summary>
        /// Get the account details for given user name.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<UserType> GetUser(string userName)
        {
            return await _apiClient.GetAsync<UserType>(ApiUris.GetUser(_apiClient.OrganizationId, userName));
        }

        /// <summary>
        /// Get the paginated list of accounts for current org.
        /// </summary>
        /// <returns></returns>
        public async Task<PagedResponse<UserType>> GetUsersPaginated(UserListOptions filteringOptions = null, IPageableRequest pagingOptions = null)
        {
            var response = await _apiClient.GetAsync<UsersResponseCollection>(
                ApiUris.ListUsers(_apiClient.OrganizationId),
                pagingOptions,
                filteringOptions);

            return new PagedResponse<UserType>
            {
                items = response.user,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }
    }
}
