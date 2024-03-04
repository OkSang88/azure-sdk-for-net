// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class SharePropertiesInternal
    {
        internal static SharePropertiesInternal DeserializeSharePropertiesInternal(XElement element)
        {
            DateTimeOffset lastModified = default;
            string etag = default;
            int quota = default;
            int? provisionedIops = default;
            int? provisionedIngressMBps = default;
            int? provisionedEgressMBps = default;
            int? provisionedBandwidthMiBps = default;
            DateTimeOffset? nextAllowedQuotaDowngradeTime = default;
            DateTimeOffset? deletedTime = default;
            int? remainingRetentionDays = default;
            string accessTier = default;
            DateTimeOffset? accessTierChangeTime = default;
            string accessTierTransitionState = default;
            ShareLeaseStatus? leaseStatus = default;
            ShareLeaseState? leaseState = default;
            ShareLeaseDuration? leaseDuration = default;
            string enabledProtocols = default;
            ShareRootSquash? rootSquash = default;
            if (element.Element("Last-Modified") is XElement lastModifiedElement)
            {
                lastModified = lastModifiedElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Etag") is XElement etagElement)
            {
                etag = (string)etagElement;
            }
            if (element.Element("Quota") is XElement quotaElement)
            {
                quota = (int)quotaElement;
            }
            if (element.Element("ProvisionedIops") is XElement provisionedIopsElement)
            {
                provisionedIops = (int?)provisionedIopsElement;
            }
            if (element.Element("ProvisionedIngressMBps") is XElement provisionedIngressMBpsElement)
            {
                provisionedIngressMBps = (int?)provisionedIngressMBpsElement;
            }
            if (element.Element("ProvisionedEgressMBps") is XElement provisionedEgressMBpsElement)
            {
                provisionedEgressMBps = (int?)provisionedEgressMBpsElement;
            }
            if (element.Element("ProvisionedBandwidthMiBps") is XElement provisionedBandwidthMiBpsElement)
            {
                provisionedBandwidthMiBps = (int?)provisionedBandwidthMiBpsElement;
            }
            if (element.Element("NextAllowedQuotaDowngradeTime") is XElement nextAllowedQuotaDowngradeTimeElement)
            {
                nextAllowedQuotaDowngradeTime = nextAllowedQuotaDowngradeTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("DeletedTime") is XElement deletedTimeElement)
            {
                deletedTime = deletedTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("RemainingRetentionDays") is XElement remainingRetentionDaysElement)
            {
                remainingRetentionDays = (int?)remainingRetentionDaysElement;
            }
            if (element.Element("AccessTier") is XElement accessTierElement)
            {
                accessTier = (string)accessTierElement;
            }
            if (element.Element("AccessTierChangeTime") is XElement accessTierChangeTimeElement)
            {
                accessTierChangeTime = accessTierChangeTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("AccessTierTransitionState") is XElement accessTierTransitionStateElement)
            {
                accessTierTransitionState = (string)accessTierTransitionStateElement;
            }
            if (element.Element("LeaseStatus") is XElement leaseStatusElement)
            {
                leaseStatus = leaseStatusElement.Value.ToShareLeaseStatus();
            }
            if (element.Element("LeaseState") is XElement leaseStateElement)
            {
                leaseState = leaseStateElement.Value.ToShareLeaseState();
            }
            if (element.Element("LeaseDuration") is XElement leaseDurationElement)
            {
                leaseDuration = leaseDurationElement.Value.ToShareLeaseDuration();
            }
            if (element.Element("EnabledProtocols") is XElement enabledProtocolsElement)
            {
                enabledProtocols = (string)enabledProtocolsElement;
            }
            if (element.Element("RootSquash") is XElement rootSquashElement)
            {
                rootSquash = rootSquashElement.Value.ToShareRootSquash();
            }
            return new SharePropertiesInternal(
                lastModified,
                etag,
                quota,
                provisionedIops,
                provisionedIngressMBps,
                provisionedEgressMBps,
                provisionedBandwidthMiBps,
                nextAllowedQuotaDowngradeTime,
                deletedTime,
                remainingRetentionDays,
                accessTier,
                accessTierChangeTime,
                accessTierTransitionState,
                leaseStatus,
                leaseState,
                leaseDuration,
                enabledProtocols,
                rootSquash);
        }
    }
}
