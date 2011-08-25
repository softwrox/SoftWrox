CREATE TABLE [dbo].[Bid] (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuctionId] [int] NOT NULL, 
	[BidderId] [int] NOT NULL,
	[Value] [int] NOT NULL,
) ON [PRIMARY] 
