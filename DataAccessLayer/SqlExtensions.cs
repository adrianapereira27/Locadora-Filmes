using DataAccessLayer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static class SqlExtensions
    {
        //Método que faz com que possamos adicionar parâmetros
        //ao objeto DbCommand de forma tão eficaz quanto o SqlCommand
        public static void AddWithValue(this DbParameterCollection parameters, 
                                             string parameterName, 
                                             object value)
        {
            //Cria o parâmetro do objeto SQL correto
            DbParameter parameter =
            DbFactory.GetInstance().GetCommand().CreateParameter();

            //Configura-o a ter nome e valor
            parameter.ParameterName = parameterName;
            parameter.Value = value;

            //Adiciona na lista de parâmetros
            parameters.Add(parameter);
        }

    }
}
