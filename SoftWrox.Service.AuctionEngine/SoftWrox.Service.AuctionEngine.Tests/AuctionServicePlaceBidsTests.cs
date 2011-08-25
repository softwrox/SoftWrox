namespace SoftWrox.Service.AuctionEngine.Tests
{
    using System;
    using Xunit;

    class AuctionServicePlaceBidsTests : AuctionServiceTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNormalPlaceBidsThrowsNoExceptions()
        {
            GivenAuctionServiceContextWithSettings(ParticipantId: 1, ApplicationId: 1);
            WhenAnAuctionIsCreatedWithSettings(BiddingMethod: BiddingMethod.Private, EndDate: DateTime.UtcNow);
        }
    }
}
