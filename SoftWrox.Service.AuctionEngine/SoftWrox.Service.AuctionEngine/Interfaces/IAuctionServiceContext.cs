namespace SoftWrox.Service.AuctionEngine
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAuctionServiceContext
    {
        /// <summary>
        /// Gets or sets the participant id.
        /// </summary>
        /// <value>
        /// The participant id.
        /// </value>
        int ParticipantId { get; set; }

        /// <summary>
        /// Gets or sets the partition id.
        /// </summary>
        /// <value>
        /// The partition id.
        /// </value>
        int ApplicationId { get; set; }
    }
}
