CREATE TABLE [dbo].[AuctionSettings] (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationId] [int] NOT NULL,
	[AuctioneerId] [int] NOT NULL,
	[BiddingMethod] [int] NOT NULL,
	[EndDate] [DateTime] NOT NULL
) ON [PRIMARY] 
