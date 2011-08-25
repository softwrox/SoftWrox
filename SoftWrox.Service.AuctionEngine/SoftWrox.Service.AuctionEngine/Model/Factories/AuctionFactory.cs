namespace SoftWrox.Service.AuctionEngine
{
    using System;
    using System.Data.SqlClient;

    /// <summary>
    /// 
    /// </summary>
    internal class AuctionFactory : AuctionServiceFactory
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionFactory"/> class.
        /// </summary>
        /// <param name="serviceContext">The service context.</param>
        public AuctionFactory(IAuctionServiceContext serviceContext)
            : base(serviceContext)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iAuctionServiceContext">The i auction service context.</param>
        /// <param name="iAuctionSettings">The i auction settings.</param>
        /// <returns></returns>
        public Auction Build(IAuctionSettings iAuctionSettings)
        {    
            return new Auction(new BiddingManagerFactory(this.ServiceContext).Build(iAuctionSettings.BiddingMethod)) {
                AuctionerId = this.ServiceContext.ParticipantId,
                PartitionId = this.ServiceContext.ApplicationId,
                EndDate = iAuctionSettings.EndDate,
                Id = iAuctionSettings.Id
            };
        }
    }
}
