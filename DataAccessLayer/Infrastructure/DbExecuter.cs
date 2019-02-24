using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure
{
    internal class DbExecuter
    {
        private ConnectionHelper connection = new ConnectionHelper();

        public DbResponse Execute(DbCommand command)
        {
            DbResponse response = new DbResponse();
            connection.AttachCommand(command);
            try
            {
                connection.OpenConnection();
                response.RowsAffected = command.ExecuteNonQuery();
                response.Success = true;
                response.Message = "Operação realizada com sucesso!";
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            finally
            {
                connection.CloseConnection();
            }
            return response;
        }
    }
}
