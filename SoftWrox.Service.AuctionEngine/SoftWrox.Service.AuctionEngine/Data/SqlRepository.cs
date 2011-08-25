namespace SoftWrox.Service.AuctionEngine.Data
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
using System.Configuration;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal abstract class SqlRepository<T> : DatabaseRepository<T>
    {
        public SqlRepository(string connectionName)
            :base(new SqlConnection(ConfigurationManager.ConnectionStrings[connectionName].ConnectionString))
        { }
    }
}
