namespace SoftWrox.Service.AuctionEngine.Tests
{
    using System;
    using System.Linq;
    using Xunit;
    using SoftWrox.Infrastructure.ServiceLocator;
    using System.Data.SqlClient;
    using System.Configuration;

    public class AuctionServiceTests
    {
        public AuctionServiceTests()
        {
            ServiceLocator.SetLocatorProvider(new ServiceLocatorProvider());
        }

        #region Properties

        private IAuctionIdentity ReturnedAuctionIdentity { get; set; }

        private string ConnectionName { get { return "SoftWrox.Service.AuctionEngine.Database"; } }

        #endregion Properties
        
        #region Methods

        protected void GivenAuctionServiceContextWithSettings(int ParticipantId, int ApplicationId)
        {
            ServiceLocator.Current.RegisterService<IAuctionServiceContext>(() =>
            {
                return new AuctionServiceContext() { ParticipantId = ParticipantId, ApplicationId = ApplicationId };
            });
        }

        protected void WhenAnAuctionServiceIsConstructed()
        {
            var service = new AuctionService();
        }

        protected void WhenAnAuctionIsCreatedWithSettings(BiddingMethod BiddingMethod, DateTime EndDate)
        {
            var service = new AuctionService();
            this.ReturnedAuctionIdentity = service.CreateAuction(BiddingMethod, EndDate);
        }

        protected void ThenAuctionIdentityReturnedShouldBeNonZero()
        {
            Assert.True(this.ReturnedAuctionIdentity.Id > 0);
        }

        protected void ThenCorrespondingRowInDatabaseShouldExist()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[this.ConnectionName].ConnectionString))
            {
                connection.Open();
                var sql = "SELECT * FROM [AuctionSettings] WHERE Id = @Id";
                Assert.Single(SqlMapper.Query<AuctionSettings>(connection, sql, new { Id = this.ReturnedAuctionIdentity.Id }));
            }
        }

        protected void ThenACorresponsingRowInDatabaseShouldContainEndDate(DateTime endDate)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[this.ConnectionName].ConnectionString))
            {
                connection.Open();
                var sql = "SELECT * FROM [AuctionSettings] WHERE Id = @Id";
                Assert.Single(SqlMapper.Query<AuctionSettings>(connection, sql, new { Id = this.ReturnedAuctionIdentity.Id }), a => a.EndDate.ToLongDateString() == endDate.ToLongDateString());
            }
        }

        protected void ThenACorresponsingRowInDatabaseShouldContainBiddingMethod(BiddingMethod biddingMethod)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[this.ConnectionName].ConnectionString))
            {
                connection.Open();
                var sql = "SELECT * FROM [AuctionSettings] WHERE Id = @Id";
                Assert.Single(SqlMapper.Query<AuctionSettings>(connection, sql, new { Id = this.ReturnedAuctionIdentity.Id }), a => a.BiddingMethod == biddingMethod);
            }
        }

        protected void ThenTheCorrespondingRowInDatabaseShouldContainDetailsOfTheCurrentAuctionServiceContext()
        {
            var context = ServiceLocator.Current.GetInstance<IAuctionServiceContext>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[this.ConnectionName].ConnectionString))
            {
                connection.Open();
                var sql = "SELECT * FROM [AuctionSettings] WHERE Id = @Id";
                Assert.Single(SqlMapper.Query<AuctionSettings>(connection, sql, new { Id = this.ReturnedAuctionIdentity.Id }), a => a.ApplicationId == context.ApplicationId && a.AuctioneerId == context.ParticipantId);
            }
        }

        #endregion Methods
    }
}
