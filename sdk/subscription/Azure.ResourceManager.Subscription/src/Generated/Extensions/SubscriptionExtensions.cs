// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Subscription.Mocking;
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static MockableSubscriptionArmClient GetMockableSubscriptionArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableSubscriptionArmClient(client0));
        }

        private static MockableSubscriptionSubscriptionResource GetMockableSubscriptionSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSubscriptionSubscriptionResource(client, resource.Id));
        }

        private static MockableSubscriptionTenantResource GetMockableSubscriptionTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSubscriptionTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="SubscriptionAliasResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubscriptionAliasResource.CreateResourceIdentifier" /> to create a <see cref="SubscriptionAliasResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionArmClient.GetSubscriptionAliasResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SubscriptionAliasResource" /> object. </returns>
        public static SubscriptionAliasResource GetSubscriptionAliasResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSubscriptionArmClient(client).GetSubscriptionAliasResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TenantPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TenantPolicyResource.CreateResourceIdentifier" /> to create a <see cref="TenantPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionArmClient.GetTenantPolicyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TenantPolicyResource" /> object. </returns>
        public static TenantPolicyResource GetTenantPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSubscriptionArmClient(client).GetTenantPolicyResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingAccountPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingAccountPolicyResource.CreateResourceIdentifier" /> to create a <see cref="BillingAccountPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionArmClient.GetBillingAccountPolicyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="BillingAccountPolicyResource" /> object. </returns>
        public static BillingAccountPolicyResource GetBillingAccountPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSubscriptionArmClient(client).GetBillingAccountPolicyResource(id);
        }

        /// <summary>
        /// The operation to cancel a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Subscription/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Cancel</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionSubscriptionResource.CancelSubscription(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        public static async Task<Response<CanceledSubscriptionId>> CancelSubscriptionAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableSubscriptionSubscriptionResource(subscriptionResource).CancelSubscriptionAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The operation to cancel a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Subscription/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Cancel</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionSubscriptionResource.CancelSubscription(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        public static Response<CanceledSubscriptionId> CancelSubscription(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableSubscriptionSubscriptionResource(subscriptionResource).CancelSubscription(cancellationToken);
        }

        /// <summary>
        /// The operation to rename a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Subscription/rename</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Rename</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionSubscriptionResource.RenameSubscription(SubscriptionName,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="body"> Subscription Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="body"/> is null. </exception>
        public static async Task<Response<RenamedSubscriptionId>> RenameSubscriptionAsync(this SubscriptionResource subscriptionResource, SubscriptionName body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableSubscriptionSubscriptionResource(subscriptionResource).RenameSubscriptionAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The operation to rename a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Subscription/rename</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Rename</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionSubscriptionResource.RenameSubscription(SubscriptionName,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="body"> Subscription Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="body"/> is null. </exception>
        public static Response<RenamedSubscriptionId> RenameSubscription(this SubscriptionResource subscriptionResource, SubscriptionName body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableSubscriptionSubscriptionResource(subscriptionResource).RenameSubscription(body, cancellationToken);
        }

        /// <summary>
        /// The operation to enable a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Subscription/enable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Enable</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionSubscriptionResource.EnableSubscription(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        public static async Task<Response<EnabledSubscriptionId>> EnableSubscriptionAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableSubscriptionSubscriptionResource(subscriptionResource).EnableSubscriptionAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The operation to enable a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Subscription/enable</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Enable</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionSubscriptionResource.EnableSubscription(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        public static Response<EnabledSubscriptionId> EnableSubscription(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableSubscriptionSubscriptionResource(subscriptionResource).EnableSubscription(cancellationToken);
        }

        /// <summary>
        /// Gets a collection of SubscriptionAliasResources in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetSubscriptionAliases()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> An object representing collection of SubscriptionAliasResources and their operations over a SubscriptionAliasResource. </returns>
        public static SubscriptionAliasCollection GetSubscriptionAliases(this TenantResource tenantResource)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableSubscriptionTenantResource(tenantResource).GetSubscriptionAliases();
        }

        /// <summary>
        /// Get Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetSubscriptionAliasAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="aliasName"> AliasName is the name for the subscription creation request. Note that this is not the same as subscription name and this doesn’t have any other lifecycle need beyond the request for subscription creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="aliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SubscriptionAliasResource>> GetSubscriptionAliasAsync(this TenantResource tenantResource, string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockableSubscriptionTenantResource(tenantResource).GetSubscriptionAliasAsync(aliasName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetSubscriptionAlias(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="aliasName"> AliasName is the name for the subscription creation request. Note that this is not the same as subscription name and this doesn’t have any other lifecycle need beyond the request for subscription creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="aliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="aliasName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<SubscriptionAliasResource> GetSubscriptionAlias(this TenantResource tenantResource, string aliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableSubscriptionTenantResource(tenantResource).GetSubscriptionAlias(aliasName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a TenantPolicyResource along with the instance operations that can be performed on it in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetTenantPolicy()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> Returns a <see cref="TenantPolicyResource" /> object. </returns>
        public static TenantPolicyResource GetTenantPolicy(this TenantResource tenantResource)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableSubscriptionTenantResource(tenantResource).GetTenantPolicy();
        }

        /// <summary>
        /// Gets a collection of BillingAccountPolicyResources in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetBillingAccountPolicies()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> An object representing collection of BillingAccountPolicyResources and their operations over a BillingAccountPolicyResource. </returns>
        public static BillingAccountPolicyCollection GetBillingAccountPolicies(this TenantResource tenantResource)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableSubscriptionTenantResource(tenantResource).GetBillingAccountPolicies();
        }

        /// <summary>
        /// Get Billing Account Policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingAccount_GetPolicy</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetBillingAccountPolicyAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<BillingAccountPolicyResource>> GetBillingAccountPolicyAsync(this TenantResource tenantResource, string billingAccountId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockableSubscriptionTenantResource(tenantResource).GetBillingAccountPolicyAsync(billingAccountId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get Billing Account Policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/providers/Microsoft.Subscription/policies/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingAccount_GetPolicy</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetBillingAccountPolicy(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="billingAccountId"> Billing Account Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="billingAccountId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<BillingAccountPolicyResource> GetBillingAccountPolicy(this TenantResource tenantResource, string billingAccountId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableSubscriptionTenantResource(tenantResource).GetBillingAccountPolicy(billingAccountId, cancellationToken);
        }

        /// <summary>
        /// Accept subscription ownership.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/subscriptions/{subscriptionId}/acceptOwnership</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_AcceptOwnership</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.AcceptSubscriptionOwnership(WaitUntil,string,AcceptOwnershipContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="content"> The AcceptOwnershipContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/>, <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        public static async Task<ArmOperation> AcceptSubscriptionOwnershipAsync(this TenantResource tenantResource, WaitUntil waitUntil, string subscriptionId, AcceptOwnershipContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockableSubscriptionTenantResource(tenantResource).AcceptSubscriptionOwnershipAsync(waitUntil, subscriptionId, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Accept subscription ownership.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/subscriptions/{subscriptionId}/acceptOwnership</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_AcceptOwnership</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.AcceptSubscriptionOwnership(WaitUntil,string,AcceptOwnershipContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="content"> The AcceptOwnershipContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/>, <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        public static ArmOperation AcceptSubscriptionOwnership(this TenantResource tenantResource, WaitUntil waitUntil, string subscriptionId, AcceptOwnershipContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableSubscriptionTenantResource(tenantResource).AcceptSubscriptionOwnership(waitUntil, subscriptionId, content, cancellationToken);
        }

        /// <summary>
        /// Accept subscription ownership status.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/subscriptions/{subscriptionId}/acceptOwnershipStatus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_AcceptOwnershipStatus</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetAcceptOwnershipStatus(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="subscriptionId"/> is null. </exception>
        public static async Task<Response<AcceptOwnershipStatus>> GetAcceptOwnershipStatusAsync(this TenantResource tenantResource, string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockableSubscriptionTenantResource(tenantResource).GetAcceptOwnershipStatusAsync(subscriptionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Accept subscription ownership status.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/subscriptions/{subscriptionId}/acceptOwnershipStatus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_AcceptOwnershipStatus</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSubscriptionTenantResource.GetAcceptOwnershipStatus(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="subscriptionId"> Subscription Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="subscriptionId"/> is null. </exception>
        public static Response<AcceptOwnershipStatus> GetAcceptOwnershipStatus(this TenantResource tenantResource, string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableSubscriptionTenantResource(tenantResource).GetAcceptOwnershipStatus(subscriptionId, cancellationToken);
        }
    }
}
