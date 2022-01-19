// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Compute.Tests.Mock
{
    /// <summary> Test for VirtualMachine. </summary>
    public partial class VirtualMachineMockTests : MockTestBase
    {
        public VirtualMachineMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a Virtual Machine.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVM");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            Compute.Models.InstanceViewTypes? expand = null;

            await virtualMachine.GetAsync(expand);
        }

        [RecordedTest]
        public async Task Get2()
        {
            // Example: Get a virtual machine placed on a dedicated host group through automatic placement
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVM");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            Compute.Models.InstanceViewTypes? expand = null;

            await virtualMachine.GetAsync(expand);
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Force delete a VM
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVM");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            bool? forceDeletion = true;

            await virtualMachine.DeleteAsync(true, forceDeletion);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Update a VM by detaching data disk
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVM");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            Compute.Models.VirtualMachineUpdate parameters = new Compute.Models.VirtualMachineUpdate()
            {
                HardwareProfile = new Compute.Models.HardwareProfile()
                {
                    VmSize = new Compute.Models.VirtualMachineSizeTypes("Standard_D2_v2"),
                },
                StorageProfile = new Compute.Models.StorageProfile()
                {
                    ImageReference = new Compute.Models.ImageReference()
                    {
                        Publisher = "MicrosoftWindowsServer",
                        Offer = "WindowsServer",
                        Sku = "2016-Datacenter",
                        Version = "latest",
                    },
                    OsDisk = new Compute.Models.OSDisk(createOption: new Compute.Models.DiskCreateOptionTypes("FromImage"))
                    {
                        Name = "myVMosdisk",
                        Caching = Compute.Models.CachingTypes.ReadWrite,
                        ManagedDisk = new Compute.Models.ManagedDiskParameters()
                        {
                            StorageAccountType = new Compute.Models.StorageAccountTypes("Standard_LRS"),
                        },
                    },
                },
                OsProfile = new Compute.Models.OSProfile()
                {
                    ComputerName = "myVM",
                    AdminUsername = "{your-username}",
                    AdminPassword = "{your-password}",
                },
                NetworkProfile = new Compute.Models.NetworkProfile(),
            };

            await virtualMachine.UpdateAsync(true, parameters);
        }

        [RecordedTest]
        public async Task Update2()
        {
            // Example: Update a VM by force-detaching data disk
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVM");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            Compute.Models.VirtualMachineUpdate parameters = new Compute.Models.VirtualMachineUpdate()
            {
                HardwareProfile = new Compute.Models.HardwareProfile()
                {
                    VmSize = new Compute.Models.VirtualMachineSizeTypes("Standard_D2_v2"),
                },
                StorageProfile = new Compute.Models.StorageProfile()
                {
                    ImageReference = new Compute.Models.ImageReference()
                    {
                        Publisher = "MicrosoftWindowsServer",
                        Offer = "WindowsServer",
                        Sku = "2016-Datacenter",
                        Version = "latest",
                    },
                    OsDisk = new Compute.Models.OSDisk(createOption: new Compute.Models.DiskCreateOptionTypes("FromImage"))
                    {
                        Name = "myVMosdisk",
                        Caching = Compute.Models.CachingTypes.ReadWrite,
                        ManagedDisk = new Compute.Models.ManagedDiskParameters()
                        {
                            StorageAccountType = new Compute.Models.StorageAccountTypes("Standard_LRS"),
                        },
                    },
                },
                OsProfile = new Compute.Models.OSProfile()
                {
                    ComputerName = "myVM",
                    AdminUsername = "{your-username}",
                    AdminPassword = "{your-password}",
                },
                NetworkProfile = new Compute.Models.NetworkProfile(),
            };

            await virtualMachine.UpdateAsync(true, parameters);
        }

        [RecordedTest]
        public async Task InstanceView()
        {
            // Example: Get Virtual Machine Instance View.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVM");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);

            await virtualMachine.InstanceViewAsync();
        }

        [RecordedTest]
        public async Task InstanceView2()
        {
            // Example: Get instance view of a virtual machine placed on a dedicated host group through automatic placement.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVM");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);

            await virtualMachine.InstanceViewAsync();
        }

        [RecordedTest]
        public async Task Generalize()
        {
            // Example: Generalize a Virtual Machine.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVMName");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);

            await virtualMachine.GeneralizeAsync();
        }

        [RecordedTest]
        public async Task GetAvailableSizes()
        {
            // Example: Lists all available virtual machine sizes to which the specified virtual machine can be resized
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVmName");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);

            await foreach (var _ in virtualMachine.GetAvailableSizesAsync())
            {
            }
        }

        [RecordedTest]
        public async Task Reapply()
        {
            // Example: Reapply the state of a virtual machine.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroup", "VMName");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);

            await virtualMachine.ReapplyAsync(true);
        }

        [RecordedTest]
        public async Task Reimage()
        {
            // Example: Reimage a Virtual Machine.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "myVMName");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            Compute.Models.VirtualMachineReimageParameters parameters = new Compute.Models.VirtualMachineReimageParameters()
            {
                TempDisk = true,
            };

            await virtualMachine.ReimageAsync(true, parameters);
        }

        [RecordedTest]
        public async Task RetrieveBootDiagnosticsData()
        {
            // Example: RetrieveBootDiagnosticsData of a virtual machine.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroup", "VMName");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            int? sasUriExpirationTimeInMinutes = 60;

            await virtualMachine.RetrieveBootDiagnosticsDataAsync(sasUriExpirationTimeInMinutes);
        }

        [RecordedTest]
        public async Task SimulateEviction()
        {
            // Example: Simulate Eviction a virtual machine.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "ResourceGroup", "VMName");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);

            await virtualMachine.SimulateEvictionAsync();
        }

        [RecordedTest]
        public async Task AssessPatches()
        {
            // Example: Assess patch state of a virtual machine.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroupName", "myVMName");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);

            await virtualMachine.AssessPatchesAsync(true);
        }

        [RecordedTest]
        public async Task InstallPatches()
        {
            // Example: Install patch state of a virtual machine.
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroupName", "myVMName");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            Compute.Models.VirtualMachineInstallPatchesParameters installPatchesInput = new Compute.Models.VirtualMachineInstallPatchesParameters(rebootSetting: new Compute.Models.VMGuestPatchRebootSetting("IfRequired"))
            {
                MaximumDuration = "PT4H",
                WindowsParameters = new Compute.Models.WindowsParameters()
                {
                    MaxPatchPublishDate = DateTimeOffset.Parse("2020-11-19T02:36:43.0539904+00:00"),
                },
            };

            await virtualMachine.InstallPatchesAsync(true, installPatchesInput);
        }

        [RecordedTest]
        public async Task RunCommand()
        {
            // Example: VirtualMachineRunCommand
            var virtualMachineId = Compute.VirtualMachine.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "crptestar98131", "vm3036");
            var virtualMachine = GetArmClient().GetVirtualMachine(virtualMachineId);
            Compute.Models.RunCommandInput parameters = new Compute.Models.RunCommandInput(commandId: "RunPowerShellScript");

            await virtualMachine.RunCommandAsync(true, parameters);
        }
    }
}
