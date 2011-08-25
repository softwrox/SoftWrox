namespace SoftWrox.Service.AuctionEngine.Data
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    internal class AuctionSettingsRepository : SqlRepository<AuctionSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionSettingsRepository"/> class.
        /// </summary>
        /// <param name="conncetion">The conncetion.</param>
        public AuctionSettingsRepository()
            :base(Configuration.ConnectionName)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The id.</param>
        public override void Delete(long id)
        {
            this.Delete(where: "Id = @Id", param: new { Id = id });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="param">The param.</param>
        public override void Delete(string where, dynamic param)
        {
            var sql = string.Format("DELETE FROM [AuctionSettings] WHERE {0}", where);
            SqlMapper.Execute(this.Connection, sql, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public override AuctionSettings Find(long id)
        {
            return this.Query(where: "[Id] = @Id", param: new { Id = id }).SingleOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">The target.</param>
        public override int Insert(AuctionSettings instance)
        {
            DynamicParameters parameters = MapInstanceToInsertParameters(instance);
            var sql = "INSERT INTO [AuctionSettings] SELECT [ApplicationId] = @ApplicationId, [AuctioneerId] = @AuctioneerId, [BiddingMethod] = @BiddingMethod, [EndDate] = @EndDate; SET @Id = @@IDENTITY;";
            
            SqlMapper.Execute(this.Connection, sql, parameters);

            return parameters.Get<int>("@Id");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<AuctionSettings> Query()
        {
            return this.Connection.Query<AuctionSettings>("SELECT * FROM [AuctionSettings]");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="param">The param.</param>
        /// <returns></returns>
        public override IEnumerable<AuctionSettings> Query(string where, dynamic param)
        {
            var sql = string.Format("SELECT * FROM [AuctionSettings] WHERE {0}", where);
            return SqlMapper.Query<AuctionSettings>(this.Connection, sql, param);
        }

        /// <summary>
        /// .
        /// </summary>
        /// <param name="target">The target.</param>
        public override void Save(AuctionSettings target)
        {
            var sql = "UPDATE [AuctionSettings] SET [ApplicationId] = @ApplicationId, [AuctioneerId] = @AuctioneerId, [BiddingMethod] = @BiddingMethod, [EndDate] = @EndDate WHERE [Id] = @Id";
            SqlMapper.Execute(this.Connection, sql, target);
        }

        private DynamicParameters MapInstanceToInsertParameters(AuctionSettings instance)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ApplicationID", instance.ApplicationId);
            parameters.Add("@AuctioneerId", instance.AuctioneerId);
            parameters.Add("@BiddingMethod", instance.BiddingMethod);
            parameters.Add("@EndDate", instance.EndDate);
            parameters.Add("@Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            return parameters;
        }
    }
}
