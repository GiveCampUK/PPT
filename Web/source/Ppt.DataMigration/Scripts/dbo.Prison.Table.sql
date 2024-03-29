/****** Object:  Table [dbo].[Prison]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prison](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[MailName] [nvarchar](255) NULL,
	[Address1] [nvarchar](255) NULL,
	[Address2] [nvarchar](255) NULL,
	[Address3] [nvarchar](255) NULL,
	[Town] [nvarchar](255) NULL,
	[County] [nvarchar](255) NULL,
	[Postcode] [nvarchar](255) NULL,
	[Country] [int] NULL,
	[Sex] [int] NOT NULL,
	[MalePrisonersHeld] [bit] NULL,
	[FemalePrisonersHeld] [bit] NULL,
	[JuvenilePrisonersHeld] [bit] NULL,
	[YoungOffendersHeld] [bit] NULL,
	[AdultPrisonersHeld] [bit] NULL,
	[Cat] [nvarchar](255) NULL,
	[Ptype] [nvarchar](255) NULL,
	[VolunteersNotes] [text] NULL,
	[Notes] [text] NULL,
	[Governor] [nvarchar](255) NULL,
	[Telephone] [nvarchar](255) NULL,
	[Tag] [nvarchar](255) NULL,
	[NlAddressOrder] [int] NOT NULL,
	[InclInNLAddressList] [bit] NULL,
	[DesignationNewsletter] [nvarchar](255) NULL,
	[Location] [int] NOT NULL,
	[ContactForNewsletter] [nvarchar](255) NULL,
	[ContactPosition] [nvarchar](255) NULL,
	[ContactPhone] [nvarchar](255) NULL,
	[ContactFax] [nvarchar](255) NULL,
 CONSTRAINT [PK_Prison] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Prison]  WITH CHECK ADD  CONSTRAINT [FK_Prison_Country] FOREIGN KEY([Country])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[Prison] CHECK CONSTRAINT [FK_Prison_Country]
GO
ALTER TABLE [dbo].[Prison]  WITH CHECK ADD  CONSTRAINT [FK_Prison_LocationType] FOREIGN KEY([Location])
REFERENCES [dbo].[LocationType] ([Id])
GO
ALTER TABLE [dbo].[Prison] CHECK CONSTRAINT [FK_Prison_LocationType]
GO
ALTER TABLE [dbo].[Prison]  WITH CHECK ADD  CONSTRAINT [FK_Prison_NLAddressOrderType] FOREIGN KEY([NlAddressOrder])
REFERENCES [dbo].[NLAddressOrderType] ([Id])
GO
ALTER TABLE [dbo].[Prison] CHECK CONSTRAINT [FK_Prison_NLAddressOrderType]
GO
ALTER TABLE [dbo].[Prison]  WITH CHECK ADD  CONSTRAINT [FK_Prison_PrisonSex] FOREIGN KEY([Sex])
REFERENCES [dbo].[PrisonSex] ([Id])
GO
ALTER TABLE [dbo].[Prison] CHECK CONSTRAINT [FK_Prison_PrisonSex]
GO
