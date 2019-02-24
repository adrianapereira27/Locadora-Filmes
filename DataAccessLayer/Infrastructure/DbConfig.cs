using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure
{
    internal class DbConfig
    {
        private static Dictionary<string, string> configs =
                   new Dictionary<string, string>();

        public const string CURRENT_DATABASE = "CurrentDatabase";
        public const string CONNECTION_STRING = "ConnectionString";
        public const string PROVIDER_NAME = "ProviderName";

        //Lê dados do arquivo de configuração e sincroniza 
        //com o dicionario de dados
        static DbConfig()
        {
            string currentDatabase =
               ConfigurationManager.AppSettings[CURRENT_DATABASE];

            string connectionString =
            ConfigurationManager.ConnectionStrings[currentDatabase].ConnectionString;
       
            string providerName =
            ConfigurationManager.ConnectionStrings[currentDatabase].ProviderName;

            configs.Add(CURRENT_DATABASE, currentDatabase);
            configs.Add(CONNECTION_STRING, connectionString);
            configs.Add(PROVIDER_NAME, providerName);
        }

        /// <summary>
        /// Requisita algum parâmetro de configuração.
        /// Utilizar as constantes declaradas no escopo da próprio classe
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static string GetData(string config)
        {
            return configs[config];
        }

    }
}
