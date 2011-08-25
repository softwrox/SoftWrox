namespace SoftWrox.Service.AuctionEngine
{    
    /// <summary>
    /// 
    /// </summary>
    internal class SealedBidManager : AuctionServiceManager, IBidManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SealedBidManager"/> class.
        /// </summary>
        /// <param name="serviceContext">The context.</param>
        public SealedBidManager(IAuctionServiceContext serviceContext)
            : base(serviceContext)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public object PlaceBid(int auctionId, int bidderId, double value)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object ViewBids()
        {
            throw new System.NotImplementedException();
        }
    }
}
