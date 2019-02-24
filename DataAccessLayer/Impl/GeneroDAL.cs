using DataAccessLayer.Infrastructure;
using DataTypeObject;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Impl
{
    public class GeneroDAL
    {
        public DbResponse Inserir(Genero genero)
        {
            //Objeto que encapsula os comandos que rodarão na base de dados
            DbCommand command = DbFactory.GetInstance().GetCommand();
            //Comando SQL a ser executado
            command.CommandText = "INSERT INTO GENEROS (DESCRICAO) VALUES (@DESCRICAO)";
            
            //Adiciona os parâmetros no comando (melhora a resiliência do objeto)
            command.Parameters.AddWithValue("@DESCRICAO", genero.Descricao);
            
            return new DbExecuter().Execute(command);
        }
    }

}
