using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Functions.ConnectDatabase
{
    public class BaseConnection
    {
        public static ConnectionStringSettings _connectionStringSettings;
        public static DbProviderFactory _factory;
        public static DbDataAdapter _dataAdapter;
        public static DbConnection _connection;

        // Connect to database
        public DbDataAdapter DataAdapter(string sqlCommand, string dbName)
        {
            try
            {
                // Get connection string
                _connectionStringSettings = ConfigurationManager.ConnectionStrings[dbName];
                // Get provider name
                _factory = DbProviderFactories.GetFactory(_connectionStringSettings.ProviderName);

                // Set up the connection
                _connection = _factory.CreateConnection();
                // Tranfer connection string type
                _connection.ConnectionString = _connectionStringSettings.ConnectionString;

                // Create adapter
                _dataAdapter = _factory.CreateDataAdapter();
                _dataAdapter.SelectCommand = _factory.CreateCommand();
                // Querying data from Sql Server
                _dataAdapter.SelectCommand.CommandText = sqlCommand;
                // Start the connection
                _dataAdapter.SelectCommand.Connection = _connection;

                // Create command builder
                var commandBuilder = _factory.CreateCommandBuilder();
                commandBuilder.DataAdapter = _dataAdapter;
            }
            catch (Exception) { }

            // Returen data adapter
            return _dataAdapter;
        }
    }
}
