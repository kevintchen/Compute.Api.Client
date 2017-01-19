using System.Threading.Tasks;
using DD.CBU.Compute.Api.Contracts.Directory;
using DD.CBU.Compute.Api.Contracts.General;
using DD.CBU.Compute.Api.Contracts.Requests;
using DD.CBU.Compute.Api.Contracts.Requests.Account20;

namespace DD.CBU.Compute.Api.Client.Interfaces.Account20
{
    /// <summary>
	/// The 2.X AccountAccessor interface.
	/// </summary>
    public interface IUserAccessor
    {
        /// <summary>
		/// Get the list of accounts for current org.
		/// </summary>
		/// <returns>
		/// The <see cref="Task"/>.
		/// </returns>
		Task<PagedResponse<UserType>> GetUsersPaginated(UserListOptions filteringOptions = null, IPageableRequest pagingOptions = null);

        /// <summary>
        /// Get the account details for given user name.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<UserType> GetUser(string userName);

        /// <summary>
        /// Get the account details for current user.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<UserType> GetMyUser();
    }
}
