// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for SqlDatabase. </summary>
    public partial class SqlDatabaseCollectionMockTests : MockTestBase
    {
        public SqlDatabaseCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Creates a VCore database by specifying service objective name.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                Sku = new Sql.Models.Sku(name: "BC")
                {
                    Family = "Gen4",
                    Capacity = 2,
                },
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Creates a VCore database by specifying sku name and capacity.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                Sku = new Sql.Models.Sku(name: "BC_Gen4")
                {
                    Capacity = 2,
                },
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate3()
        {
            // Example: Creates a database as a copy.
            string databaseName = "dbcopy";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                Sku = new Sql.Models.Sku(name: "S0")
                {
                    Tier = "Standard",
                },
                CreateMode = new Sql.Models.CreateMode("Copy"),
                SourceDatabaseId = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/Default-SQL-SouthEastAsia/providers/Microsoft.Sql/servers/testsvr/databases/testdb",
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate4()
        {
            // Example: Creates a database as an on-line secondary.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                Sku = new Sql.Models.Sku(name: "S0")
                {
                    Tier = "Standard",
                },
                CreateMode = new Sql.Models.CreateMode("Secondary"),
                SourceDatabaseId = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/Default-SQL-NorthEurope/providers/Microsoft.Sql/servers/testsvr1/databases/testdb",
                SecondaryType = new Sql.Models.SecondaryType("Geo"),
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate5()
        {
            // Example: Creates a database as named replica secondary.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                Sku = new Sql.Models.Sku(name: "HS_Gen4")
                {
                    Tier = "Hyperscale",
                    Capacity = 2,
                },
                CreateMode = new Sql.Models.CreateMode("Secondary"),
                SourceDatabaseId = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/Default-SQL-NorthEurope/providers/Microsoft.Sql/servers/testsvr1/databases/primarydb",
                SecondaryType = new Sql.Models.SecondaryType("Named"),
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate6()
        {
            // Example: Creates a database from PointInTimeRestore.
            string databaseName = "dbpitr";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                CreateMode = new Sql.Models.CreateMode("PointInTimeRestore"),
                SourceDatabaseId = "/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/Default-SQL-SoutheastAsia/providers/Microsoft.Sql/servers/testsvr/databases/testdb",
                RestorePointInTime = DateTimeOffset.Parse("2020-10-22T05:35:31.503Z"),
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate7()
        {
            // Example: Creates a database with default mode.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                Sku = new Sql.Models.Sku(name: "S0")
                {
                    Tier = "Standard",
                },
                CreateMode = new Sql.Models.CreateMode("Default"),
                Collation = "SQL_Latin1_General_CP1_CI_AS",
                MaxSizeBytes = 1073741824,
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate8()
        {
            // Example: Creates a database with ledger on.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                IsLedgerOn = true,
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate9()
        {
            // Example: Creates a database with minimum number of parameters.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia");

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate10()
        {
            // Example: Creates a database with preferred maintenance window.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                Sku = new Sql.Models.Sku(name: "S2")
                {
                    Tier = "Standard",
                },
                CreateMode = new Sql.Models.CreateMode("Default"),
                Collation = "SQL_Latin1_General_CP1_CI_AS",
                MaxSizeBytes = 1073741824,
                MaintenanceConfigurationId = "/subscriptions/00000000-1111-2222-3333-444444444444/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/SQL_SouthEastAsia_1",
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate11()
        {
            // Example: Creates a database with specified backup storage redundancy.
            string databaseName = "testdb";
            Sql.SqlDatabaseData parameters = new Sql.SqlDatabaseData(location: "southeastasia")
            {
                RequestedBackupStorageRedundancy = new Sql.Models.RequestedBackupStorageRedundancy("Zone"),
            };

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.CreateOrUpdateAsync(true, databaseName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Gets a database.
            string databaseName = "testdb";

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await collection.GetAsync(databaseName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Gets a list of databases.
            string skipToken = null;

            var sqlServerId = Sql.SqlServer.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "testsvr");
            var collection = GetArmClient().GetSqlServer(sqlServerId).GetSqlDatabases();
            await foreach (var _ in collection.GetAllAsync(skipToken))
            {
            }
        }
    }
}
