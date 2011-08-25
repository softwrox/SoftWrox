namespace SoftWrox.Service.AuctionEngine
{
    using System;
    using System.Collections.Generic;
    using SoftWrox.Infrastructure.ServiceLocator;

    /// <summary>
    /// 
    /// </summary>
    public class AuctionService
    { 
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionService"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AuctionService()
        {
            this.ServiceContext = ServiceLocator.Current.GetInstance<IAuctionServiceContext>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// The service context.
        /// </value>
        private IAuctionServiceContext ServiceContext { get; set; }

        #endregion Properties

        #region Methods

        #region Auction Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns></returns>
        public IAuctionIdentity CreateAuction(BiddingMethod biddingMethod, DateTime endDate)
        {
            var manager = new AuctionSettingsManager(this.ServiceContext);
            return manager.Create(biddingMethod, endDate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">The context.</param>
        public void DeleteAuction(IAuctionIdentity context)
        {
            var manager = new AuctionSettingsManager(this.ServiceContext);
            manager.Delete(context);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public IAuctionSettings ReadAuction(IAuctionIdentity context)
        {
            var manager = new AuctionSettingsManager(this.ServiceContext);
            return manager.Read(context);
        }

        /// <summary>
        /// Updates the auction.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void UpdateAuction(DateTime endDate)
        {
            //var manager = new AuctionSettingsManager(this.ServiceContext);
            //manager.Update(settings);
        }

        #endregion Auction Methods

        #region Bid Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public IBidIdentity PlaceBid(IAuctionIdentity context, double value)
        {
            return (IBidIdentity)null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public IEnumerable<IBidSettings> ViewBids(IAuctionIdentity context)
        {
            return new IBidSettings[0];
        }

        #endregion Bid Methods

        #endregion Methods
    }
}
