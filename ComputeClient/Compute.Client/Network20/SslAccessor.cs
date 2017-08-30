using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Client.Interfaces;
using DD.CBU.Compute.Api.Client.Interfaces.Network20;
using DD.CBU.Compute.Api.Contracts.General;
using DD.CBU.Compute.Api.Contracts.Network20;
using DD.CBU.Compute.Api.Contracts.Requests;
using DD.CBU.Compute.Api.Contracts.Requests.Network20;

namespace DD.CBU.Compute.Api.Client.Network20
{
    /// <summary>
    /// SSL accessor
    /// </summary>
    public class SslAccessor : ISslAccessor
    {
        /// <summary>
        /// The _client.
        /// </summary>
        private readonly IWebApi _apiClient;

        /// <summary>
        /// Initializes a new instance of SslAccessor
        /// </summary>
        /// <param name="apiClient">The client.</param>
        public SslAccessor(IWebApi apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>
        /// Get SSL Domain Certificate for given Id.
        /// </summary>
        /// <param name="sslDomainCertificateId">The SSL Domain Certificate Id</param>
        /// <returns>The SSL Domain Certificate/></returns>
        public async Task<SslDomainCertificateType> GetSslDomainCertificate(Guid sslDomainCertificateId)
        {
            return await _apiClient.GetAsync<SslDomainCertificateType>(
                ApiUris.GetSslDomainCertificate(_apiClient.OrganizationId, sslDomainCertificateId));
        }

        /// <summary>
        /// Retrieves SSL Domain Certificates.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of paged collection of <see cref="SslDomainCertificateType"/></returns>
        public async Task<PagedResponse<SslDomainCertificateType>> GetSslDomainCertificatesPaginated(
            SslDomainCertificateListOptions options = null, PageableRequest pagingOptions = null)
        {
            var response =
                await
                    _apiClient.GetAsync<sslDomainCertificates>(
                        ApiUris.ListSslDomainCertificates(_apiClient.OrganizationId), pagingOptions, options);

            return new PagedResponse<SslDomainCertificateType>
            {
                items = response.sslDomainCertificate,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?) null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?) null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?) null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?) null
            };
        }

        /// <summary>
        /// Get SSL Certificate Chain for given Id.
        /// </summary>
        /// <param name="sslCertificateChainId">The SSL Certificate Chain Id</param>
        /// <returns>The SSL Certificate Chain <see cref="SslCertificateChainType"/></returns>
        public async Task<SslCertificateChainType> GetSslCertificateChain(Guid sslCertificateChainId)
        {
            return await _apiClient.GetAsync<SslCertificateChainType>(
                ApiUris.GetSslCertificateChain(_apiClient.OrganizationId, sslCertificateChainId));
        }

        /// <summary>
        /// Retrieves SSL Domain Certificate Chaines.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of collection of <see cref="sslCertificateChains"/></returns>
        public async Task<PagedResponse<SslCertificateChainType>> GetSslCertificateChainesPaginated(
            SslCertificateChainListOptions options = null, PageableRequest pagingOptions = null)
        {
            var response =
                await
                    _apiClient.GetAsync<sslCertificateChains>(
                        ApiUris.ListSslCertificateChains(_apiClient.OrganizationId), pagingOptions, options);

            return new PagedResponse<SslCertificateChainType>
            {
                items = response.sslCertificateChain,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?) null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?) null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?) null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?) null
            };
        }

        /// <summary>
        /// Get SSL Offload Profile for given Id.
        /// </summary>
        /// <param name="sslOffloadProfileId">The SSL Offload Profile Id</param>
        /// <returns>The SSL Offload Profile/></returns>
        public async Task<SslOffloadProfileType> GetSslOffloadProfile(Guid sslOffloadProfileId)
        {
            return await _apiClient.GetAsync<SslOffloadProfileType>(
                ApiUris.GetSslSslOffloadProfile(_apiClient.OrganizationId, sslOffloadProfileId));
        }

        /// <summary>
        /// Retrieves SSL Offload Profiles.
        /// </summary>
        /// <param name="options">The filter options</param>
        /// <param name="pagingOptions">options for controlling the paging</param> 
        /// <returns>The async task of collection of <see cref="sslOffloadProfiles"/></returns>
        public async Task<PagedResponse<SslOffloadProfileType>> GetSslOffloadProfilesPaginated(SslOffloadProfileListOptions options = null, PageableRequest pagingOptions = null)
        {
            var response =
                await
                    _apiClient.GetAsync<sslOffloadProfiles>(
                        ApiUris.ListSslOffloadProfile(_apiClient.OrganizationId), pagingOptions, options);

            return new PagedResponse<SslOffloadProfileType>
            {
                items = response.sslOffloadProfile,
                totalCount = response.totalCountSpecified ? response.totalCount : (int?)null,
                pageCount = response.pageCountSpecified ? response.pageCount : (int?)null,
                pageNumber = response.pageNumberSpecified ? response.pageNumber : (int?)null,
                pageSize = response.pageSizeSpecified ? response.pageSize : (int?)null
            };
        }
    }
}
