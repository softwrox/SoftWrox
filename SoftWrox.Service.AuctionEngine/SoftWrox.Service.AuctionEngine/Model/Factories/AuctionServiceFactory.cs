namespace SoftWrox.Service.AuctionEngine
{
    /// <summary>
    /// 
    /// </summary>
    internal abstract class AuctionServiceFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionServiceFactory"/> class.
        /// </summary>
        /// <param name="serviceContext">The service context.</param>
        public AuctionServiceFactory(IAuctionServiceContext serviceContext)
        {
            this.ServiceContext = serviceContext;
        }

        protected IAuctionServiceContext ServiceContext { get; set; }
    }
}
