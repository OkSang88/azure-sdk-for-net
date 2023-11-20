﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.DocumentIntelligence.Tests
{
    public class DocumentClassifierAdministrationLiveTests : DocumentIntelligenceLiveTestBase
    {
        public DocumentClassifierAdministrationLiveTests(bool isAsync)
            : base(isAsync)
        {
        }

        #region Build

        [RecordedTest]
        public async Task BuildClassifierWithAzureBlobContentSource()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var classifierId = Recording.GenerateId();
            var description = "This classifier was generated by a .NET test.";
            var startTime = Recording.UtcNow;

            var containerUrl = new Uri(TestEnvironment.ClassifierTrainingSasUrl);
            var sourceA = new AzureBlobContentSource(containerUrl) { Prefix = "IRS-1040-A/train" };
            var sourceB = new AzureBlobContentSource(containerUrl) { Prefix = "IRS-1040-B/train" };
            var docTypeA = new ClassifierDocumentTypeDetails() { AzureBlobSource = sourceA };
            var docTypeB = new ClassifierDocumentTypeDetails() { AzureBlobSource = sourceB };
            var docTypes = new Dictionary<string, ClassifierDocumentTypeDetails>()
            {
                { "IRS-1040-A", docTypeA },
                { "IRS-1040-B", docTypeB }
            };

            var content = new BuildDocumentClassifierContent(classifierId, docTypes)
            {
                Description = description
            };

            Operation<DocumentClassifierDetails> operation = null;

            try
            {
                operation = await client.BuildClassifierAsync(WaitUntil.Completed, content);
            }
            finally
            {
                if (operation != null && operation.HasCompleted)
                {
                    await client.DeleteClassifierAsync(classifierId);
                }
            }

            Assert.That(operation.HasCompleted);
            Assert.That(operation.HasValue);

            DocumentClassifierDetails classifier = operation.Value;

            Assert.That(classifier.ClassifierId, Is.EqualTo(classifierId));
            Assert.That(classifier.Description, Is.EqualTo(description));
            Assert.That(classifier.ApiVersion, Is.EqualTo(ServiceVersionString));
            Assert.That(classifier.CreatedDateTime, Is.GreaterThan(startTime));
            Assert.That(classifier.ExpirationDateTime, Is.GreaterThan(classifier.CreatedDateTime));

            DocumentAssert.AreEquivalent(docTypes, classifier.DocTypes);

            foreach (var docType in classifier.DocTypes.Values)
            {
                Assert.That(docType.SourceKind, Is.Null);
            }
        }

        [RecordedTest]
        public async Task BuildClassifierWithAzureBlobFileListContentSource()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var classifierId = Recording.GenerateId();
            var description = "This classifier was generated by a .NET test.";
            var startTime = Recording.UtcNow;

            var containerUrl = new Uri(TestEnvironment.ClassifierTrainingSasUrl);
            var sourceA = new AzureBlobFileListContentSource(containerUrl, "IRS-1040-A.jsonl");
            var sourceB = new AzureBlobFileListContentSource(containerUrl, "IRS-1040-B.jsonl");
            var docTypeA = new ClassifierDocumentTypeDetails() { AzureBlobFileListSource = sourceA };
            var docTypeB = new ClassifierDocumentTypeDetails() { AzureBlobFileListSource = sourceB };
            var docTypes = new Dictionary<string, ClassifierDocumentTypeDetails>()
            {
                { "IRS-1040-A", docTypeA },
                { "IRS-1040-B", docTypeB }
            };

            var content = new BuildDocumentClassifierContent(classifierId, docTypes)
            {
                Description = description
            };

            Operation<DocumentClassifierDetails> operation = null;

            try
            {
                operation = await client.BuildClassifierAsync(WaitUntil.Completed, content);
            }
            finally
            {
                if (operation != null && operation.HasCompleted)
                {
                    await client.DeleteClassifierAsync(classifierId);
                }
            }

            Assert.That(operation.HasCompleted);
            Assert.That(operation.HasValue);

            DocumentClassifierDetails classifier = operation.Value;

            Assert.That(classifier.ClassifierId, Is.EqualTo(classifierId));
            Assert.That(classifier.Description, Is.EqualTo(description));
            Assert.That(classifier.ApiVersion, Is.EqualTo(ServiceVersionString));
            Assert.That(classifier.CreatedDateTime, Is.GreaterThan(startTime));
            Assert.That(classifier.ExpirationDateTime, Is.GreaterThan(classifier.CreatedDateTime));

            DocumentAssert.AreEquivalent(docTypes, classifier.DocTypes);

            foreach (var docType in classifier.DocTypes.Values)
            {
                Assert.That(docType.SourceKind, Is.Null);
            }
        }

        #endregion Build

        #region Get

        [RecordedTest]
        public async Task GetClassifier()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var description = "This classifier was generated by a .NET test.";

            await using var disposableClassifier = await BuildDisposableDocumentClassifierAsync(description);

            DocumentClassifierDetails expected = disposableClassifier.Value;
            DocumentClassifierDetails classifier = await client.GetClassifierAsync(disposableClassifier.ClassifierId);

            DocumentAssert.AreEqual(expected, classifier);
        }

        [RecordedTest]
        public void GetClassifierCanParseError()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var classifierId = "00000000-0000-0000-0000-000000000000";

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () => await client.GetClassifierAsync(classifierId));

            Assert.That(ex.ErrorCode, Is.EqualTo("NotFound"));
        }

        #endregion

        #region List

        [RecordedTest]
        public async Task GetClassifiers()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var description = "This classifier was generated by a .NET test.";

            await using var disposableClassifier0 = await BuildDisposableDocumentClassifierAsync(description);
            await using var disposableClassifier1 = await BuildDisposableDocumentClassifierAsync(description);

            var expectedIdMapping = new Dictionary<string, DocumentClassifierDetails>()
            {
                { disposableClassifier0.ClassifierId, disposableClassifier0.Value },
                { disposableClassifier1.ClassifierId, disposableClassifier1.Value }
            };
            var idMapping = new Dictionary<string, DocumentClassifierDetails>();

            await foreach (DocumentClassifierDetails classifier in client.GetClassifiersAsync())
            {
                if (expectedIdMapping.ContainsKey(classifier.ClassifierId))
                {
                    idMapping.Add(classifier.ClassifierId, classifier);
                }

                if (idMapping.Count == expectedIdMapping.Count)
                {
                    break;
                }
            }

            Assert.That(idMapping.Count, Is.EqualTo(expectedIdMapping.Count));

            foreach (string id in expectedIdMapping.Keys)
            {
                Assert.That(idMapping, Contains.Key(id));

                DocumentClassifierDetails expected = expectedIdMapping[id];
                DocumentClassifierDetails classifier = idMapping[id];

                DocumentAssert.AreEqual(expected, classifier);
            }
        }

        #endregion List

        #region Delete

        [RecordedTest]
        public async Task DeleteClassifier()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();

            var disposableClassifier = await BuildDisposableDocumentClassifierAsync();
            var response = await client.DeleteClassifierAsync(disposableClassifier.ClassifierId);

            Assert.That(response.Status, Is.EqualTo((int)HttpStatusCode.NoContent));
        }

        [RecordedTest]
        public void DeleteClassifierCanParseError()
        {
            var client = CreateDocumentIntelligenceAdministrationClient();
            var classifierId = "00000000-0000-0000-0000-000000000000";

            RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () => await client.DeleteClassifierAsync(classifierId));

            Assert.That(ex.ErrorCode, Is.EqualTo("NotFound"));
        }

        #endregion Delete
    }
}
