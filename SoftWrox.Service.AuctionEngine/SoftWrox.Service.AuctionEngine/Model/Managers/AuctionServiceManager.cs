namespace SoftWrox.Service.AuctionEngine
{
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    internal abstract class AuctionServiceManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BidManager"/> class.
        /// </summary>
        /// <param name="serviceContext">The context.</param>
        public AuctionServiceManager(IAuctionServiceContext serviceContext)
        {
            this.ServiceContext = serviceContext;
        }

        protected IAuctionServiceContext ServiceContext { get; set; }

        protected IDbConnection Connection { get; set; }
    }  
}
