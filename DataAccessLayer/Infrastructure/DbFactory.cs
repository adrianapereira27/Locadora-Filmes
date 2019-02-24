using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure
{
    internal class DbFactory
    {
        #region Singleton
        private string providerName;
        private DbProviderFactory providerFactory;
        private static DbFactory factory = null;
        
        private DbFactory()
        {
            providerName = DbConfig.GetData(DbConfig.PROVIDER_NAME);
            providerFactory = DbProviderFactories.GetFactory(providerName);
        }

        public static DbFactory GetInstance()
        {
            if(factory == null)
            {
                factory = new DbFactory();
            }
            return factory;
        }
        #endregion

        public DbCommand GetCommand()
        {
           return providerFactory.CreateCommand();
        }

        public DbConnection GetConnection()
        {
            return providerFactory.CreateConnection();
        }

    }
}
