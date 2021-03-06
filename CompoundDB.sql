USE [master]
GO
/****** Object:  Database [Compound_Database]    Script Date: 1/10/2022 7:49:45 AM ******/
CREATE DATABASE [Compound_Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Compound_Database', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Compound_Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Compound_Database_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Compound_Database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Compound_Database] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Compound_Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Compound_Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Compound_Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Compound_Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Compound_Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Compound_Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [Compound_Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Compound_Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Compound_Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Compound_Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Compound_Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Compound_Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Compound_Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Compound_Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Compound_Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Compound_Database] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Compound_Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Compound_Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Compound_Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Compound_Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Compound_Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Compound_Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Compound_Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Compound_Database] SET RECOVERY FULL 
GO
ALTER DATABASE [Compound_Database] SET  MULTI_USER 
GO
ALTER DATABASE [Compound_Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Compound_Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Compound_Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Compound_Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Compound_Database] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Compound_Database] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Compound_Database', N'ON'
GO
ALTER DATABASE [Compound_Database] SET QUERY_STORE = OFF
GO
USE [Compound_Database]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[D#] [int] NOT NULL,
	[S#] [int] NOT NULL,
	[Residence_ID] [int] NOT NULL,
	[Appt_date] [date] NOT NULL,
	[Appt_time] [time](7) NOT NULL,
 CONSTRAINT [PK__Appointm__C6394E6937982EE5] PRIMARY KEY CLUSTERED 
(
	[D#] ASC,
	[S#] ASC,
	[Residence_ID] ASC,
	[Appt_date] ASC,
	[Appt_time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Complaints]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Complaints](
	[Complaint_ID] [int] IDENTITY(1,1) NOT NULL,
	[Residence_ID] [int] NULL,
	[D#] [int] NOT NULL,
	[Complaint] [text] NULL,
 CONSTRAINT [PK_Complaints] PRIMARY KEY CLUSTERED 
(
	[Complaint_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compound_Services]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compound_Services](
	[D#] [int] NOT NULL,
	[S#] [int] NOT NULL,
	[Service_type] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Compound__B13533E4E7CF09DB] PRIMARY KEY CLUSTERED 
(
	[D#] ASC,
	[S#] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[D#] [int] IDENTITY(1,1) NOT NULL,
	[Dname] [varchar](50) NOT NULL,
	[Manager_ID] [char](14) NULL,
 CONSTRAINT [PK__Departme__32146224CEB0E9A5] PRIMARY KEY CLUSTERED 
(
	[D#] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Employee_ID] [char](14) NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Address] [varchar](100) NULL,
	[DOB] [date] NULL,
	[Salary] [int] NOT NULL,
	[D#] [int] NOT NULL,
 CONSTRAINT [PK__Employee__7811348137347691] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Residence]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Residence](
	[Residence_ID] [int] IDENTITY(1,1) NOT NULL,
	[B#] [int] NOT NULL,
	[St#] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[No_of_visitors] [int] NULL,
	[For_sale] [bit] NOT NULL,
	[Owner_ID] [char](14) NULL,
	[Emergency] [bit] NULL,
 CONSTRAINT [PK__Residenc__39D8C6D597015254] PRIMARY KEY CLUSTERED 
(
	[Residence_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Residence_Owner]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Residence_Owner](
	[Owner_ID] [char](14) NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Phone_number] [char](11) NOT NULL,
	[Occupation] [varchar](100) NULL,
	[Marital_status] [varchar](30) NULL,
 CONSTRAINT [PK__Residenc__BD6352DBF97F9350] PRIMARY KEY CLUSTERED 
(
	[Owner_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscribed_In]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscribed_In](
	[D#] [int] NOT NULL,
	[S#] [int] NOT NULL,
	[Residence_ID] [int] NOT NULL,
 CONSTRAINT [PK_Subscribed_In] PRIMARY KEY CLUSTERED 
(
	[D#] ASC,
	[S#] ASC,
	[Residence_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Accounts]    Script Date: 1/10/2022 7:49:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Accounts](
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[User_type] [varchar](14) NOT NULL,
	[Emp_ID] [char](14) NULL,
	[Res_Owner_ID] [char](14) NULL,
 CONSTRAINT [PK__User_Acc__536C85E5FD24B287] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (1, 2, 4, CAST(N'2021-06-11' AS Date), CAST(N'11:30:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (1, 2, 16, CAST(N'2022-01-02' AS Date), CAST(N'19:15:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (1, 4, 2, CAST(N'2022-03-02' AS Date), CAST(N'09:30:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (1, 5, 13, CAST(N'2022-02-07' AS Date), CAST(N'21:00:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (1, 5, 18, CAST(N'2022-02-01' AS Date), CAST(N'10:00:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 1, 6, CAST(N'2022-11-02' AS Date), CAST(N'07:15:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 1, 15, CAST(N'2022-01-29' AS Date), CAST(N'17:20:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 1, 17, CAST(N'2022-02-12' AS Date), CAST(N'12:50:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 1, 20, CAST(N'2022-01-29' AS Date), CAST(N'09:30:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 3, 14, CAST(N'2022-05-02' AS Date), CAST(N'20:30:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 4, 8, CAST(N'2022-01-15' AS Date), CAST(N'19:00:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 4, 9, CAST(N'2022-01-12' AS Date), CAST(N'16:45:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 5, 3, CAST(N'2022-01-06' AS Date), CAST(N'22:00:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (2, 5, 11, CAST(N'2022-03-22' AS Date), CAST(N'18:20:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (4, 1, 5, CAST(N'2022-01-04' AS Date), CAST(N'13:00:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (5, 2, 7, CAST(N'2022-03-01' AS Date), CAST(N'12:00:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (5, 2, 12, CAST(N'2022-01-03' AS Date), CAST(N'14:30:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (6, 1, 10, CAST(N'2022-03-21' AS Date), CAST(N'15:40:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (6, 1, 19, CAST(N'2022-02-01' AS Date), CAST(N'17:40:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (7, 4, 1, CAST(N'2022-12-02' AS Date), CAST(N'10:00:00' AS Time))
INSERT [dbo].[Appointments] ([D#], [S#], [Residence_ID], [Appt_date], [Appt_time]) VALUES (7, 4, 14, CAST(N'2022-02-07' AS Date), CAST(N'08:45:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[Complaints] ON 

INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (1, 2, 7, N'Garden not cleaned well')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (2, 3, 6, N'Clothes not clean after laundry')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (3, 15, 6, N'Clothes Wrinkled after ironing')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (4, 13, 5, N'House not cleaned well')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (5, 10, 2, N'Spa not clean')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (6, 7, 3, N'Security did not meet emergency call')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (7, 1, 7, N'Bushes not trimmed well')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (8, 6, 4, N'Sink not fixed')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (9, 2, 1, N'Trainer late')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (10, 7, 1, N'No towels in locker rooms')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (11, 8, 1, N'Stolen ring in gym')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (12, 18, 5, N'House not cleaned well')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (13, 1, 6, N'Clothes not clean after laundry')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (14, 11, 1, N'No sign for wet floor')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (15, 12, 5, N'Pool not cleaned well')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (16, 14, 2, N'Eyebrows not even')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (17, 9, 6, N'Burn mark on shirt')
INSERT [dbo].[Complaints] ([Complaint_ID], [Residence_ID], [D#], [Complaint]) VALUES (18, 16, 2, N'Bad customer service in manicure appointment')
SET IDENTITY_INSERT [dbo].[Complaints] OFF
GO
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (1, 1, N'Zoomba')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (1, 2, N'Aerobics')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (1, 3, N'Sauna')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (1, 4, N'Jacuzzi')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (1, 5, N'Machines')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (2, 1, N'Massage')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (2, 2, N'Sauna')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (2, 3, N'Microblading')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (2, 4, N'Manicure')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (2, 5, N'Pedicure')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (4, 1, N'Plumbing')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (4, 2, N'Electricity')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (4, 3, N'Carpenter')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (5, 1, N'House Cleaning')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (5, 2, N'Pool Cleaning')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (6, 1, N'Take laundry')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (6, 2, N'Iron clothes')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (6, 3, N'Dry cleaning')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (6, 4, N'Carpet washing')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (6, 5, N'Blanket washing')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (7, 1, N'Plant')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (7, 2, N'Cut grass')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (7, 3, N'Cut bushes')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (7, 4, N'Clean garden')
INSERT [dbo].[Compound_Services] ([D#], [S#], [Service_type]) VALUES (7, 5, N'Pruning plants')
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([D#], [Dname], [Manager_ID]) VALUES (1, N'Gym', N'11111122222233')
INSERT [dbo].[Departments] ([D#], [Dname], [Manager_ID]) VALUES (2, N'Spa', N'22222233333355')
INSERT [dbo].[Departments] ([D#], [Dname], [Manager_ID]) VALUES (3, N'Security', N'11111666688888')
INSERT [dbo].[Departments] ([D#], [Dname], [Manager_ID]) VALUES (4, N'Maintenance', N'11116666699999')
INSERT [dbo].[Departments] ([D#], [Dname], [Manager_ID]) VALUES (5, N'Cleaning', N'44445555777777')
INSERT [dbo].[Departments] ([D#], [Dname], [Manager_ID]) VALUES (6, N'Laundry', N'99999888844444')
INSERT [dbo].[Departments] ([D#], [Dname], [Manager_ID]) VALUES (7, N'Gardening', N'88888666665555')
INSERT [dbo].[Departments] ([D#], [Dname], [Manager_ID]) VALUES (16, N'General', N'11111122222233')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'11111122222233', N'Ahmed', N'Youssef', N'38 remaya', CAST(N'1970-03-12' AS Date), 12000, 1)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'11111666688888', N'Khaled', N'Ahmed', N'02 Sheikh Zayed', CAST(N'1992-09-23' AS Date), 17000, 1)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'11116666699999', N'Youssef', N'Ahmed', N'55 Dokki', CAST(N'1977-02-07' AS Date), 12000, 4)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'14725836911227', N'Youssef', N'Ahmed', N'55 dokki', CAST(N'1980-03-13' AS Date), 15000, 2)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15933726314769', N'Shams', N'Mohamed', N'39 6th of October', CAST(N'1970-12-12' AS Date), 22000, 1)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935724414769', N'Nour', N'Ahmed', N'41 Zamalek', CAST(N'1972-02-05' AS Date), 18000, 3)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935726311769', N'Marwan', N'Sabry', N'06 Haram', CAST(N'1995-06-15' AS Date), 8000, 5)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935726314744', N'Marwa', N'Mazen', N'42 Haram', CAST(N'1996-12-11' AS Date), 13000, 4)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935726314755', N'Omnia', N'Khaled', N'63 5th Settlement', CAST(N'1978-02-17' AS Date), 15000, 7)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935726314769', N'Youssef', N'Khaled', N'66 maadi', CAST(N'1970-12-09' AS Date), 10000, 3)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935726314799', N'Malika', N'Yousri', N'03 Maadi', CAST(N'1999-04-03' AS Date), 19000, 2)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935726316769', N'Noha', N'Fawaz', N'07 Remaya', CAST(N'1977-11-06' AS Date), 29000, 4)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935727714788', N'Nermine', N'Waleed', N'97 Mohandeseen', CAST(N'1986-10-05' AS Date), 26000, 6)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935766678724', N'Ahmed', N'Mohamed', N'59 5th Settlement', CAST(N'1988-02-08' AS Date), 17000, 5)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935768241235', N'Amr', N'Mostafa', N'77 Sheikh Zayed', CAST(N'1970-07-09' AS Date), 23000, 1)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935776314769', N'Sanaa', N'Nader', N'10 Nasr City', CAST(N'1973-12-27' AS Date), 33000, 6)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'15935777314766', N'Maha', N'Seif', N'58 Ahmed Oraby', CAST(N'1989-01-25' AS Date), 30000, 1)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'22222233333355', N'Mahmoud', N'Khaled', N'22 6th of October', CAST(N'1988-12-04' AS Date), 7000, 2)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'44445555777777', N'Seif', N'Hafez', N'52 6th of October', CAST(N'1990-11-09' AS Date), 10000, 5)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'88888666665555', N'Dalia', N'Youssef', N'57 Maadi', CAST(N'1987-12-10' AS Date), 22000, 7)
INSERT [dbo].[Employees] ([Employee_ID], [Fname], [Lname], [Address], [DOB], [Salary], [D#]) VALUES (N'99999888844444', N'Jihan', N'Anwar', N'78 Zamalek', CAST(N'1998-12-06' AS Date), 27000, 6)
GO
SET IDENTITY_INSERT [dbo].[Residence] ON 

INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (1, 1, 1, N'Villa', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (2, 2, 3, N'Twinhouse', 3, 0, N'12345678901112', 1)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (3, 3, 2, N'Appartment', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (4, 3, 2, N'Appartment', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (5, 3, 2, N'Appartment', 0, 0, N'12345678901288', 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (6, 3, 2, N'Appartment', 2, 0, N'12345678901277', 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (7, 3, 2, N'Appartment', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (8, 3, 2, N'Appartment', 0, 0, N'12345678901233', 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (9, 4, 1, N'Villa', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (10, 5, 1, N'Villa', 4, 0, N'12345678901234', 1)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (11, 6, 1, N'Villa', 3, 0, N'12345678901222', 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (12, 7, 3, N'Twinhouse', 0, 0, N'12345678901238', 1)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (13, 8, 3, N'Twinhouse', 6, 0, N'12345678901231', 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (14, 9, 3, N'Twinhouse', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (15, 10, 4, N'Studio', 0, 0, N'12345678901255', 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (16, 11, 4, N'Studio', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (17, 12, 5, N'Villa', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (18, 13, 5, N'Villa', 2, 0, N'12345678901235', 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (19, 14, 6, N'Villa', NULL, 1, NULL, 0)
INSERT [dbo].[Residence] ([Residence_ID], [B#], [St#], [Type], [No_of_visitors], [For_sale], [Owner_ID], [Emergency]) VALUES (20, 15, 6, N'Villa', 3, 0, N'12345678901299', 0)
SET IDENTITY_INSERT [dbo].[Residence] OFF
GO
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901111', N'Mokhtar', N'Mohamed', N'01299124677', N'College Professor', N'Married')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901112', N'Salwa', N'Khalid', N'01223100677', N'Nurse', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901211', N'Malak', N'Youssef', N'01213924677', N'Teacher', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901222', N'Rawan', N'Ahmed', N'01023129677', N'Engineer', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901231', N'Mariam', N'Ahmed', N'01223124671', N'Actress', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901232', N'Omar', N'Nashat', N'01223124672', N'Student', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901233', N'Mark', N'Milad', N'01223124673', N'Student', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901234', N'Shahd', N'Abdelrahman', N'01223124677', N'Student', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901235', N'Mohamed', N'Hassan', N'01223122677', N'Engineer', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901236', N'Ahmed', N'Mohamed', N'01228124677', N'Neurologist', N'Married')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901237', N'Youssef', N'Abdelrahman', N'01123124677', N'Accountant', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901238', N'Omar', N'Ahmed', N'01223125677', N'Student', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901239', N'Nancy', N'Youssef', N'01223126677', N'Doctor', N'Divorced')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901244', N'Laila', N'Mostafa', N'01003124677', N'Cardiologist', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901255', N'Neveen', N'Abdelrahman', N'01113124677', N'Accountant', N'Married')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901266', N'Abdelrahman', N'Labib', N'01223124999', N'Engineer', N'Married')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901277', N'Dalia', N'Mostafa', N'01223188677', N'Lawyer', N'Single')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901288', N'Tamara', N'Abdelrahman', N'01033124677', N'Nurse', N'Divorced')
INSERT [dbo].[Residence_Owner] ([Owner_ID], [Fname], [Lname], [Phone_number], [Occupation], [Marital_status]) VALUES (N'12345678901299', N'Judi', N'Mohamed', N'01223124997', N'Lawyer', N'Single')
GO
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (1, 1, 1)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (1, 1, 2)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (1, 1, 3)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (1, 1, 12)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (1, 2, 1)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (1, 2, 6)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (1, 5, 14)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (1, 5, 18)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (2, 1, 17)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (2, 4, 2)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (2, 4, 15)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (2, 5, 15)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (4, 1, 15)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (5, 1, 5)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (5, 1, 11)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (6, 1, 8)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (6, 3, 9)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (7, 1, 7)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (7, 2, 6)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (7, 2, 10)
INSERT [dbo].[Subscribed_In] ([D#], [S#], [Residence_ID]) VALUES (7, 4, 7)
GO
INSERT [dbo].[User_Accounts] ([Username], [Password], [User_type], [Emp_ID], [Res_Owner_ID]) VALUES (N'admin', N'D033E22AE348AEB5660FC2140AEC35850C4DA997', N'Admin', N'11111122222233', NULL)
INSERT [dbo].[User_Accounts] ([Username], [Password], [User_type], [Emp_ID], [Res_Owner_ID]) VALUES (N'khaled', N'7c4a8d09ca3762af61e59520943dc26494f8941b', N'Employee', N'11111666688888', NULL)
INSERT [dbo].[User_Accounts] ([Username], [Password], [User_type], [Emp_ID], [Res_Owner_ID]) VALUES (N'salwa', N'7c4a8d09ca3762af61e59520943dc26494f8941b', N'ResidenceOwner', NULL, N'12345678901112')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Residence_Owner]    Script Date: 1/10/2022 7:49:45 AM ******/
ALTER TABLE [dbo].[Residence_Owner] ADD  CONSTRAINT [IX_Residence_Owner] UNIQUE NONCLUSTERED 
(
	[Phone_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [DF_Employees_D#]  DEFAULT ((1)) FOR [D#]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK__Appointments__30F848ED] FOREIGN KEY([D#], [S#])
REFERENCES [dbo].[Compound_Services] ([D#], [S#])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK__Appointments__30F848ED]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Residence] FOREIGN KEY([Residence_ID])
REFERENCES [dbo].[Residence] ([Residence_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Residence]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK__Complaint__Resid__38996AB5] FOREIGN KEY([Residence_ID])
REFERENCES [dbo].[Residence] ([Residence_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK__Complaint__Resid__38996AB5]
GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK__Complaints__D#__398D8EEE] FOREIGN KEY([D#])
REFERENCES [dbo].[Departments] ([D#])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK__Complaints__D#__398D8EEE]
GO
ALTER TABLE [dbo].[Compound_Services]  WITH CHECK ADD  CONSTRAINT [FK__Compound_Ser__D#__2E1BDC42] FOREIGN KEY([D#])
REFERENCES [dbo].[Departments] ([D#])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compound_Services] CHECK CONSTRAINT [FK__Compound_Ser__D#__2E1BDC42]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Employees] FOREIGN KEY([Manager_ID])
REFERENCES [dbo].[Employees] ([Employee_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Employees]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK__Employees__D#__2B3F6F97] FOREIGN KEY([D#])
REFERENCES [dbo].[Departments] ([D#])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK__Employees__D#__2B3F6F97]
GO
ALTER TABLE [dbo].[Residence]  WITH CHECK ADD  CONSTRAINT [FK__Residence__Owner__267ABA7A] FOREIGN KEY([Owner_ID])
REFERENCES [dbo].[Residence_Owner] ([Owner_ID])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Residence] CHECK CONSTRAINT [FK__Residence__Owner__267ABA7A]
GO
ALTER TABLE [dbo].[Subscribed_In]  WITH CHECK ADD  CONSTRAINT [FK__Subscribe__Resid__35BCFE0A] FOREIGN KEY([Residence_ID])
REFERENCES [dbo].[Residence] ([Residence_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Subscribed_In] CHECK CONSTRAINT [FK__Subscribe__Resid__35BCFE0A]
GO
ALTER TABLE [dbo].[Subscribed_In]  WITH CHECK ADD  CONSTRAINT [FK__Subscribed_In__34C8D9D1] FOREIGN KEY([D#], [S#])
REFERENCES [dbo].[Compound_Services] ([D#], [S#])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Subscribed_In] CHECK CONSTRAINT [FK__Subscribed_In__34C8D9D1]
GO
ALTER TABLE [dbo].[User_Accounts]  WITH CHECK ADD  CONSTRAINT [FK_User_Accounts_Residence_Owner] FOREIGN KEY([Res_Owner_ID])
REFERENCES [dbo].[Residence_Owner] ([Owner_ID])
GO
ALTER TABLE [dbo].[User_Accounts] CHECK CONSTRAINT [FK_User_Accounts_Residence_Owner]
GO
ALTER TABLE [dbo].[User_Accounts]  WITH CHECK ADD  CONSTRAINT [FK_User_Accounts_User_Accounts] FOREIGN KEY([Emp_ID])
REFERENCES [dbo].[Employees] ([Employee_ID])
GO
ALTER TABLE [dbo].[User_Accounts] CHECK CONSTRAINT [FK_User_Accounts_User_Accounts]
GO
USE [master]
GO
ALTER DATABASE [Compound_Database] SET  READ_WRITE 
GO
