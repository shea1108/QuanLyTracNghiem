USE [master]
GO
/****** Object:  Database [QuanLyAppTracNghiem]    Script Date: 4/13/2024 3:34:11 PM ******/
CREATE DATABASE [QuanLyAppTracNghiem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyAppTracNghiem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyAppTracNghiem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyAppTracNghiem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyAppTracNghiem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyAppTracNghiem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyAppTracNghiem]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 4/13/2024 3:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[fullname] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[phone_number] [nvarchar](50) NULL,
 CONSTRAINT [PK__admin__3214EC0743AE39BB] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History_Test]    Script Date: 4/13/2024 3:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History_Test](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_User] [int] NULL,
	[Id_Exam] [int] NULL,
	[NameExam] [nvarchar](50) NULL,
	[NumberExam] [int] NULL,
	[Time_Completed] [int] NULL,
	[Result] [nvarchar](50) NULL,
	[Total_Point] [int] NULL,
	[Date_Time] [nvarchar](50) NULL,
 CONSTRAINT [PK__History___3214EC075CF9B5AE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[list_exam]    Script Date: 4/13/2024 3:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[list_exam](
	[Id_Exam] [int] IDENTITY(1,1) NOT NULL,
	[Name_Exam] [nvarchar](50) NULL,
	[Exam_Number] [int] NULL,
	[number_Question] [int] NULL,
	[Time] [int] NULL,
 CONSTRAINT [PK__list_exa__5CF55AD932D157B8] PRIMARY KEY CLUSTERED 
(
	[Id_Exam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[list_subject]    Script Date: 4/13/2024 3:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[list_subject](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nameExam] [nvarchar](50) NULL,
 CONSTRAINT [PK__list_sub__3213E83FD5E620AD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 4/13/2024 3:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[id_question] [int] IDENTITY(1,1) NOT NULL,
	[Id_Exam] [int] NULL,
	[question] [nvarchar](200) NULL,
	[AnswerA] [nvarchar](200) NULL,
	[AnswerB] [nvarchar](200) NULL,
	[AnswerC] [nvarchar](200) NULL,
	[AnswerD] [nvarchar](200) NULL,
	[Correct_Answer] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK__Question__2BD92477ADBFC513] PRIMARY KEY CLUSTERED 
(
	[id_question] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ranking]    Script Date: 4/13/2024 3:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ranking](
	[Id_User] [int] NOT NULL,
	[fullname] [nvarchar](50) NULL,
	[Completed_Exams] [int] NULL,
	[Total_Points] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/13/2024 3:34:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id_User] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[fullname] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[phone_number] [nvarchar](50) NULL,
 CONSTRAINT [PK__Users__D03DEDCB1F1C05F8] PRIMARY KEY CLUSTERED 
(
	[Id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[admin] ON 

INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (1, N'admin1', N'password1', N'Admin One', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (2, N'admin2', N'password2', N'Admin Two', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (3, N'admin3', N'password3', N'Admin Three', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (4, N'admin4', N'password4', N'Admin Four', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (5, N'admin5', N'password5', N'Admin Five', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (6, N'admin6', N'password6', N'Admin Six', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (7, N'admin7', N'password7', N'Admin Seven', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (8, N'admin8', N'password8', N'Admin Eight', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (9, N'admin9', N'password9', N'Admin Nine', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (10, N'admin10', N'password10', N'Admin Ten', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (11, N'admin11', N'password11', N'Admin Eleven', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (12, N'admin12', N'password12', N'Admin Twelve', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (13, N'admin13', N'password13', N'Admin Thirteen', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (14, N'admin14', N'password14', N'Admin Fourteen', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (15, N'admin15', N'password15', N'Admin Fifteen', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (16, N'admin16', N'password16', N'Admin Sixteen', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (17, N'admin17', N'password17', N'Admin Seventeen', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (18, N'admin18', N'password18', N'Admin Eighteen', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (19, N'admin19', N'password19', N'Admin Nineteen', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (20, N'admin20', N'password20', N'Admin Twenty', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (21, N'admin21', N'password21', N'Admin Twenty-One', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (22, N'admin22', N'password22', N'Admin Twenty-Two', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (23, N'admin23', N'password23', N'Admin Twenty-Three', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (24, N'admin24', N'password24', N'Admin Twenty-Four', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (25, N'admin25', N'password25', N'Admin Twenty-Five', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (26, N'admin26', N'password26', N'Admin Twenty-Six', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (27, N'admin27', N'password27', N'Admin Twenty-Seven', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (28, N'admin28', N'password28', N'Admin Twenty-Eight', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (29, N'admin29', N'password29', N'Admin Twenty-Nine', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (30, N'admin30', N'password30', N'Admin Thirty', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (31, N'admin31', N'password31', N'Admin Thirty-One', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (32, N'admin32', N'password32', N'Admin Thirty-Two', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (33, N'admin33', N'password33', N'Admin Thirty-Three', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (34, N'admin34', N'password34', N'Admin Thirty-Four', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (35, N'admin35', N'password35', N'Admin Thirty-Five', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (36, N'admin36', N'password36', N'Admin Thirty-Six', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (37, N'admin37', N'password37', N'Admin Thirty-Seven', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (38, N'admin38', N'password38', N'Admin Thirty-Eight', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (39, N'admin39', N'password39', N'Admin Thirty-Nine', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (40, N'admin40', N'password40', N'Admin Forty', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (41, N'admin41', N'password41', N'Admin Forty-One', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (42, N'admin42', N'password42', N'Admin Forty-Two', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (43, N'admin43', N'password43', N'Admin Forty-Three', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (44, N'admin44', N'password44', N'Admin Forty-Four', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (45, N'admin45', N'password45', N'Admin Forty-Five', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (46, N'admin46', N'password46', N'Admin Forty-Six', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (47, N'admin47', N'password47', N'Admin Forty-Seven', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (48, N'admin48', N'password48', N'Admin Forty-Eight', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (49, N'admin49', N'password49', N'Admin Forty-Nine', NULL, NULL)
INSERT [dbo].[admin] ([Id], [username], [password], [fullname], [email], [phone_number]) VALUES (50, N'1', N'1', N'1', N'1', N'1')
SET IDENTITY_INSERT [dbo].[admin] OFF
GO
SET IDENTITY_INSERT [dbo].[list_exam] ON 

INSERT [dbo].[list_exam] ([Id_Exam], [Name_Exam], [Exam_Number], [number_Question], [Time]) VALUES (163, N'Công nghệ Java', 1, 10, 10)
INSERT [dbo].[list_exam] ([Id_Exam], [Name_Exam], [Exam_Number], [number_Question], [Time]) VALUES (164, N'Mạng máy tính', 1, 10, 10)
INSERT [dbo].[list_exam] ([Id_Exam], [Name_Exam], [Exam_Number], [number_Question], [Time]) VALUES (165, N'Cơ sở dữ liệu', 1, 10, 10)
INSERT [dbo].[list_exam] ([Id_Exam], [Name_Exam], [Exam_Number], [number_Question], [Time]) VALUES (166, N'Tin học đại cương', 1, 10, 10)
INSERT [dbo].[list_exam] ([Id_Exam], [Name_Exam], [Exam_Number], [number_Question], [Time]) VALUES (167, N'Toán rời rạc', 1, 10, 10)
INSERT [dbo].[list_exam] ([Id_Exam], [Name_Exam], [Exam_Number], [number_Question], [Time]) VALUES (168, N'Lập trình hướng đối tượng', 1, 10, 10)
SET IDENTITY_INSERT [dbo].[list_exam] OFF
GO
SET IDENTITY_INSERT [dbo].[list_subject] ON 

INSERT [dbo].[list_subject] ([id], [nameExam]) VALUES (19, N'Lập trình hướng đối tượng')
INSERT [dbo].[list_subject] ([id], [nameExam]) VALUES (20, N'Công nghệ Java')
INSERT [dbo].[list_subject] ([id], [nameExam]) VALUES (21, N'Mạng máy tính')
INSERT [dbo].[list_subject] ([id], [nameExam]) VALUES (22, N'Cơ sở dữ liệu')
INSERT [dbo].[list_subject] ([id], [nameExam]) VALUES (23, N'Tin học đại cương')
INSERT [dbo].[list_subject] ([id], [nameExam]) VALUES (24, N'Toán rời rạc')
SET IDENTITY_INSERT [dbo].[list_subject] OFF
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1156, 163, N'Trong Java, từ khóa "final" được sử dụng để làm gì?', N'Chỉ định một phương thức không thể được ghi đè', N'Đánh dấu một biến là hằng số', N'Cả a và b đúng', N'Kết thúc một vòng lặp', 3, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1157, 163, N'Interface trong Java là gì?', N'Một lớp cụ thể', N'Một tập hợp các phương thức trừu tượng', N'Một biến đối tượng', N'Một khối mã lệnh', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1158, 163, N'Trong Java, cách nào sử dụng để xử lý ngoại lệ?', N'Try-catch', N'If-else', N'Switch', N'While', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1159, 163, N'Đối tượng nào trong Java chịu trách nhiệm thu gom bộ nhớ không sử dụng?', N'MemoryManager', N'Garbage Collector', N'Destructor', N'MemoryCleaner', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1160, 163, N'"Từ khóa "this" trong Java được sử dụng để làm gì?', N'Gọi một phương thức tĩnh', N'Tham chiếu đến đối tượng hiện tại', N'Gọi một phương thức của đối tượng khác', N'Tạo một đối tượng mới', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1161, 163, N'Trong Java, cách khởi tạo một mảng có kích thước cố định là gì?', N'int arr[] = new int[]', N'int[] arr = new int[]', N'int arr[10]', N'int[] arr = new int[10]', 4, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1162, 163, N'Lớp nào là lớp cha của tất cả các lớp trong Java?', N'Main', N'Object', N'Base', N'Root', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1163, 163, N'Trong Java, cách nào để chấp nhận đối số dòng lệnh khi chạy chương trình?', N'Input arguments', N'Program arguments', N'System arguments', N'Command-line arguments', 4, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1164, 163, N'Java là ngôn ngữ lập trình hướng đối tượng. Đặc điểm nào sau đây không đúng về OOP trong Java?', N'Đa kế thừa', N'Đóng gói', N'Trừu tượng', N'Đa hình', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1165, 163, N'"Trong Java, lệnh "break" được sử dụng trong ngữ cảnh nào?"', N'Cả a, b và c', N'Trong phương thức', N'Trong cấu trúc điều kiện', N'Trong vòng lặp', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1166, 164, N'Trong mạng máy tính, "LAN" là viết tắt của gì?', N'Large Area Network', N'Local Access Network', N'Local Area Network', N'Longitude Area Network', 3, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1167, 164, N'Giao thức nào được sử dụng để truyền tệp qua mạng máy tính?', N'FTP', N'SMTP', N'HTTP', N'TCP', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1168, 164, N'"IP" là viết tắt của gì trong mạng máy tính?', N'Internet Protocol', N'Information Provider', N'Intranet Protocol', N'Interconnected Protocol', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1169, 164, N'Trong mạng máy tính, "DNS" là viết tắt của gì?', N'Data Network System', N'Domain Name System', N'Dynamic Network Service', N'Digital Network Security', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1170, 164, N'Mạng không dây nào sử dụng sóng vô tuyến để truyền dữ liệu?', N'Wi-Fi', N'Bluetooth', N'Ethernet', N'USB', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1171, 164, N'Phần mềm nào được sử dụng để gửi và nhận email trong mạng máy tính?', N'Outlook', N'Chrome', N'Firefox', N'Thunderbird', 4, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1172, 164, N'Trong mạng máy tính, "VPN" là viết tắt của gì?', N'Virtual Personal Network', N'Virtual Private Network', N'Visual Personal Network', N'Virtual Protected Network', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1173, 164, N'"Router" trong mạng máy tính làm gì?', N'Chuyển tiếp dữ liệu giữa mạng', N'Kiểm tra virus', N'Lưu trữ dữ liệu', N'Quản lý email', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1174, 164, N'Trong mạng máy tính, "Firewall" được sử dụng để làm gì?', N'Bảo vệ mạng khỏi truy cập trái phép', N'Tăng tốc độ kết nối mạng', N'Kiểm tra và sửa lỗi phần cứng', N'Tạo ra các bản sao lưu dữ liệu', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1175, 164, N'Giao thức nào được sử dụng để truyền trang web qua mạng máy tính?', N'HTTP', N'FTP', N'SMTP', N'TCP', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1176, 165, N'"SQL" là viết tắt của gì?', N'Structured Query Language', N'Structured Question Language', N'Sequential Query Language', N'Structured Question Logic', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1177, 165, N'"RDBMS" là viết tắt của gì?', N'Relational Database Management System', N'Rapid Database Management System', N'Robust Database Management System', N'Rational Database Management System', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1178, 165, N'"ER diagram" biểu diễn gì?', N'Quan hệ giữa các thực thể', N'Quan hệ giữa các bảng', N'Quan hệ giữa các hàm', N'Quan hệ giữa các ràng buộc', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1179, 165, N'"Primary key" là gì?', N'Một thuộc tính có giá trị duy nhất cho mỗi bản ghi trong bảng', N'Một thuộc tính mà giá trị có thể trùng lặp trong bảng', N'Một thuộc tính chính của bảng', N'Một thuộc tính chứa giá trị mặc định', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1180, 165, N'"Foreign key" là gì?', N'Một thuộc tính chứa giá trị duy nhất cho mỗi bản ghi trong bảng', N'Một thuộc tính có giá trị tham chiếu đến khóa chính của một bảng khác', N'Một thuộc tính chính của bảng', N'Một thuộc tính chứa giá trị mặc định', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1181, 165, N'"ACID" là viết tắt của gì?', N'Atomicity, Consistency, Isolation, Durability', N'Accuracy, Completeness, Integrity, Durability', N'Atomicity, Completeness, Isolation, Durability', N'Accuracy, Consistency, Isolation, Durability', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1182, 165, N'"Normalization" là gì?', N'Quá trình thiết kế cơ sở dữ liệu để giảm thiểu lặp lại dữ liệu', N'Quá trình thiết kế cơ sở dữ liệu để tối ưu hóa hiệu suất truy xuất dữ liệu', N'Quá trình thiết kế cơ sở dữ liệu để kiểm tra tính toàn vẹn của dữ liệu', N'Quá trình thiết kế cơ sở dữ liệu để tạo ra các tập hợp dữ liệu đa dạng', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1183, 165, N'"Index" là gì?', N'Một cấu trúc dữ liệu tăng tốc độ truy xuất dữ liệu', N'Một phần tử chính của một bảng', N'Một loại ràng buộc dữ liệu', N'Một tập hợp các quy tắc thiết kế', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1184, 165, N'"NoSQL" là gì?', N'Một loại ngôn ngữ truy vấn cơ sở dữ liệu', N'Một hệ quản trị cơ sở dữ liệu không phụ thuộc vào SQL', N'Một mô hình dữ liệu không tuân thủ quy tắc quan hệ', N'Một tiêu chuẩn lập trình cơ sở dữ liệu', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1185, 165, N'"Transaction" là gì?', N'Một tập hợp các hoạt động được thực hiện như một đơn vị không thể chia nhỏ', N'Một loại câu lệnh truy vấn dữ liệu', N'Một loại phần mềm quản lý dữ liệu', N'Một phần của hệ thống quản lý cơ sở dữ liệu', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1186, 166, N'Trong lĩnh vực tin học, "CPU" là viết tắt của cụm từ nào?', N'Computer Processing Unit', N'Central Processing Unit', N'Computer Program Unit', N'Central Program Unit', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1187, 166, N'"URL" là viết tắt của gì?', N'Universal Resource Locator', N'Uniform Resource Locator', N'Universal Remote Locator', N'Uniform Remote Locator', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1188, 166, N'Hệ điều hành nào được phát triển bởi Microsoft?', N'Windows', N'macOS', N'Linux', N'Android', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1189, 166, N'Phần mềm nào được sử dụng để tạo, chỉnh sửa và định dạng văn bản?', N'Microsoft Word', N'Microsoft Excel', N'Adobe Photoshop', N'Microsoft PowerPoint', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1190, 166, N'Trong lập trình, "HTML" là viết tắt của gì?', N'Hyperlink and Table Markup Language', N'Hyperlink and Text Markup Language', N'HyperText Modeling Language', N'HyperText Markup Language', 4, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1191, 166, N'Trong lĩnh vực mạng máy tính, "LAN" là viết tắt của gì?', N'Local Access Network', N'Longitude Area Network', N'Large Area Network', N'Local Area Network', 4, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1192, 166, N'Hệ thống số nào được sử dụng rộng rãi trong máy tính?', N'Hệ nhị phân', N'Hệ thập lục phân', N'Hệ thập phân', N'Hệ bát phân', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1193, 166, N'Trong lĩnh vực tin học, "WWW" là viết tắt của gì?', N'World Wireless Web', N'Wide World Web', N'World Without Wires', N'World Wide Web', 4, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1194, 166, N'"RAM" là viết tắt của gì trong tin học?', N'Readily Accessible Memory', N'Read Access Memory', N'Random Archive Memory', N'Random Access Memory', 4, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1195, 166, N'Trong lập trình, "IDE" là viết tắt của gì?', N'Intelligent Design Environment', N'Integrated Design Environment', N'Interactive Development Environment', N'Integrated Development Environment', 4, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1196, 167, N'Trong lý thuyết đồ thị, một "đỉnh" là gì?', N'Một cạnh giữa hai đỉnh', N'Một điểm trên đồ thị', N'Một tập hợp các đỉnh', N'Một biến nguyên', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1197, 167, N'Trong toán rời rạc, "n!" đại diện cho gì?', N'n bình phương', N'Giai thừa của n', N'n mũ n', N'Số mũ của n', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1198, 167, N'Trong lý thuyết đồ thị, một "cạnh" là gì?', N'Một cặp đỉnh', N'Một điểm trên đồ thị', N'Một tập hợp các cạnh', N'Một biến nguyên', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1199, 167, N'"Logarithm" là gì?', N'Một hàm toán học', N'Một kiểu dữ liệu', N'Một phép toán', N'Một số nguyên tố', 3, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1200, 167, N'Trong tổ hợp học, "nCr" biểu thị cho điều gì?', N'Số cách chọn r phần tử từ n phần tử', N'Số cách sắp xếp r phần tử từ n phần tử', N'Số cách chọn r phần tử từ n phần tử theo thứ tự', N'Số cách sắp xếp r phần tử từ n phần tử theo thứ tự', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1201, 167, N'Trong toán học, "Fibonacci sequence" là gì?', N'Dãy số mà mỗi số là tổng của hai số trước đó', N'Dãy số mà mỗi số là tích của hai số trước đó', N'Dãy số mà mỗi số là hiệu của hai số trước đó', N'Dãy số mà mỗi số là thương của hai số trước đó', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1202, 167, N'Trong lý thuyết số, "số nguyên tố" là gì?', N'Số chỉ chia hết cho 1 và chính nó', N'Số chỉ chia hết cho 1 và một số khác', N'Số chỉ chia hết cho 1, chính nó và số 2', N'Số chỉ chia hết cho 1, chính nó và một số khác', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1203, 167, N'Trong toán rời rạc, "hàm số" là gì?', N'Quy tắc toán học biểu diễn mối quan hệ giữa các biến', N'Biến ngẫu nhiên được xác định trong một không gian mẫu', N'Tập hợp các giá trị đầu vào và đầu ra', N'Sự biến đổi từ một tập hợp sang một tập hợp khác', 3, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1204, 167, N'Trong toán rời rạc, "tập hợp" là gì?', N'Một bộ sưu tập các đối tượng', N'Một biến ngẫu nhiên được xác định trong một không gian mẫu', N'Một quy tắc toán học biểu diễn mối quan hệ giữa các biến', N'Sự biến đổi từ một tập hợp sang một tập hợp khác', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1205, 167, N'Trong tổ hợp học, "n!" biểu thị cho điều gì?', N'Giai thừa của n', N'Số cách chọn r phần tử từ n phần tử', N'Số cách sắp xếp r phần tử từ n phần tử', N'Số cách chọn r phần tử từ n phần tử theo thứ tự', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1206, 168, N'"Trong Java, từ khóa ""final"" được sử dụng để làm gì?"', N'Đánh dấu một biến là hằng số', N'Chỉ định một phương thức không thể được ghi đè', N'Kết thúc một vòng lặp', N'Cả a và b đúng', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1207, 168, N'Interface trong Java là gì?', N'Một lớp cụ thể', N'Một biến đối tượng', N'Một khối mã lệnh', N'Một tập hợp các phương thức trừu tượng', 3, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1208, 168, N'Trong Java, cách nào sử dụng để xử lý ngoại lệ?', N'Try-catch', N'If-else', N'Switch', N'While', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1209, 168, N'Đối tượng nào trong Java chịu trách nhiệm thu gom bộ nhớ không sử dụng?', N'Garbage Collector', N'Destructor', N'MemoryManager', N'MemoryCleaner', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1210, 168, N'"Từ khóa ""this"" trong Java được sử dụng để làm gì?"', N'Gọi một phương thức tĩnh', N'Tham chiếu đến đối tượng hiện tại', N'Tạo một đối tượng mới', N'Gọi một phương thức của đối tượng khác', 2, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1211, 168, N'Trong Java, cách khởi tạo một mảng có kích thước cố định là gì?', N'int[] arr = new int[]', N'int arr[] = new int[]', N'int[] arr = new int[10]', N'int arr[10]', 3, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1212, 168, N'Lớp nào là lớp cha của tất cả các lớp trong Java?', N'Base', N'Root', N'Object', N'Main', 3, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1213, 168, N'Trong Java, cách nào để chấp nhận đối số dòng lệnh khi chạy chương trình?', N'Command-line arguments', N'System arguments', N'Input arguments', N'Program arguments', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1214, 168, N'Java là ngôn ngữ lập trình hướng đối tượng. Đặc điểm nào sau đây không đúng về OOP trong Java?', N'Đa kế thừa', N'Đóng gói', N'Đa hình', N'Trừu tượng', 1, 0)
INSERT [dbo].[Question] ([id_question], [Id_Exam], [question], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [Correct_Answer], [Status]) VALUES (1215, 168, N'"Trong Java, lệnh ""break"" được sử dụng trong ngữ cảnh nào?"', N'Trong vòng lặp', N'Trong cấu trúc điều kiện', N'Trong phương thức', N'Cả a, b và c', 3, 0)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 


INSERT [dbo].[Users] ([Id_User], [username], [password], [fullname], [email], [phone_number]) VALUES (50, N'1', N'1', N'Nguyễn Hoàng Thắng', N'user1@gmail.com', N'0942909123')
INSERT [dbo].[Users] ([Id_User], [username], [password], [fullname], [email], [phone_number]) VALUES (51, N'2', N'3', N'2', N'2', N'2')
INSERT [dbo].[Users] ([Id_User], [username], [password], [fullname], [email], [phone_number]) VALUES (52, N'4', N'5', N'4', N'4', N'4')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
USE [master]
GO
ALTER DATABASE [QuanLyAppTracNghiem] SET  READ_WRITE 
GO
