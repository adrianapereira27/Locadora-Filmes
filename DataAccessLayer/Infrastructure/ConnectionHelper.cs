using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure
{
    internal class ConnectionHelper
    {
        private DbConnection connection;

        //Construtor (executado assim que o objeto é instanciado)
        public ConnectionHelper()
        {
            connection = DbFactory.GetInstance().GetConnection();
           
            connection.ConnectionString = 
                DbConfig.GetData(DbConfig.CONNECTION_STRING);
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void AttachCommand(DbCommand command)
        {
            command.Connection = connection;
        }

    }
}
