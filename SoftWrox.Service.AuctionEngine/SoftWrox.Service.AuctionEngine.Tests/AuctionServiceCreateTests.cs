namespace SoftWrox.Service.AuctionEngine.Tests
{
    using System;
    using Xunit;

    /// <summary>
    /// 
    /// </summary>
    public class AuctionServiceCreateTests : AuctionServiceTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNormalAuctionCreationThrowsNoExceptions()
        {
            GivenAuctionServiceContextWithSettings(ParticipantId: 1, ApplicationId: 1);
            WhenAnAuctionIsCreatedWithSettings(BiddingMethod: BiddingMethod.Private, EndDate: DateTime.UtcNow);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNormalAuctionCreationReturnsNonZeroIdentity()
        {
            GivenAuctionServiceContextWithSettings(ParticipantId: 1, ApplicationId: 1);
            WhenAnAuctionIsCreatedWithSettings(BiddingMethod: BiddingMethod.Private, EndDate: DateTime.UtcNow);
            ThenAuctionIdentityReturnedShouldBeNonZero();
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNormalAuctionCreatesACorrespondingDatabaseEntry()
        {
            GivenAuctionServiceContextWithSettings(ParticipantId: 1, ApplicationId: 1);
            WhenAnAuctionIsCreatedWithSettings(BiddingMethod: BiddingMethod.Private, EndDate: DateTime.UtcNow);
            ThenCorrespondingRowInDatabaseShouldExist();
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNormalAuctionCreatesACorrespondingDatabaseEntryWithCorrectEndDate()
        {
            var date = DateTime.UtcNow;
            GivenAuctionServiceContextWithSettings(ParticipantId: 1, ApplicationId: 1);
            WhenAnAuctionIsCreatedWithSettings(BiddingMethod: BiddingMethod.Private, EndDate: date);
            ThenACorresponsingRowInDatabaseShouldContainEndDate(date);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNormalAuctionCreatesACorrespondingDatabaseEntryWithCorrectBiddingMethod()
        {
            GivenAuctionServiceContextWithSettings(ParticipantId: 1, ApplicationId: 1);
            WhenAnAuctionIsCreatedWithSettings(BiddingMethod: BiddingMethod.Private, EndDate: DateTime.UtcNow);
            ThenACorresponsingRowInDatabaseShouldContainBiddingMethod(BiddingMethod.Private);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNormalAuctionCreatesACorrespondingDatabaseEntryWithCorrectAuctionServiceContext()
        {
            GivenAuctionServiceContextWithSettings(ParticipantId: 1, ApplicationId: 1);
            WhenAnAuctionIsCreatedWithSettings(BiddingMethod: BiddingMethod.Private, EndDate: DateTime.UtcNow);
            ThenTheCorrespondingRowInDatabaseShouldContainDetailsOfTheCurrentAuctionServiceContext();
        }
    }
}
