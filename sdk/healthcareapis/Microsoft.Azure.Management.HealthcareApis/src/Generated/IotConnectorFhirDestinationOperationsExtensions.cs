// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IotConnectorFhirDestinationOperations.
    /// </summary>
    public static partial class IotConnectorFhirDestinationOperationsExtensions
    {
            /// <summary>
            /// Gets the properties of the specified Iot Connector FHIR destination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            public static IotFhirDestination Get(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified Iot Connector FHIR destination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotFhirDestination> GetAsync(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an IoT Connector FHIR destination resource with the
            /// specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            /// <param name='iotFhirDestination'>
            /// The parameters for creating or updating an IoT Connector FHIR destination
            /// resource.
            /// </param>
            public static IotFhirDestination CreateOrUpdate(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName, IotFhirDestination iotFhirDestination)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName, iotFhirDestination).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an IoT Connector FHIR destination resource with the
            /// specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            /// <param name='iotFhirDestination'>
            /// The parameters for creating or updating an IoT Connector FHIR destination
            /// resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotFhirDestination> CreateOrUpdateAsync(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName, IotFhirDestination iotFhirDestination, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName, iotFhirDestination, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an IoT Connector FHIR destination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            public static void Delete(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an IoT Connector FHIR destination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates an IoT Connector FHIR destination resource with the
            /// specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            /// <param name='iotFhirDestination'>
            /// The parameters for creating or updating an IoT Connector FHIR destination
            /// resource.
            /// </param>
            public static IotFhirDestination BeginCreateOrUpdate(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName, IotFhirDestination iotFhirDestination)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName, iotFhirDestination).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an IoT Connector FHIR destination resource with the
            /// specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            /// <param name='iotFhirDestination'>
            /// The parameters for creating or updating an IoT Connector FHIR destination
            /// resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotFhirDestination> BeginCreateOrUpdateAsync(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName, IotFhirDestination iotFhirDestination, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName, iotFhirDestination, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an IoT Connector FHIR destination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            public static void BeginDelete(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an IoT Connector FHIR destination.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the service instance.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of workspace resource.
            /// </param>
            /// <param name='iotConnectorName'>
            /// The name of IoT Connector resource.
            /// </param>
            /// <param name='fhirDestinationName'>
            /// The name of IoT Connector FHIR destination resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IIotConnectorFhirDestinationOperations operations, string resourceGroupName, string workspaceName, string iotConnectorName, string fhirDestinationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, iotConnectorName, fhirDestinationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
