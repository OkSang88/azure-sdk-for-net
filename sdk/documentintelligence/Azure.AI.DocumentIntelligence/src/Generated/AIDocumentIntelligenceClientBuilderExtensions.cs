// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.AI.DocumentIntelligence;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="DocumentIntelligenceClient"/>, <see cref="DocumentIntelligenceAdministrationClient"/> to client builder. </summary>
    public static partial class AIDocumentIntelligenceClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="DocumentIntelligenceClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Document Intelligence service endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<DocumentIntelligenceClient, AzureAIDocumentIntelligenceClientOptions> AddDocumentIntelligenceClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<DocumentIntelligenceClient, AzureAIDocumentIntelligenceClientOptions>((options) => new DocumentIntelligenceClient(endpoint, credential, options));
        }

        /// <summary> Registers a <see cref="DocumentIntelligenceClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Document Intelligence service endpoint. </param>
        public static IAzureClientBuilder<DocumentIntelligenceClient, AzureAIDocumentIntelligenceClientOptions> AddDocumentIntelligenceClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<DocumentIntelligenceClient, AzureAIDocumentIntelligenceClientOptions>((options, cred) => new DocumentIntelligenceClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="DocumentIntelligenceAdministrationClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Document Intelligence service endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<DocumentIntelligenceAdministrationClient, AzureAIDocumentIntelligenceClientOptions> AddDocumentIntelligenceAdministrationClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<DocumentIntelligenceAdministrationClient, AzureAIDocumentIntelligenceClientOptions>((options) => new DocumentIntelligenceAdministrationClient(endpoint, credential, options));
        }

        /// <summary> Registers a <see cref="DocumentIntelligenceAdministrationClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Document Intelligence service endpoint. </param>
        public static IAzureClientBuilder<DocumentIntelligenceAdministrationClient, AzureAIDocumentIntelligenceClientOptions> AddDocumentIntelligenceAdministrationClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<DocumentIntelligenceAdministrationClient, AzureAIDocumentIntelligenceClientOptions>((options, cred) => new DocumentIntelligenceAdministrationClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="DocumentIntelligenceClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<DocumentIntelligenceClient, AzureAIDocumentIntelligenceClientOptions> AddDocumentIntelligenceClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<DocumentIntelligenceClient, AzureAIDocumentIntelligenceClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="DocumentIntelligenceAdministrationClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<DocumentIntelligenceAdministrationClient, AzureAIDocumentIntelligenceClientOptions> AddDocumentIntelligenceAdministrationClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<DocumentIntelligenceAdministrationClient, AzureAIDocumentIntelligenceClientOptions>(configuration);
        }
    }
}
