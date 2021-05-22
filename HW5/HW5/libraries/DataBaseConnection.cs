using System.Configuration;
using System.Data;
using System.Data.Common;

namespace HW5.libraries
{
    class DataBaseConnection
    {
        
        private static string database_connection_String;
        private static string database_provider;



        static DataBaseConnection()
        {

            database_connection_String = ConfigurationManager.ConnectionStrings["HW5connectionStrings"].ConnectionString;
            database_provider = ConfigurationManager.ConnectionStrings["HW5connectionStrings"].ProviderName;
        }

        public static DbCommand getConnection()
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(database_provider);

            DbConnection connection = factory.CreateConnection();

            connection.ConnectionString = database_connection_String;

            return connection.CreateCommand();
        }

    }
}
