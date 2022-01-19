// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using Insights;
using Insights.Models;

namespace Insights.Tests.Mock
{
    /// <summary> Test for AutoscaleSettingResource. </summary>
    public partial class AutoscaleSettingResourceCollectionMockTests : MockTestBase
    {
        public AutoscaleSettingResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create or update an autoscale setting
            string autoscaleSettingName = "MySetting";
            Insights.AutoscaleSettingResourceData parameters = new Insights.AutoscaleSettingResourceData(location: "West US", profiles: new List<Insights.Models.AutoscaleProfile>()
{
new Insights.Models.AutoscaleProfile(name: "adios",capacity: new Insights.Models.ScaleCapacity(minimum: "1",maximum: "10",default: "1"),rules: new List<Insights.Models.ScaleRule>()
{
new Insights.Models.ScaleRule(metricTrigger: new Insights.Models.MetricTrigger(metricName: "Percentage CPU",metricResourceUri: "/subscriptions/b67f7fec-69fc-4974-9099-a26bd6ffeda3/resourceGroups/TestingMetricsScaleSet/providers/Microsoft.Compute/virtualMachineScaleSets/testingsc",timeGrain: TimeSpan.Parse("PT1M"),statistic: Insights.Models.MetricStatisticType.Average,timeWindow: TimeSpan.Parse("PT5M"),timeAggregation: Insights.Models.TimeAggregationType.Average,operator: Insights.Models.ComparisonOperationType.GreaterThan,threshold: 10),scaleAction: new Insights.Models.ScaleAction(direction: Insights.Models.ScaleDirection.Increase,type: Insights.Models.ScaleType.ChangeCount,cooldown: TimeSpan.Parse("PT5M"))
{
Value = "1", }),new Insights.Models.ScaleRule(metricTrigger: new Insights.Models.MetricTrigger(metricName: "Percentage CPU",metricResourceUri: "/subscriptions/b67f7fec-69fc-4974-9099-a26bd6ffeda3/resourceGroups/TestingMetricsScaleSet/providers/Microsoft.Compute/virtualMachineScaleSets/testingsc",timeGrain: TimeSpan.Parse("PT2M"),statistic: Insights.Models.MetricStatisticType.Average,timeWindow: TimeSpan.Parse("PT5M"),timeAggregation: Insights.Models.TimeAggregationType.Average,operator: Insights.Models.ComparisonOperationType.GreaterThan,threshold: 15),scaleAction: new Insights.Models.ScaleAction(direction: Insights.Models.ScaleDirection.Decrease,type: Insights.Models.ScaleType.ChangeCount,cooldown: TimeSpan.Parse("PT6M"))
{
Value = "2", }),})
{
                FixedDate = new Insights.Models.TimeWindow(start: DateTimeOffset.Parse("2015-03-05T14:00:00Z"), end: DateTimeOffset.Parse("2015-03-05T14:30:00Z"))
                {
                    TimeZone = "UTC",
                }, },new Insights.Models.AutoscaleProfile(name: "saludos", capacity: new Insights.Models.ScaleCapacity(minimum: "1", maximum: "10", default: "1"), rules: new List<Insights.Models.ScaleRule>()
{
new Insights.Models.ScaleRule(metricTrigger: new Insights.Models.MetricTrigger(metricName: "Percentage CPU",metricResourceUri: "/subscriptions/b67f7fec-69fc-4974-9099-a26bd6ffeda3/resourceGroups/TestingMetricsScaleSet/providers/Microsoft.Compute/virtualMachineScaleSets/testingsc",timeGrain: TimeSpan.Parse("PT1M"),statistic: Insights.Models.MetricStatisticType.Average,timeWindow: TimeSpan.Parse("PT5M"),timeAggregation: Insights.Models.TimeAggregationType.Average,operator: Insights.Models.ComparisonOperationType.GreaterThan,threshold: 10),scaleAction: new Insights.Models.ScaleAction(direction: Insights.Models.ScaleDirection.Increase,type: Insights.Models.ScaleType.ChangeCount,cooldown: TimeSpan.Parse("PT5M"))
{
Value = "1", }),new Insights.Models.ScaleRule(metricTrigger: new Insights.Models.MetricTrigger(metricName: "Percentage CPU",metricResourceUri: "/subscriptions/b67f7fec-69fc-4974-9099-a26bd6ffeda3/resourceGroups/TestingMetricsScaleSet/providers/Microsoft.Compute/virtualMachineScaleSets/testingsc",timeGrain: TimeSpan.Parse("PT2M"),statistic: Insights.Models.MetricStatisticType.Average,timeWindow: TimeSpan.Parse("PT5M"),timeAggregation: Insights.Models.TimeAggregationType.Average,operator: Insights.Models.ComparisonOperationType.GreaterThan,threshold: 15),scaleAction: new Insights.Models.ScaleAction(direction: Insights.Models.ScaleDirection.Decrease,type: Insights.Models.ScaleType.ChangeCount,cooldown: TimeSpan.Parse("PT6M"))
{
Value = "2", }),})
            {
                Recurrence = new Insights.Models.Recurrence(frequency: Insights.Models.RecurrenceFrequency.Week, schedule: new Insights.Models.RecurrentSchedule(timeZone: "UTC", days: new List<string>()
{
"1",}, hours: new List<int>()
{
5,}, minutes: new List<int>()
{
15,})),
            },})
{
Enabled = true, TargetResourceUri = "/subscriptions/b67f7fec-69fc-4974-9099-a26bd6ffeda3/resourceGroups/TestingMetricsScaleSet/providers/Microsoft.Compute/virtualMachineScaleSets/testingsc", };
    parameters.Tags.ReplaceWith(new Dictionary<string, string>()
{
});

var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/TestingMetricsScaleSet")).GetAutoscaleSettingResources();
await collection.CreateOrUpdateAsync(true, autoscaleSettingName, parameters);
}

[RecordedTest]
public async Task Get()
{
    // Example: Get an autoscale setting
    string autoscaleSettingName = "MySetting";

    var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/TestingMetricsScaleSet")).GetAutoscaleSettingResources();
    await collection.GetAsync(autoscaleSettingName);
}

[RecordedTest]
public async Task GetAll()
{
    // Example: List autoscale settings

    var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/TestingMetricsScaleSet")).GetAutoscaleSettingResources();
    await foreach (var _ in collection.GetAllAsync())
    {
    }
}
}
}
