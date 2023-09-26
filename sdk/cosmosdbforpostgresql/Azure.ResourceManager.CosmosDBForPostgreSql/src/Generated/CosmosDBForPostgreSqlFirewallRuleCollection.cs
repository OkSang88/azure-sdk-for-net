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

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBForPostgreSqlFirewallRuleResource" /> and their operations.
    /// Each <see cref="CosmosDBForPostgreSqlFirewallRuleResource" /> in the collection will belong to the same instance of <see cref="CosmosDBForPostgreSqlClusterResource" />.
    /// To get a <see cref="CosmosDBForPostgreSqlFirewallRuleCollection" /> instance call the GetCosmosDBForPostgreSqlFirewallRules method from an instance of <see cref="CosmosDBForPostgreSqlClusterResource" />.
    /// </summary>
    public partial class CosmosDBForPostgreSqlFirewallRuleCollection : ArmCollection, IEnumerable<CosmosDBForPostgreSqlFirewallRuleResource>, IAsyncEnumerable<CosmosDBForPostgreSqlFirewallRuleResource>
    {
        private readonly ClientDiagnostics _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics;
        private readonly FirewallRulesRestOperations _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlFirewallRuleCollection"/> class for mocking. </summary>
        protected CosmosDBForPostgreSqlFirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlFirewallRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlFirewallRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDBForPostgreSql", CosmosDBForPostgreSqlFirewallRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBForPostgreSqlFirewallRuleResource.ResourceType, out string cosmosDBForPostgreSqlFirewallRuleFirewallRulesApiVersion);
            _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient = new FirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBForPostgreSqlFirewallRuleFirewallRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBForPostgreSqlClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBForPostgreSqlClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new cluster firewall rule or updates an existing cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the cluster firewall rule. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBForPostgreSqlFirewallRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firewallRuleName, CosmosDBForPostgreSqlFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBForPostgreSqlArmOperation<CosmosDBForPostgreSqlFirewallRuleResource>(new CosmosDBForPostgreSqlFirewallRuleOperationSource(Client), _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new cluster firewall rule or updates an existing cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallRuleName"> The name of the cluster firewall rule. </param>
        /// <param name="data"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBForPostgreSqlFirewallRuleResource> CreateOrUpdate(WaitUntil waitUntil, string firewallRuleName, CosmosDBForPostgreSqlFirewallRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data, cancellationToken);
                var operation = new CosmosDBForPostgreSqlArmOperation<CosmosDBForPostgreSqlFirewallRuleResource>(new CosmosDBForPostgreSqlFirewallRuleOperationSource(Client), _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBForPostgreSqlFirewallRuleResource>> GetAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a cluster firewall rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<CosmosDBForPostgreSqlFirewallRuleResource> Get(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the firewall rules on cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBForPostgreSqlFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBForPostgreSqlFirewallRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBForPostgreSqlFirewallRuleResource(Client, CosmosDBForPostgreSqlFirewallRuleData.DeserializeCosmosDBForPostgreSqlFirewallRuleData(e)), _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, "CosmosDBForPostgreSqlFirewallRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the firewall rules on cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBForPostgreSqlFirewallRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBForPostgreSqlFirewallRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBForPostgreSqlFirewallRuleResource(Client, CosmosDBForPostgreSqlFirewallRuleData.DeserializeCosmosDBForPostgreSqlFirewallRuleData(e)), _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics, Pipeline, "CosmosDBForPostgreSqlFirewallRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBForPostgreSqlFirewallRuleResource>> GetIfExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBForPostgreSqlFirewallRuleResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlFirewallRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/firewallRules/{firewallRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallRuleName"> The name of the cluster firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual NullableResponse<CosmosDBForPostgreSqlFirewallRuleResource> GetIfExists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallRuleName, nameof(firewallRuleName));

            using var scope = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesClientDiagnostics.CreateScope("CosmosDBForPostgreSqlFirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlFirewallRuleFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBForPostgreSqlFirewallRuleResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlFirewallRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBForPostgreSqlFirewallRuleResource> IEnumerable<CosmosDBForPostgreSqlFirewallRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBForPostgreSqlFirewallRuleResource> IAsyncEnumerable<CosmosDBForPostgreSqlFirewallRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
