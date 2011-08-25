using System;

namespace SoftWrox.Service.AuctionEngine
{
    class AuctionSettings : IAuctionSettings
    {

        public int AuctioneerId { get; set; }

        public BiddingMethod BiddingMethod { get; set; }

        public DateTime EndDate { get; set; }

        public int Id { get; set; }

        public int ApplicationId { get; set; }
    }
}
