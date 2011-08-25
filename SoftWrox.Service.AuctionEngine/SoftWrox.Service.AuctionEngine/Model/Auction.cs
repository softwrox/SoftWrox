namespace SoftWrox.Service.AuctionEngine
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    internal class Auction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auction"/> class.
        /// </summary>
        /// <param name="engine">The engine.</param>
        public Auction(IBidManager engine)
        {
            this.BidEngine = engine;
        }

        /// <summary>
        /// Gets or sets the auctioner id.
        /// </summary>
        /// <value>
        /// The auctioner id.
        /// </value>
        public int AuctionerId { get; set; }

        /// <summary>
        /// Gets or sets the bid engine.
        /// </summary>
        /// <value>
        /// The bid engine.
        /// </value>
        private IBidManager BidEngine { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the partition id.
        /// </summary>
        /// <value>
        /// The partition id.
        /// </value>
        public int PartitionId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        //public object PlaceBid(int bidderId, double value)
        //{
        //    return this.BidEngine.PlaceBid(this.Id, bidderId, value);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object ViewBids()
        {
            return this.BidEngine.ViewBids();
        }
    }
}