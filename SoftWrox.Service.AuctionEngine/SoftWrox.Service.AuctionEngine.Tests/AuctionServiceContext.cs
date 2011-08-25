namespace SoftWrox.Service.AuctionEngine.Tests
{
    public class AuctionServiceContext : IAuctionServiceContext
    {
        public int ApplicationId { get; set; }
        public int ParticipantId { get; set; }
    }
}
