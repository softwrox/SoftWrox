namespace SoftWrox.Service.AuctionEngine
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    internal class BiddingManagerFactory : AuctionServiceFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BiddingManagerFactory"/> class.
        /// </summary>
        /// <param name="serviceContext">The service context.</param>
        public BiddingManagerFactory(IAuctionServiceContext serviceContext)
            : base(serviceContext)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        public IBidManager Build(BiddingMethod method)
        {
            switch (method)
            {
                case BiddingMethod.Private:
                    return new SealedBidManager(this.ServiceContext);
                case BiddingMethod.Public:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
