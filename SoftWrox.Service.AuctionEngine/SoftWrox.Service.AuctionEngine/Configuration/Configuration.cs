
namespace SoftWrox.Service.AuctionEngine
{
    internal static class Configuration
    {
        public static string ConnectionName { get { return "SoftWrox.Service.AuctionEngine.Database"; } }

        public static string AuctionSettingsTableName { get { return "AuctionSettings"; } }
        public static string AuctionSettingsPrimaryKey { get { return "Id"; } }
    }
}
