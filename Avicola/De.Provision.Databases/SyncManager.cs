using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Logging;
using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;

namespace De.Provision.Databases
{
    public class SyncManager
    {
        private readonly string _sqllocalConnectionString;
        private readonly string _sqlazureConnectionString;
        
        public SyncManager()
        {
        }

        public SyncManager(string sqllocalConnectionString, string sqlazureConnectionString)
        {
            _sqllocalConnectionString = sqllocalConnectionString;
            _sqlazureConnectionString = sqlazureConnectionString;
        }

        public void Deprovision(string scopeName)
        {
            SqlConnection sqlServerConn = null;
            SqlConnection sqlAzureConn = null;
            try
            {
                sqlServerConn = new SqlConnection(_sqllocalConnectionString);
                sqlAzureConn = new SqlConnection(_sqlazureConnectionString);
                DbSyncScopeDescription myScope = new DbSyncScopeDescription(scopeName);
                SqlSyncScopeDeprovisioning sqlServerProv = new SqlSyncScopeDeprovisioning(sqlServerConn);
                SqlSyncScopeDeprovisioning sqlAzureProv = new SqlSyncScopeDeprovisioning(sqlAzureConn);
                sqlServerProv.DeprovisionScope(scopeName);
                sqlAzureProv.DeprovisionScope(scopeName);
            }
            finally
            {
                if (sqlServerConn != null) sqlServerConn.Close();
                if (sqlAzureConn != null) sqlAzureConn.Close();
            }
            
        }

        public void Setup(string tableNames, string scopeName)
        {
            if (string.IsNullOrEmpty(tableNames))
            {
                throw new ArgumentException("tableNames");
            }

            var names = tableNames.Split(',').Select(x => x.Trim());

            Setup(names, scopeName);
        }

        public void Setup(IEnumerable<string> tableNames, string scopeName)
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

                // Setup SQL Server for sync
                SqlSyncScopeProvisioning sqlServerProv = new SqlSyncScopeProvisioning(sqlServerConn, myScope);
                if (!sqlServerProv.ScopeExists(scopeName))
                {
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

        public async Task Sync(string scopeName)
        {
            SqlConnection sqlServerConn = null;
            SqlConnection sqlAzureConn = null;
            
            try
            {
                sqlServerConn = new SqlConnection(_sqllocalConnectionString);
                sqlAzureConn = new SqlConnection(_sqlazureConnectionString);
                SyncOrchestrator orch = new SyncOrchestrator
                                        {
                                            LocalProvider = new SqlSyncProvider(scopeName, sqlServerConn, null, "DataSync"),
                                            RemoteProvider = new SqlSyncProvider(scopeName, sqlAzureConn, null, "DataSync"),
                                            Direction = SyncDirectionOrder.UploadAndDownload
                                        };

                ((SqlSyncProvider)orch.LocalProvider).ApplyChangeFailed +=
                    new EventHandler<DbApplyChangeFailedEventArgs>(Program_ApplyChangeFailed);
                ((SqlSyncProvider)orch.RemoteProvider).ApplyChangeFailed +=
                    new EventHandler<DbApplyChangeFailedEventArgs>(Program_ApplyChangeFailed);

                orch.SessionProgress += (sender, args) =>
                                        {
                                            OnProgressChange(new SyncProgressEventArgs((int) args.CompletedWork,
                                                (int) args.TotalWork));
                                        };
              
                var stat = await Task.Run(() => orch.Synchronize());

                LogStatistics(stat);
            }
            finally
            {
                if (sqlAzureConn != null) sqlAzureConn.Close();
                if (sqlServerConn != null) sqlServerConn.Close();
            }
        }

        public void Program_ApplyChangeFailed(object sender, DbApplyChangeFailedEventArgs e)
        {
            // display conflict type
            Console.WriteLine(e.Conflict.Type);

            // display error message 
            Console.WriteLine(e.Error);
        }

        public void LogStatistics(SyncOperationStatistics syncStats)
        {
            string message;

            //message = "\tSync Start Time :" + syncStats.SyncStartTime.ToString();
            //_logger.Log(message);
            //message = "\tSync End Time   :" + syncStats.SyncEndTime.ToString();
            //_logger.Log(message);
            //message = "\tUpload Changes Applied :" + syncStats.UploadChangesApplied.ToString();
            //_logger.Log(message);
            //message = "\tUpload Changes Failed  :" + syncStats.UploadChangesFailed.ToString();
            //_logger.Log(message);
            //message = "\tUpload Changes Total   :" + syncStats.UploadChangesTotal.ToString();
            //_logger.Log(message);
            //message = "\tDownload Changes Applied :" + syncStats.DownloadChangesApplied.ToString();
            //_logger.Log(message);
            //message = "\tDownload Changes Failed  :" + syncStats.DownloadChangesFailed.ToString();
            //_logger.Log(message);
            //message = "\tDownload Changes Total   :" + syncStats.DownloadChangesTotal.ToString();
            //_logger.Log(message);
        }
    }
}
