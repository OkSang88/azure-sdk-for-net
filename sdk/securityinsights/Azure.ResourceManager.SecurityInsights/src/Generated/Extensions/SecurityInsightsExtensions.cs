// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.SecurityInsights.Mocking;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.SecurityInsights. </summary>
    public static partial class SecurityInsightsExtensions
    {
        private static MockableSecurityInsightsArmClient GetMockableSecurityInsightsArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableSecurityInsightsArmClient(client0));
        }

        private static MockableSecurityInsightsResourceGroupResource GetMockableSecurityInsightsResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableSecurityInsightsResourceGroupResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsAlertRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleResource" /> object. </returns>
        public static SecurityInsightsAlertRuleResource GetSecurityInsightsAlertRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsAlertRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleActionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleActionResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleActionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsAlertRuleActionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleActionResource" /> object. </returns>
        public static SecurityInsightsAlertRuleActionResource GetSecurityInsightsAlertRuleActionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsAlertRuleActionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAlertRuleTemplateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAlertRuleTemplateResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAlertRuleTemplateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsAlertRuleTemplateResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsAlertRuleTemplateResource" /> object. </returns>
        public static SecurityInsightsAlertRuleTemplateResource GetSecurityInsightsAlertRuleTemplateResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsAlertRuleTemplateResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsAutomationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsAutomationRuleResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsAutomationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsAutomationRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsAutomationRuleResource" /> object. </returns>
        public static SecurityInsightsAutomationRuleResource GetSecurityInsightsAutomationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsAutomationRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsBookmarkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsBookmarkResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsBookmarkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsBookmarkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsBookmarkResource" /> object. </returns>
        public static SecurityInsightsBookmarkResource GetSecurityInsightsBookmarkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsBookmarkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsDataConnectorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsDataConnectorResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsDataConnectorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsDataConnectorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsDataConnectorResource" /> object. </returns>
        public static SecurityInsightsDataConnectorResource GetSecurityInsightsDataConnectorResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsDataConnectorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsIncidentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentResource" /> object. </returns>
        public static SecurityInsightsIncidentResource GetSecurityInsightsIncidentResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsIncidentResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentCommentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentCommentResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentCommentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsIncidentCommentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentCommentResource" /> object. </returns>
        public static SecurityInsightsIncidentCommentResource GetSecurityInsightsIncidentCommentResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsIncidentCommentResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsIncidentRelationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsIncidentRelationResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsIncidentRelationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsIncidentRelationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsIncidentRelationResource" /> object. </returns>
        public static SecurityInsightsIncidentRelationResource GetSecurityInsightsIncidentRelationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsIncidentRelationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsSentinelOnboardingStateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsSentinelOnboardingStateResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsSentinelOnboardingStateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsSentinelOnboardingStateResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsSentinelOnboardingStateResource" /> object. </returns>
        public static SecurityInsightsSentinelOnboardingStateResource GetSecurityInsightsSentinelOnboardingStateResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsSentinelOnboardingStateResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityMLAnalyticsSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityMLAnalyticsSettingResource.CreateResourceIdentifier" /> to create a <see cref="SecurityMLAnalyticsSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityMLAnalyticsSettingResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityMLAnalyticsSettingResource" /> object. </returns>
        public static SecurityMLAnalyticsSettingResource GetSecurityMLAnalyticsSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityMLAnalyticsSettingResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsThreatIntelligenceIndicatorResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsThreatIntelligenceIndicatorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> object. </returns>
        public static SecurityInsightsThreatIntelligenceIndicatorResource GetSecurityInsightsThreatIntelligenceIndicatorResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsThreatIntelligenceIndicatorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsWatchlistResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsWatchlistResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsWatchlistResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsWatchlistResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsWatchlistResource" /> object. </returns>
        public static SecurityInsightsWatchlistResource GetSecurityInsightsWatchlistResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsWatchlistResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SecurityInsightsWatchlistItemResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SecurityInsightsWatchlistItemResource.CreateResourceIdentifier" /> to create a <see cref="SecurityInsightsWatchlistItemResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetSecurityInsightsWatchlistItemResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="SecurityInsightsWatchlistItemResource" /> object. </returns>
        public static SecurityInsightsWatchlistItemResource GetSecurityInsightsWatchlistItemResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetSecurityInsightsWatchlistItemResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalInsightsWorkspaceSecurityInsightsResource.CreateResourceIdentifier" /> to create an <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableSecurityInsightsArmClient.GetOperationalInsightsWorkspaceSecurityInsightsResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> object. </returns>
        public static OperationalInsightsWorkspaceSecurityInsightsResource GetOperationalInsightsWorkspaceSecurityInsightsResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableSecurityInsightsArmClient(client).GetOperationalInsightsWorkspaceSecurityInsightsResource(id);
        }
    }
}
