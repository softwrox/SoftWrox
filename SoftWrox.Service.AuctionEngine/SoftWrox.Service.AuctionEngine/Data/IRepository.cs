namespace SoftWrox.Service.AuctionEngine.Data
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IRepository<T>
    {
        /// <summary>
        /// Summary : 
        /// </summary>
        /// <param name="id">The id.</param>
        void Delete(long id);

        /// <summary>
        /// Summary : 
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="param">The param.</param>
        void Delete(string where, dynamic param);

        /// <summary>
        /// Summary : 
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        T Find(long id);

        /// <summary>
        /// Summary : 
        /// </summary>
        /// <param name="target">The target.</param>
        int Insert(T target);

        /// <summary>
        /// Summary : 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Query();

        /// <summary>
        /// Summary : 
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="param">The param.</param>
        /// <returns></returns>
        IEnumerable<T> Query(string where, dynamic param);

        /// <summary>
        /// Summary : 
        /// </summary>
        /// <param name="target">The target.</param>
        void Save(T target);
    }
}
