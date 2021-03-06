USE [EMStats]
GO
/****** Object:  Table [dbo].[CTASs]    Script Date: 04/10/2013 11:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTASs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](12) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_CTAS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CTASs] ON
INSERT [dbo].[CTASs] ([ID], [Value], [Active]) VALUES (1, N'CTAS 1', 1)
INSERT [dbo].[CTASs] ([ID], [Value], [Active]) VALUES (2, N'CTAS 2', 1)
INSERT [dbo].[CTASs] ([ID], [Value], [Active]) VALUES (3, N'CTAS 3', 1)
INSERT [dbo].[CTASs] ([ID], [Value], [Active]) VALUES (4, N'CTAS 4', 1)
INSERT [dbo].[CTASs] ([ID], [Value], [Active]) VALUES (5, N'CTAS 5', 1)
SET IDENTITY_INSERT [dbo].[CTASs] OFF
/****** Object:  Table [dbo].[CallTypes]    Script Date: 04/10/2013 11:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CallTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_CallTypes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CallTypes] ON
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (1, N'Cancelled/Refusal', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (2, N'Cardiac', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (3, N'STEMI', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (4, N'CVA', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (5, N'SOB', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (6, N'Transfer/Return', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (7, N'Stat Transfer', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (8, N'Trauma', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (9, N'VSA', 1)
INSERT [dbo].[CallTypes] ([ID], [Value], [Active]) VALUES (10, N'Other', 1)
SET IDENTITY_INSERT [dbo].[CallTypes] OFF
/****** Object:  Table [dbo].[VSAs]    Script Date: 04/10/2013 11:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VSAs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](25) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_VSAs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VSAs] ON
INSERT [dbo].[VSAs] ([ID], [Value], [Active]) VALUES (1, N'None', 1)
INSERT [dbo].[VSAs] ([ID], [Value], [Active]) VALUES (2, N'VSA Transport', 1)
INSERT [dbo].[VSAs] ([ID], [Value], [Active]) VALUES (3, N'VSA ROSC', 1)
INSERT [dbo].[VSAs] ([ID], [Value], [Active]) VALUES (4, N'VSA TOR', 1)
INSERT [dbo].[VSAs] ([ID], [Value], [Active]) VALUES (5, N'VSA Code 5', 1)
SET IDENTITY_INSERT [dbo].[VSAs] OFF
/****** Object:  Table [dbo].[SymptomReliefs]    Script Date: 04/10/2013 11:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SymptomReliefs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_SymptomReliefs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SymptomReliefs] ON
INSERT [dbo].[SymptomReliefs] ([ID], [Value], [Active]) VALUES (1, N'None', 1)
INSERT [dbo].[SymptomReliefs] ([ID], [Value], [Active]) VALUES (2, N'ASA and/or Nitro', 1)
INSERT [dbo].[SymptomReliefs] ([ID], [Value], [Active]) VALUES (3, N'Dextrose and/or Gel ', 1)
INSERT [dbo].[SymptomReliefs] ([ID], [Value], [Active]) VALUES (5, N'Glucagon and/or Gel', 1)
INSERT [dbo].[SymptomReliefs] ([ID], [Value], [Active]) VALUES (6, N'Epi and/or Ventolin', 1)
SET IDENTITY_INSERT [dbo].[SymptomReliefs] OFF
/****** Object:  Table [dbo].[IVAttempts]    Script Date: 04/10/2013 11:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IVAttempts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](25) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_IVAttempts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[IVAttempts] ON
INSERT [dbo].[IVAttempts] ([ID], [Value], [Active]) VALUES (1, N'None', 1)
INSERT [dbo].[IVAttempts] ([ID], [Value], [Active]) VALUES (2, N'IV Successful', 1)
INSERT [dbo].[IVAttempts] ([ID], [Value], [Active]) VALUES (3, N'IV Unsuccessful', 1)
SET IDENTITY_INSERT [dbo].[IVAttempts] OFF
/****** Object:  Table [dbo].[Entries]    Script Date: 04/10/2013 11:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[CallNumber] [nvarchar](8) NOT NULL,
	[T2] [time](7) NOT NULL,
	[T3] [time](7) NOT NULL,
	[T4] [time](7) NOT NULL,
	[CTAS] [int] NOT NULL,
	[CallType] [int] NOT NULL,
	[VSA] [int] NOT NULL,
	[SymptomRelief] [int] NOT NULL,
	[IVAttempt] [int] NOT NULL,
	[DateEntered] [datetime] NOT NULL,
	[EnteredBy] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Entries] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  ForeignKey [FK_Entries_CallTypes]    Script Date: 04/10/2013 11:56:27 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_Entries_CallTypes] FOREIGN KEY([CallType])
REFERENCES [dbo].[CallTypes] ([ID])
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_Entries_CallTypes]
GO
/****** Object:  ForeignKey [FK_Entries_CTASs]    Script Date: 04/10/2013 11:56:27 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_Entries_CTASs] FOREIGN KEY([CTAS])
REFERENCES [dbo].[CTASs] ([ID])
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_Entries_CTASs]
GO
/****** Object:  ForeignKey [FK_Entries_IVAttempts1]    Script Date: 04/10/2013 11:56:27 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_Entries_IVAttempts1] FOREIGN KEY([IVAttempt])
REFERENCES [dbo].[IVAttempts] ([ID])
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_Entries_IVAttempts1]
GO
/****** Object:  ForeignKey [FK_Entries_SymptomReliefs]    Script Date: 04/10/2013 11:56:27 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_Entries_SymptomReliefs] FOREIGN KEY([SymptomRelief])
REFERENCES [dbo].[SymptomReliefs] ([ID])
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_Entries_SymptomReliefs]
GO
/****** Object:  ForeignKey [FK_Entries_VSAs]    Script Date: 04/10/2013 11:56:27 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_Entries_VSAs] FOREIGN KEY([VSA])
REFERENCES [dbo].[VSAs] ([ID])
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_Entries_VSAs]
GO
