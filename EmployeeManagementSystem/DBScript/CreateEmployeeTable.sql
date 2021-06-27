USE [EmployeeDB]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 6/27/2021 12:02:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[WorkLocation] [nvarchar](50) NULL,
	[TechnologyStack] [nvarchar](50) NULL,
	[DateOfJoining] [datetime2](7) NOT NULL,
	[Rating] [int] NOT NULL,
	[CTC] [int] NOT NULL,
	[BaseSalary] [int] NOT NULL,
	[ManagerName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


