// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Compute.Tests.Mock
{
    /// <summary> Test for GalleryImage. </summary>
    public partial class GalleryImageCollectionMockTests : MockTestBase
    {
        public GalleryImageCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create or update a simple gallery image.
            string galleryImageName = "myGalleryImageName";
            Compute.GalleryImageData galleryImage = new Compute.GalleryImageData(location: "West US")
            {
                OSType = Compute.Models.OperatingSystemTypes.Windows,
                OSState = Compute.Models.OperatingSystemStateTypes.Generalized,
                HyperVGeneration = new Compute.Models.HyperVGeneration("V1"),
                Identifier = new Compute.Models.GalleryImageIdentifier(publisher: "myPublisherName", offer: "myOfferName", sku: "mySkuName"),
            };

            var galleryId = Compute.Gallery.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myGalleryName");
            var collection = GetArmClient().GetGallery(galleryId).GetGalleryImages();
            await collection.CreateOrUpdateAsync(true, galleryImageName, galleryImage);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a gallery image.
            string galleryImageName = "myGalleryImageName";

            var galleryId = Compute.Gallery.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myGalleryName");
            var collection = GetArmClient().GetGallery(galleryId).GetGalleryImages();
            await collection.GetAsync(galleryImageName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List gallery images in a gallery.

            var galleryId = Compute.Gallery.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myGalleryName");
            var collection = GetArmClient().GetGallery(galleryId).GetGalleryImages();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
