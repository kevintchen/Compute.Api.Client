using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Contracts.General;
using DD.CBU.Compute.Api.Contracts.Network20;
using DD.CBU.Compute.Api.Contracts.Requests;
using DD.CBU.Compute.Api.Contracts.Requests.Network20;

namespace DD.CBU.Compute.Api.Client.Interfaces.Network20
{
    /// <summary>
    /// SSL accessor
    /// </summary>
    public interface ISslAccessor
    {
        /// <summary>
        /// Get SSL Domain Certificate for given Id.
        /// </summary>
        /// <param name="sslDomainCertificateId">The SSL Domain Certificate Id</param>
        /// <returns>The SSL Domain Certificate/></returns>
        Task<SslDomainCertificateType> GetSslDomainCertificate(Guid sslDomainCertificateId);

        /// <summary>
        /// Retrieves SSL Domain Certificates.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of paged collection of <see cref="SslDomainCertificateType"/></returns>
        Task<PagedResponse<SslDomainCertificateType>> GetSslDomainCertificatesPaginated(SslDomainCertificateListOptions options = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// Get SSL Certificate Chain for given Id.
        /// </summary>
        /// <param name="sslCertificateChainId">The SSL Certificate Chain Id</param>
        /// <returns>The SSL Certificate Chain <see cref="SslCertificateChainType"/></returns>
        Task<SslCertificateChainType> GetSslCertificateChain(Guid sslCertificateChainId);

        /// <summary>
        /// Retrieves SSL Domain Certificate Chaines.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of collection of <see cref="sslCertificateChains"/></returns>
        Task<PagedResponse<SslCertificateChainType>> GetSslCertificateChainesPaginated(SslCertificateChainListOptions options = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// Get SSL Offload Profile for given Id.
        /// </summary>
        /// <param name="sslOffloadProfileId">The SSL Offload Profile Id</param>
        /// <returns>The SSL Offload Profile/></returns>
        Task<SslOffloadProfileType> GetSslOffloadProfile(Guid sslOffloadProfileId);

        /// <summary>
        /// Retrieves SSL Offload Profiles.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of collection of <see cref="sslOffloadProfiles"/></returns>
        Task<PagedResponse<SslOffloadProfileType>> GetSslOffloadProfilesPaginated(SslOffloadProfileListOptions options = null, PageableRequest pagingOptions = null);
    }
}
