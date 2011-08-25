using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftWrox.Service.AuctionEngine
{
    class AuctionSettingsBuilder
    {
        private IAuctionServiceContext ServiceContext;

        public AuctionSettingsBuilder(IAuctionServiceContext serviceContext)
        {
            this.ServiceContext = serviceContext;
        }
        internal AuctionSettings Construct(BiddingMethod biddingMethod, DateTime endDate)
        {
            var settings = new AuctionSettings()
            {
                AuctioneerId = this.ServiceContext.ParticipantId,
                ApplicationId = this.ServiceContext.ApplicationId,
                BiddingMethod = biddingMethod,
                EndDate = endDate
            };
            return settings;
        }
    }
}
