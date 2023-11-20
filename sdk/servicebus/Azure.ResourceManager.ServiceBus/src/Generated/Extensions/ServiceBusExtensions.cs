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
using Azure.ResourceManager.ServiceBus.Mocking;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ServiceBus. </summary>
    public static partial class ServiceBusExtensions
    {
        private static MockableServiceBusArmClient GetMockableServiceBusArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableServiceBusArmClient(client0));
        }

        private static MockableServiceBusResourceGroupResource GetMockableServiceBusResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableServiceBusResourceGroupResource(client, resource.Id));
        }

        private static MockableServiceBusSubscriptionResource GetMockableServiceBusSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableServiceBusSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusNamespaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusNamespaceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusNamespaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusNamespaceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusNamespaceResource" /> object. </returns>
        public static ServiceBusNamespaceResource GetServiceBusNamespaceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusNamespaceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusNetworkRuleSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusNetworkRuleSetResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusNetworkRuleSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusNetworkRuleSetResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusNetworkRuleSetResource" /> object. </returns>
        public static ServiceBusNetworkRuleSetResource GetServiceBusNetworkRuleSetResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusNetworkRuleSetResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusPrivateEndpointConnectionResource" /> object. </returns>
        public static ServiceBusPrivateEndpointConnectionResource GetServiceBusPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusDisasterRecoveryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusDisasterRecoveryResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusDisasterRecoveryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusDisasterRecoveryResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusDisasterRecoveryResource" /> object. </returns>
        public static ServiceBusDisasterRecoveryResource GetServiceBusDisasterRecoveryResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusDisasterRecoveryResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MigrationConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MigrationConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="MigrationConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetMigrationConfigurationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="MigrationConfigurationResource" /> object. </returns>
        public static MigrationConfigurationResource GetMigrationConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetMigrationConfigurationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusNamespaceAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusNamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusNamespaceAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusNamespaceAuthorizationRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusNamespaceAuthorizationRuleResource" /> object. </returns>
        public static ServiceBusNamespaceAuthorizationRuleResource GetServiceBusNamespaceAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusNamespaceAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusQueueAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusQueueAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusQueueAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusQueueAuthorizationRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusQueueAuthorizationRuleResource" /> object. </returns>
        public static ServiceBusQueueAuthorizationRuleResource GetServiceBusQueueAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusQueueAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusTopicAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusTopicAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusTopicAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusTopicAuthorizationRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusTopicAuthorizationRuleResource" /> object. </returns>
        public static ServiceBusTopicAuthorizationRuleResource GetServiceBusTopicAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusTopicAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusDisasterRecoveryAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusDisasterRecoveryAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusDisasterRecoveryAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusDisasterRecoveryAuthorizationRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusDisasterRecoveryAuthorizationRuleResource" /> object. </returns>
        public static ServiceBusDisasterRecoveryAuthorizationRuleResource GetServiceBusDisasterRecoveryAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusDisasterRecoveryAuthorizationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusQueueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusQueueResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusQueueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusQueueResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusQueueResource" /> object. </returns>
        public static ServiceBusQueueResource GetServiceBusQueueResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusQueueResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusTopicResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusTopicResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusTopicResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusTopicResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusTopicResource" /> object. </returns>
        public static ServiceBusTopicResource GetServiceBusTopicResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusTopicResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusRuleResource" /> object. </returns>
        public static ServiceBusRuleResource GetServiceBusRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusSubscriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusSubscriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusArmClient.GetServiceBusSubscriptionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ServiceBusSubscriptionResource" /> object. </returns>
        public static ServiceBusSubscriptionResource GetServiceBusSubscriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceBusArmClient(client).GetServiceBusSubscriptionResource(id);
        }

        /// <summary>
        /// Gets a collection of ServiceBusNamespaceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusResourceGroupResource.GetServiceBusNamespaces()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of ServiceBusNamespaceResources and their operations over a ServiceBusNamespaceResource. </returns>
        public static ServiceBusNamespaceCollection GetServiceBusNamespaces(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableServiceBusResourceGroupResource(resourceGroupResource).GetServiceBusNamespaces();
        }

        /// <summary>
        /// Gets a description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusResourceGroupResource.GetServiceBusNamespaceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ServiceBusNamespaceResource>> GetServiceBusNamespaceAsync(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableServiceBusResourceGroupResource(resourceGroupResource).GetServiceBusNamespaceAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a description for the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusResourceGroupResource.GetServiceBusNamespace(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="namespaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ServiceBusNamespaceResource> GetServiceBusNamespace(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableServiceBusResourceGroupResource(resourceGroupResource).GetServiceBusNamespace(namespaceName, cancellationToken);
        }

        /// <summary>
        /// Gets all the available namespaces within the subscription, irrespective of the resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusSubscriptionResource.GetServiceBusNamespaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ServiceBusNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ServiceBusNamespaceResource> GetServiceBusNamespacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableServiceBusSubscriptionResource(subscriptionResource).GetServiceBusNamespacesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all the available namespaces within the subscription, irrespective of the resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusSubscriptionResource.GetServiceBusNamespaces(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ServiceBusNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ServiceBusNamespaceResource> GetServiceBusNamespaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableServiceBusSubscriptionResource(subscriptionResource).GetServiceBusNamespaces(cancellationToken);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusSubscriptionResource.CheckServiceBusNamespaceNameAvailability(ServiceBusNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<ServiceBusNameAvailabilityResult>> CheckServiceBusNamespaceNameAvailabilityAsync(this SubscriptionResource subscriptionResource, ServiceBusNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableServiceBusSubscriptionResource(subscriptionResource).CheckServiceBusNamespaceNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceBusSubscriptionResource.CheckServiceBusNamespaceNameAvailability(ServiceBusNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<ServiceBusNameAvailabilityResult> CheckServiceBusNamespaceNameAvailability(this SubscriptionResource subscriptionResource, ServiceBusNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableServiceBusSubscriptionResource(subscriptionResource).CheckServiceBusNamespaceNameAvailability(content, cancellationToken);
        }
    }
}
