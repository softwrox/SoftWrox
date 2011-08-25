namespace SoftWrox.Service.AuctionEngine
{
    /// <summary>
    /// 
    /// </summary>
    internal interface IBidManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        object PlaceBid(int auctionId, int bidderId, double value);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        object ViewBids();
    }
}
