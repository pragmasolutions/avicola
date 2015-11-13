using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace Framework.Sync
{
    public class SyncManager
    {
        private readonly string _sqllocalConnectionString;
        private readonly string _sqlazureConnectionString;
        //public static string sqlazureConnectionString = @"Server=tcp:o4n0izerd2.database.windows.net,1433;Database=Avicola.Office;User ID=maxikioscos_admin@o4n0izerd2;Password=Quilombito69;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //public static string sqllocalConnectionString = @"Data Source=.\SQL2012;Initial Catalog=Avicola.Office;Integrated Security=True";
        public static readonly string scopeName = "alltablesyncgroup";


        public SyncManager()
            : this(ConfigurationManager.AppSettings["sqllocalConnectionString"],
                   ConfigurationManager.AppSettings["sqlazureConnectionString"])
        {
        }
        
        public SyncManager(string sqllocalConnectionString, string sqlazureConnectionString)
        {
            _sqllocalConnectionString = sqllocalConnectionString;
            _sqlazureConnectionString = sqlazureConnectionString;
        }

        public void Setup(string tableNames)
        {
            if (string.IsNullOrEmpty(tableNames))
            {
                throw new ArgumentException("tableNames");
            }

            var names = tableNames.Split(',').Select(x => x.Trim());

            Setup(names);
        }

        public void Setup(IEnumerable<string> tableNames)
        {
            SqlConnection sqlServerConn = null;
            SqlConnection sqlAzureConn = null;

            try
            {
                sqlServerConn = new SqlConnection(_sqllocalConnectionString);
                sqlAzureConn = new SqlConnection(_sqlazureConnectionString);

                DbSyncScopeDescription myScope = new DbSyncScopeDescription(scopeName);

                foreach (var tableName in tableNames)
                {
                    DbSyncTableDescription tableDescription = SqlSyncDescriptionBuilder.GetDescriptionForTable(
                        tableName, sqlServerConn);
                    myScope.Tables.Add(tableDescription);
                }

                //DbSyncTableDescription Barn = SqlSyncDescriptionBuilder.GetDescriptionForTable("Barn", sqlServerConn);
                //DbSyncTableDescription Batch = SqlSyncDescriptionBuilder.GetDescriptionForTable("Batch", sqlServerConn);
                //DbSyncTableDescription BatchBarn = SqlSyncDescriptionBuilder.GetDescriptionForTable("BatchBarn", sqlServerConn);
                //DbSyncTableDescription BatchMedicine = SqlSyncDescriptionBuilder.GetDescriptionForTable("BatchMedicine", sqlServerConn);
                //DbSyncTableDescription BatchObservation = SqlSyncDescriptionBuilder.GetDescriptionForTable("BatchObservation", sqlServerConn);
                //DbSyncTableDescription BatchVaccine = SqlSyncDescriptionBuilder.GetDescriptionForTable("BatchVaccine", sqlServerConn);
                //DbSyncTableDescription DataLoadType = SqlSyncDescriptionBuilder.GetDescriptionForTable("DataLoadType", sqlServerConn);
                //DbSyncTableDescription FoodClass = SqlSyncDescriptionBuilder.GetDescriptionForTable("FoodClass", sqlServerConn);

                //DbSyncTableDescription GeneticLine = SqlSyncDescriptionBuilder.GetDescriptionForTable("GeneticLine", sqlServerConn);
                //DbSyncTableDescription Measure = SqlSyncDescriptionBuilder.GetDescriptionForTable("Measure", sqlServerConn);
                //DbSyncTableDescription Medicine = SqlSyncDescriptionBuilder.GetDescriptionForTable("Medicine", sqlServerConn);
                //DbSyncTableDescription SiloEmptying = SqlSyncDescriptionBuilder.GetDescriptionForTable("SiloEmptying", sqlServerConn);
                //DbSyncTableDescription Stage = SqlSyncDescriptionBuilder.GetDescriptionForTable("Stage", sqlServerConn);
                //DbSyncTableDescription StageChange = SqlSyncDescriptionBuilder.GetDescriptionForTable("StageChange", sqlServerConn);
                //DbSyncTableDescription Standard = SqlSyncDescriptionBuilder.GetDescriptionForTable("Standard", sqlServerConn);

                //DbSyncTableDescription StandardGeneticLine = SqlSyncDescriptionBuilder.GetDescriptionForTable("StandardGeneticLine", sqlServerConn);
                //DbSyncTableDescription StandardItem = SqlSyncDescriptionBuilder.GetDescriptionForTable("StandardItem", sqlServerConn);
                //DbSyncTableDescription StandardType = SqlSyncDescriptionBuilder.GetDescriptionForTable("StandardType", sqlServerConn);
                //DbSyncTableDescription Vaccine = SqlSyncDescriptionBuilder.GetDescriptionForTable("Vaccine", sqlServerConn);


                //// Add the tables from above to the scope
                //myScope.Tables.Add(DataLoadType); 
                //myScope.Tables.Add(FoodClass);
                //myScope.Tables.Add(GeneticLine);
                //myScope.Tables.Add(Medicine);
                //myScope.Tables.Add(Stage);
                //myScope.Tables.Add(StandardType);
                //myScope.Tables.Add(Vaccine);
                //myScope.Tables.Add(Barn);
                //myScope.Tables.Add(Batch);
                //myScope.Tables.Add(Standard);
                //myScope.Tables.Add(BatchBarn);
                //myScope.Tables.Add(BatchMedicine);
                //myScope.Tables.Add(BatchObservation);
                //myScope.Tables.Add(BatchVaccine);
                //myScope.Tables.Add(SiloEmptying);
                //myScope.Tables.Add(StageChange);
                //myScope.Tables.Add(StandardGeneticLine);
                //myScope.Tables.Add(StandardItem);
                //myScope.Tables.Add(Measure);

                // Setup SQL Server for sync
                SqlSyncScopeProvisioning sqlServerProv = new SqlSyncScopeProvisioning(sqlServerConn, myScope);
                if (!sqlServerProv.ScopeExists(scopeName))
                {
                    // Apply the scope provisioning.
                    sqlServerProv.Apply();
                }

                // Setup SQL Azure for sync
                SqlSyncScopeProvisioning sqlAzureProv = new SqlSyncScopeProvisioning(sqlAzureConn, myScope);
                if (!sqlAzureProv.ScopeExists(scopeName))
                {
                    sqlAzureProv.Apply();
                }
            }
            finally
            {
                if (sqlAzureConn != null) sqlAzureConn.Close();
                if (sqlServerConn != null) sqlServerConn.Close();
            }
        }

        public event EventHandler<SyncProgressEventArgs> ProgressChanged;

        private void OnProgressChange(SyncProgressEventArgs syncProgressEventArgs)
        {
            if (ProgressChanged != null)
            {
                ProgressChanged(this, syncProgressEventArgs);
            }
        }

        public async Task Sync()
        {
            SqlConnection sqlServerConn = null;
            SqlConnection sqlAzureConn = null;

            try
            {
                sqlServerConn = new SqlConnection(_sqllocalConnectionString);
                sqlAzureConn = new SqlConnection(_sqlazureConnectionString);
                SyncOrchestrator orch = new SyncOrchestrator
                                        {
                                            LocalProvider = new SqlSyncProvider(scopeName, sqlAzureConn),
                                            RemoteProvider = new SqlSyncProvider(scopeName, sqlServerConn),
                                            Direction = SyncDirectionOrder.UploadAndDownload
                                        };

                orch.SessionProgress += (sender, args) =>
                                        {
                                            OnProgressChange(new SyncProgressEventArgs((int) args.CompletedWork,(int) args.TotalWork));
                                        };

                await Task.Run(() => orch.Synchronize());
            }
            finally
            {
                if (sqlAzureConn != null) sqlAzureConn.Close();
                if (sqlServerConn != null) sqlServerConn.Close();
            }
        }
    }
}
