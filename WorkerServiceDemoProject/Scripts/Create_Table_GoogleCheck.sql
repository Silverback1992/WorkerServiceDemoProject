USE [Testing]
GO

/****** Object:  Table [dbo].[GoogleCheck]    Script Date: 14/06/2021 23:05:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GoogleCheck](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[LogMessages] [nvarchar](max) NOT NULL,
	[LogLevel] [nchar](10) NOT NULL,
 CONSTRAINT [PK_GoogleCheck] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

