namespace SoftWrox.Service.AuctionEngine
{
    using System;
    using SoftWrox.Service.AuctionEngine.Data;

    internal class AuctionSettingsManager : AuctionServiceManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuctionSettingsManager"/> class.
        /// </summary>
        /// <param name="serviceContext">The service context.</param>
        public AuctionSettingsManager(IAuctionServiceContext serviceContext)
            : base(serviceContext)
        { }

        /// <summary>
        /// Gets the auction settings table.
        /// </summary>
        private DynamicModel AuctionSettingsTable 
        {
            get { return new DynamicModel(Configuration.ConnectionName, Configuration.AuctionSettingsTableName, Configuration.AuctionSettingsPrimaryKey); } 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="biddingMethod">The bidding method.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public AuctionIdentity Create(BiddingMethod biddingMethod, DateTime endDate)
        {
            var settings = new AuctionSettingsBuilder(this.ServiceContext).Construct(biddingMethod, endDate);
            var value = new AuctionSettingsRepository().Insert(settings);
            return new AuctionIdentity() { Id = value };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">The context.</param>
        public void Delete(IAuctionIdentity context)
        {
            AuctionSettingsTable.Delete(context.Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public IAuctionSettings Read(IAuctionIdentity context)
        {
            var instance = AuctionSettingsTable.Single(context.Id);
            return MapDynamicToAuctionSettings(instance);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void Update(IAuctionSettings settings)
        {
            AuctionSettingsTable.Update(settings, settings.Id);
        }

        private IAuctionSettings MapDynamicToAuctionSettings(dynamic instance)
        {
            return new AuctionSettings() {  AuctioneerId = this.ServiceContext.ParticipantId,
                                            ApplicationId = this.ServiceContext.ApplicationId,
                                            BiddingMethod = (BiddingMethod)instance.BiddingMethod,
                                            EndDate = instance.EndDate,
                                            Id = instance.Id };
        }
    }
}
