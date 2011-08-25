namespace SoftWrox.Service.AuctionEngine
{
    using System;
    using SoftWrox.Service.AuctionEngine.Data;

    /// <summary>
    /// 
    /// </summary>
    public interface IAuctionSettings
    {
        /// <summary>
        /// Gets or sets the partition id.
        /// </summary>
        /// <value>
        /// The partition id.
        /// </value>
        int ApplicationId { get; set; }
        
        /// <summary>
        /// Gets or sets the auctioneer id.
        /// </summary>
        /// <value>
        /// The auctioneer id.
        /// </value>
        int AuctioneerId { get; set; }
            
        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// The bidding method.
        /// </value>
        BiddingMethod BiddingMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        DateTime EndDate { get; set; }

        int Id { get; set; }
    }
}
