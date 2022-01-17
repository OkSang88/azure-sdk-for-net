// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of OutboundRule and their operations over its parent. </summary>
    public partial class OutboundRuleCollection : ArmCollection, IEnumerable<OutboundRule>, IAsyncEnumerable<OutboundRule>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LoadBalancerOutboundRulesRestOperations _loadBalancerOutboundRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="OutboundRuleCollection"/> class for mocking. </summary>
        protected OutboundRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OutboundRuleCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal OutboundRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _loadBalancerOutboundRulesRestClient = new LoadBalancerOutboundRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Gets the specified load balancer outbound rule. </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual Response<OutboundRule> Get(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            if (outboundRuleName == null)
            {
                throw new ArgumentNullException(nameof(outboundRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _loadBalancerOutboundRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified load balancer outbound rule. </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public async virtual Task<Response<OutboundRule>> GetAsync(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            if (outboundRuleName == null)
            {
                throw new ArgumentNullException(nameof(outboundRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancerOutboundRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OutboundRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual Response<OutboundRule> GetIfExists(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            if (outboundRuleName == null)
            {
                throw new ArgumentNullException(nameof(outboundRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadBalancerOutboundRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<OutboundRule>(null, response.GetRawResponse());
                return Response.FromValue(new OutboundRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public async virtual Task<Response<OutboundRule>> GetIfExistsAsync(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            if (outboundRuleName == null)
            {
                throw new ArgumentNullException(nameof(outboundRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _loadBalancerOutboundRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, outboundRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<OutboundRule>(null, response.GetRawResponse());
                return Response.FromValue(new OutboundRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            if (outboundRuleName == null)
            {
                throw new ArgumentNullException(nameof(outboundRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(outboundRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="outboundRuleName"> The name of the outbound rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="outboundRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string outboundRuleName, CancellationToken cancellationToken = default)
        {
            if (outboundRuleName == null)
            {
                throw new ArgumentNullException(nameof(outboundRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(outboundRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the outbound rules in a load balancer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OutboundRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OutboundRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<OutboundRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerOutboundRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OutboundRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _loadBalancerOutboundRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the outbound rules in a load balancer. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OutboundRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OutboundRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OutboundRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerOutboundRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OutboundRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OutboundRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _loadBalancerOutboundRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OutboundRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<OutboundRule> IEnumerable<OutboundRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OutboundRule> IAsyncEnumerable<OutboundRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, OutboundRule, OutboundRuleData> Construct() { }
    }
}
