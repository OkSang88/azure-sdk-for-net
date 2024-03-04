// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppBackupVaultCollection
    {
        // BackupVaults_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_BackupVaultsList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/preview/2023-05-01-preview/examples/BackupVaults_List.json
            // this example is just showing the usage of "BackupVaults_ListByNetAppAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupVaultResource
            NetAppBackupVaultCollection collection = netAppAccount.GetNetAppBackupVaults();

            // invoke the operation and iterate over the result
            await foreach (NetAppBackupVaultResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppBackupVaultData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // BackupVaults_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BackupVaultsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/preview/2023-05-01-preview/examples/BackupVaults_Get.json
            // this example is just showing the usage of "BackupVaults_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupVaultResource
            NetAppBackupVaultCollection collection = netAppAccount.GetNetAppBackupVaults();

            // invoke the operation
            string backupVaultName = "backupVault1";
            NetAppBackupVaultResource result = await collection.GetAsync(backupVaultName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppBackupVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BackupVaults_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_BackupVaultsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/preview/2023-05-01-preview/examples/BackupVaults_Get.json
            // this example is just showing the usage of "BackupVaults_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupVaultResource
            NetAppBackupVaultCollection collection = netAppAccount.GetNetAppBackupVaults();

            // invoke the operation
            string backupVaultName = "backupVault1";
            bool result = await collection.ExistsAsync(backupVaultName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // BackupVaults_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_BackupVaultsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/preview/2023-05-01-preview/examples/BackupVaults_Get.json
            // this example is just showing the usage of "BackupVaults_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupVaultResource
            NetAppBackupVaultCollection collection = netAppAccount.GetNetAppBackupVaults();

            // invoke the operation
            string backupVaultName = "backupVault1";
            NullableResponse<NetAppBackupVaultResource> response = await collection.GetIfExistsAsync(backupVaultName);
            NetAppBackupVaultResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppBackupVaultData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // BackupVault_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_BackupVaultCreateOrUpdate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/preview/2023-05-01-preview/examples/BackupVaults_Create.json
            // this example is just showing the usage of "BackupVaults_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppAccountResource created on azure
            // for more information of creating NetAppAccountResource, please refer to the document of NetAppAccountResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            ResourceIdentifier netAppAccountResourceId = NetAppAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            NetAppAccountResource netAppAccount = client.GetNetAppAccountResource(netAppAccountResourceId);

            // get the collection of this NetAppBackupVaultResource
            NetAppBackupVaultCollection collection = netAppAccount.GetNetAppBackupVaults();

            // invoke the operation
            string backupVaultName = "backupVault1";
            NetAppBackupVaultData data = new NetAppBackupVaultData(new AzureLocation("eastus"));
            ArmOperation<NetAppBackupVaultResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, backupVaultName, data);
            NetAppBackupVaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppBackupVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
