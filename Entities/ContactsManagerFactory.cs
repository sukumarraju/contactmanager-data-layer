using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Contacts.Data.SqlServer.Entities;
using System.Configuration;

namespace Contacts.Data.SqlServer
{
    public class ContactsManagerFactory
    {
        private static string connectionString = string.Empty;

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        static ContactsManagerFactory()
        {
            string connectionStringName = ConfigurationManager.AppSettings.Get("ContactManagerConnectionString");
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }
        #endregion

        #region
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ContactManagerEntities CreateContext()
        {
            return new ContactManagerEntities(connectionString);
        }

        #endregion
    }
}
