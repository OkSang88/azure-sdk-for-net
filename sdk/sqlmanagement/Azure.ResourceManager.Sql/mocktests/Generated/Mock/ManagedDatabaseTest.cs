// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ManagedDatabase. </summary>
    public partial class ManagedDatabaseMockTests : MockTestBase
    {
        public ManagedDatabaseMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Gets a managed database
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Test1", "managedInstance", "managedDatabase");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);

            await managedDatabase.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete managed database
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "managedInstance", "testdb");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);

            await managedDatabase.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Updates a managed database with maximal properties
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "managedInstance", "testdb");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            Sql.Models.ManagedDatabaseUpdate parameters = new Sql.Models.ManagedDatabaseUpdate();

            await managedDatabase.UpdateAsync(true, parameters);
        }

        [RecordedTest]
        public async Task Update2()
        {
            // Example: Updates a managed database with minimal properties
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "Default-SQL-SouthEastAsia", "managedInstance", "testdb");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            Sql.Models.ManagedDatabaseUpdate parameters = new Sql.Models.ManagedDatabaseUpdate();

            await managedDatabase.UpdateAsync(true, parameters);
        }

        [RecordedTest]
        public async Task GetManagedDatabaseColumnsByDatabase()
        {
            // Example: Filter managed database columns
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "serverName", "myDatabase");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            IEnumerable<string> schema = new List<string>()
{
"dbo",};
            IEnumerable<string> table = new List<string>()
{
"customer","address",};
            IEnumerable<string> column = new List<string>()
{
"username",};
            IEnumerable<string> orderBy = new List<string>()
{
"schema asc","table","column desc",};
            string skiptoken = null;

            await foreach (var _ in managedDatabase.GetManagedDatabaseColumnsByDatabaseAsync(schema, table, column, orderBy, skiptoken))
            {
            }
        }

        [RecordedTest]
        public async Task GetManagedDatabaseColumnsByDatabase2()
        {
            // Example: List managed database columns
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "serverName", "myDatabase");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            IEnumerable<string> schema = null;
            IEnumerable<string> table = null;
            IEnumerable<string> column = null;
            IEnumerable<string> orderBy = null;
            string skiptoken = null;

            await foreach (var _ in managedDatabase.GetManagedDatabaseColumnsByDatabaseAsync(schema, table, column, orderBy, skiptoken))
            {
            }
        }

        [RecordedTest]
        public async Task GetManagedDatabaseQuery()
        {
            // Example: Obtain query properties
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sqlcrudtest-7398", "sqlcrudtest-4645", "database_1");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            string queryId = "42";

            await managedDatabase.GetManagedDatabaseQueryAsync(queryId);
        }

        [RecordedTest]
        public async Task GetQueryStatistics()
        {
            // Example: Obtain query execution statistics
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sqlcrudtest-7398", "sqlcrudtest-4645", "database_1");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            string queryId = "42";
            string startTime = null;
            string endTime = null;
            Sql.Models.QueryTimeGrainType? interval = null;

            await foreach (var _ in managedDatabase.GetQueryStatisticsAsync(queryId, startTime, endTime, interval))
            {
            }
        }

        [RecordedTest]
        public async Task GetQueryStatistics2()
        {
            // Example: Obtain query execution statistics. Example with all request parameters.
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sqlcrudtest-7398", "sqlcrudtest-4645", "database_1");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            string queryId = "42";
            string startTime = "03/01/2020 16:23:09";
            string endTime = "03/11/2020 14:00:00";
            Sql.Models.QueryTimeGrainType? interval = new Sql.Models.QueryTimeGrainType("P1D");

            await foreach (var _ in managedDatabase.GetQueryStatisticsAsync(queryId, startTime, endTime, interval))
            {
            }
        }

        [RecordedTest]
        public async Task GetQueryStatistics3()
        {
            // Example: Obtain query execution statistics. Minimal example with only mandatory request parameters.
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sqlcrudtest-7398", "sqlcrudtest-4645", "database_1");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            string queryId = "42";
            string startTime = null;
            string endTime = null;
            Sql.Models.QueryTimeGrainType? interval = new Sql.Models.QueryTimeGrainType("PT1H");

            await foreach (var _ in managedDatabase.GetQueryStatisticsAsync(queryId, startTime, endTime, interval))
            {
            }
        }

        [RecordedTest]
        public async Task CompleteRestore()
        {
            // Example: Completes a managed database external backup restore.
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "myManagedInstanceName", "myDatabase");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            Sql.Models.CompleteDatabaseRestoreDefinition parameters = new Sql.Models.CompleteDatabaseRestoreDefinition(lastBackupName: "testdb1_log4");

            await managedDatabase.CompleteRestoreAsync(true, parameters);
        }

        [RecordedTest]
        public async Task GetManagedDatabaseSecurityEventsByDatabase()
        {
            // Example: Get the managed database's security events with maximal parameters
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testcl", "database1");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            string filter = "ShowServerRecords eq true";
            int? skip = 0;
            int? top = 1;
            string skiptoken = "eyJCbG9iTmFtZURhdGVUaW1lIjoiXC9EYXRlKDE1MTIyODg4MTIwMTArMDIwMClcLyIsIkJsb2JOYW1lUm9sbG92ZXJJbmRleCI6IjAiLCJFbmREYXRlIjoiXC9EYXRlKDE1MTI0NjYyMDA1MjkpXC8iLCJJc1NraXBUb2tlblNldCI6ZmFsc2UsIklzVjJCbG9iVGltZUZvcm1hdCI6dHJ1ZSwiU2hvd1NlcnZlclJlY29yZHMiOmZhbHNlLCJTa2lwVmFsdWUiOjAsIlRha2VWYWx1ZSI6MTB9";

            await foreach (var _ in managedDatabase.GetManagedDatabaseSecurityEventsByDatabaseAsync(filter, skip, top, skiptoken))
            {
            }
        }

        [RecordedTest]
        public async Task GetManagedDatabaseSecurityEventsByDatabase2()
        {
            // Example: Get the managed database's security events with minimal parameters
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testcl", "database1");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            string filter = null;
            int? skip = null;
            int? top = null;
            string skiptoken = null;

            await foreach (var _ in managedDatabase.GetManagedDatabaseSecurityEventsByDatabaseAsync(filter, skip, top, skiptoken))
            {
            }
        }

        [RecordedTest]
        public async Task GetCurrentManagedDatabaseSensitivityLabels()
        {
            // Example: Gets the current sensitivity labels of a given database in a managed database
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "myManagedInstanceName", "myDatabase");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            string skipToken = null;
            bool? count = null;
            string filter = null;

            await foreach (var _ in managedDatabase.GetCurrentManagedDatabaseSensitivityLabelsAsync(skipToken, count, filter))
            {
            }
        }

        [RecordedTest]
        public async Task UpdateManagedDatabaseSensitivityLabel()
        {
            // Example: Update sensitivity labels of a given database using an operations batch.
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "myManagedInstanceName", "myDatabase");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            Sql.Models.SensitivityLabelUpdateList parameters = new Sql.Models.SensitivityLabelUpdateList();

            await managedDatabase.UpdateManagedDatabaseSensitivityLabelAsync(parameters);
        }

        [RecordedTest]
        public async Task GetRecommendedManagedDatabaseSensitivityLabels()
        {
            // Example: Gets the recommended sensitivity labels of a given database in a managed database
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "myManagedInstanceName", "myDatabase");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            string skipToken = null;
            bool? includeDisabledRecommendations = null;
            string filter = null;

            await foreach (var _ in managedDatabase.GetRecommendedManagedDatabaseSensitivityLabelsAsync(skipToken, includeDisabledRecommendations, filter))
            {
            }
        }

        [RecordedTest]
        public async Task UpdateRecommendedManagedDatabaseSensitivityLabel()
        {
            // Example: Update recommended sensitivity labels of a given database using an operations batch.
            var managedDatabaseId = Sql.ManagedDatabase.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myRG", "myManagedInstanceName", "myDatabase");
            var managedDatabase = GetArmClient().GetManagedDatabase(managedDatabaseId);
            Sql.Models.RecommendedSensitivityLabelUpdateList parameters = new Sql.Models.RecommendedSensitivityLabelUpdateList();

            await managedDatabase.UpdateRecommendedManagedDatabaseSensitivityLabelAsync(parameters);
        }
    }
}
