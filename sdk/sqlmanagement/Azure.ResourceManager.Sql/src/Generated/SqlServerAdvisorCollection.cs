// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerAdvisorResource"/> and their operations.
    /// Each <see cref="SqlServerAdvisorResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="SqlServerAdvisorCollection"/> instance call the GetSqlServerAdvisors method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class SqlServerAdvisorCollection : ArmCollection, IEnumerable<SqlServerAdvisorResource>, IAsyncEnumerable<SqlServerAdvisorResource>
    {
        private readonly ClientDiagnostics _sqlServerAdvisorServerAdvisorsClientDiagnostics;
        private readonly ServerAdvisorsRestOperations _sqlServerAdvisorServerAdvisorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerAdvisorCollection"/> class for mocking. </summary>
        protected SqlServerAdvisorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAdvisorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerAdvisorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerAdvisorServerAdvisorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerAdvisorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerAdvisorResource.ResourceType, out string sqlServerAdvisorServerAdvisorsApiVersion);
            _sqlServerAdvisorServerAdvisorsRestClient = new ServerAdvisorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerAdvisorServerAdvisorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a server advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvisors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual async Task<Response<SqlServerAdvisorResource>> GetAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }
            if (advisorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(advisorName));
            }

            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerAdvisorServerAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server advisor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvisors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<SqlServerAdvisorResource> Get(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }
            if (advisorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(advisorName));
            }

            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerAdvisorServerAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server advisors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvisors_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerAdvisorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerAdvisorResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerAdvisorServerAdvisorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SqlServerAdvisorResource(Client, SqlAdvisorData.DeserializeSqlAdvisorData(e)), _sqlServerAdvisorServerAdvisorsClientDiagnostics, Pipeline, "SqlServerAdvisorCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of server advisors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvisors_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerAdvisorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerAdvisorResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerAdvisorServerAdvisorsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new SqlServerAdvisorResource(Client, SqlAdvisorData.DeserializeSqlAdvisorData(e)), _sqlServerAdvisorServerAdvisorsClientDiagnostics, Pipeline, "SqlServerAdvisorCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvisors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }
            if (advisorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(advisorName));
            }

            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerAdvisorServerAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvisors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<bool> Exists(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }
            if (advisorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(advisorName));
            }

            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerAdvisorServerAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvisors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerAdvisorResource>> GetIfExistsAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }
            if (advisorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(advisorName));
            }

            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerAdvisorServerAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerAdvisorResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvisors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerAdvisorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="advisorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual NullableResponse<SqlServerAdvisorResource> GetIfExists(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }
            if (advisorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(advisorName));
            }

            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerAdvisorServerAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerAdvisorResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerAdvisorResource> IEnumerable<SqlServerAdvisorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerAdvisorResource> IAsyncEnumerable<SqlServerAdvisorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
