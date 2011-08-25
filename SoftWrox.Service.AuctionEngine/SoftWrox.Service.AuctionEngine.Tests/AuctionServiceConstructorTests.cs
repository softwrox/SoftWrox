namespace SoftWrox.Service.AuctionEngine.Tests
{
    using System;
    using Xunit;

    public class AuctionServiceConstructorTests : AuctionServiceTests
    {   
        [Fact]
        public void TestNormalConstructionThrowsNoExceptions()
        {
            GivenAuctionServiceContextWithSettings(ParticipantId: 1, ApplicationId: 1);
            WhenAnAuctionServiceIsConstructed();
        }
    }
}
