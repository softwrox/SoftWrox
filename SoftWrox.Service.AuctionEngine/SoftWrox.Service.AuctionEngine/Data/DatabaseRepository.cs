namespace SoftWrox.Service.AuctionEngine.Data
{
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal abstract class DatabaseRepository<T> : IRepository<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseRepository&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        public DatabaseRepository(IDbConnection connection)
        {
            this.Connection = connection;
            this.Connection.Open();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        protected IDbConnection Connection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The id.</param>
        public abstract void Delete(long id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="param">The param.</param>
        public abstract void Delete(string where, dynamic param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public abstract T Find(long id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">The target.</param>
        public abstract int Insert(T target);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<T> Query();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="param">The param.</param>
        /// <returns></returns>
        public abstract IEnumerable<T> Query(string where, dynamic param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">The target.</param>
        public abstract void Save(T target);
    }
}
