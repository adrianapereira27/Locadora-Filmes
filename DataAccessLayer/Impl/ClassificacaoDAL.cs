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
    public class ClassificacaoDAL
    {
        public DbResponse Inserir(Classificacao classificacao)
        {
            DbCommand command = DbFactory.GetInstance().GetCommand();
            command.CommandText = "INSERT INTO CLASSIFICACOES (DESCRICAO,VALOR,TEMPOENTREGA) VALUES (@DESCRICAO,@VALOR,@TEMPOENTREGA)";
            command.Parameters.AddWithValue("@DESCRICAO", classificacao.Descricao);
            command.Parameters.AddWithValue("@VALOR", classificacao.Valor);
            command.Parameters.AddWithValue("@TEMPOENTREGA", classificacao.TempoEntrega);
            return new DbExecuter().Execute(command);
        }
    }
}
