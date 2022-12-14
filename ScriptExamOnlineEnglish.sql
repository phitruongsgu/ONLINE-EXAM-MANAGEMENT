/****** Object:  Table [dbo].[Examinations]    Script Date: 20/09/2021 4:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examinations](
	[AutoId] [int] IDENTITY(1,1) NOT NULL,
	[ExaminationId] [varchar](256) NOT NULL,
	[Month] [varchar](256) NOT NULL,
	[Description] [varchar](256) NULL,
	[LevelName] [varchar](256) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examinees]    Script Date: 20/09/2021 4:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examinees](
	[AutoId] [int] IDENTITY(1,1) NOT NULL,
	[ExamineeId] [varchar](256) NOT NULL,
	[FullName] [nvarchar](256) NULL,
	[DoB] [varchar](256) NULL,
	[CardId] [varchar](256) NOT NULL,
	[Email] [varchar](256) NULL,
	[Phone] [varchar](256) NOT NULL,
	[ExaminationId] [varchar](256) NOT NULL,
	[RoomName] [varchar](256) NULL,
	[CodeId] [varchar](256) NULL,
	[DateSign] [varchar](256) NULL,
	[Gender] [nvarchar](256) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Levels]    Script Date: 20/09/2021 4:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Levels](
	[AutoId] [int] IDENTITY(1,1) NOT NULL,
	[LevelName] [varchar](256) NOT NULL,
	[Description] [nvarchar](256) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Results]    Script Date: 20/09/2021 4:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Results](
	[AutoId] [int] IDENTITY(1,1) NOT NULL,
	[ResultId] [varchar](256) NOT NULL,
	[ExamineeId] [varchar](256) NOT NULL,
	[ListenGrade] [float] NULL,
	[SpeakGrade] [float] NULL,
	[ReadGrade] [float] NULL,
	[WriteGrade] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 20/09/2021 4:16:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[AutoId] [int] IDENTITY(1,1) NOT NULL,
	[RoomName] [varchar](256) NOT NULL,
	[Description] [nvarchar](256) NULL,
	[Total] [int] NULL,
	[DateExam] [varchar](256) NULL,
	[ExaminationId] [varchar](256) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Examinations] ON 

INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (1, N'A2-01', N'1', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (2, N'A2-02', N'2', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (5, N'A2-03', N'3', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (6, N'A2-04', N'4', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (7, N'A2-05', N'5', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (8, N'A2-06', N'6', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (9, N'A2-07', N'7', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (10, N'A2-08', N'8', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (11, N'A2-09', N'9', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (12, N'A2-10', N'10', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (13, N'A2-11', N'11', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (14, N'A2-12', N'12', NULL, N'A2')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (15, N'B1-01', N'1', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (16, N'B1-02', N'2', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (17, N'B1-03', N'3', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (18, N'B1-04', N'4', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (19, N'B1-05', N'5', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (20, N'B1-06', N'6', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (21, N'B1-07', N'7', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (22, N'B1-08', N'8', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (23, N'B1-09', N'9', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (24, N'B1-10', N'10', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (25, N'B1-11', N'11', NULL, N'B1')
INSERT [dbo].[Examinations] ([AutoId], [ExaminationId], [Month], [Description], [LevelName]) VALUES (26, N'B1-12', N'12', NULL, N'B1')
SET IDENTITY_INSERT [dbo].[Examinations] OFF
GO
SET IDENTITY_INSERT [dbo].[Examinees] ON 

INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (5, N'XRCHPBB6ING8M2YJPH', N'Trần Thị Thiên Tú', N'12/09/1999', N'012471856', N'thientu@gmail.com', N'0784127569', N'A2-01', N'A2P01', N'3117410111', N'15/09/2021 1:55:29 AM', N'Nữ')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (6, N'MNQMIEJTYLGNNLW25P', N'Nguyễn Thị Mỹ Dung', N'23/05/2000', N'023112009', N'mydung@gmail.com', N'0992928177', N'A2-01', N'A2P01', N'3118410113', N'15/09/2021 1:55:29 AM', N'Nữ')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (7, N'SUMH1Q9WLIZZVN9PLL', N'Trần Kim Thanh Hải', N'13/06/2000', N'082949192', N'thanhhai@gmail.com', N'0909992019', N'A2-12', N'B1P02', N'3118410145', N'01/09/2021 1:55:29 AM', N'Nam')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (8, N'SUMH1Q9WLIZZVNKI29', N'Lê Văn Đạt', N'01/09/1999', N'928192819', N'vandat@gmail.com', N'0298883727', N'B1-01', N'A2P011', N'3117410066', N'13/09/2021 1:55:29 AM', N'Nam')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (9, N'6U18O2DWNIPPEO9ZI7', N'Trương Thị Tuyết Vân', N'13/09/2000', N'291029102', N'tuyetvan@gmail.com', N'0299182918', N'A2-01', N'A2P01', N'3118410466', N'14/09/2021 1:55:29 AM', N'Nữ')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (10, N'LJM8XI3KFBVTP4GVKA', N'Nguyễn Trọng Đạt', N'10/05/1998', N'123456789', N'datnguyen@gmail.com', N'0291729182', N'A2-01', N'A2P01', N'3116410015', N'12/09/2021 1:55:29 AM', N'Nam')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (11, N'4GPVA0GMVEQ8R968YA', N'Hồ Thị Thắm', N'15/12/2000', N'123451231', N'thamho@gmail.com', N'0998271817', N'A2-03', N'A2P016', N'3118410445', N'10/09/2021 1:55:29 AM', N'Nữ')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (12, N'O3XJWVNG0HRCXE01EO', N'Đỗ Dự Phúc', N'20/07/2000', N'231312312', N'duphuc@gmail.com', N'0123827192', N'A2-01', N'A2P018', N'3118410422', N'15/09/2021 1:55:29 AM', N'Nam')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (13, N'CCUY5RWANTLJN5QKQ4', N'Nguyễn Thị Vân Trang', N'17/03/2000', N'213123412', N'vantrang@gmail.com', N'0987654321', N'A2-07', N'A2P018', N'3118410446', N'12/09/2021 1:55:29 AM', N'Nữ')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (14, N'74cee83f-01e6-4418-a83e-efe6d581080f', N'Nguyễn Vũ Phi Trường', N'30/11/2000', N'127823123', N'truong30112000@gmail.com', N'0286671987', N'A2-09', N'A2P013', N'3118410458', N'17/09/2021 9:53:08 PM', N'Nam')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (15, N'b129abff-0eaf-41fc-85cf-3a8b64c88631', N'Lê Hải Đăng', N'07/09/2002', N'123073123', N'haidang@gmail.com', N'0286671962', N'A2-09', N'A2P01', N'3118410016', N'16/09/2021 9:53:40 PM', N'Nam')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (16, N'bcd29e92-9479-4dd2-8330-2a7d56bc907e', N'Lý Xuân Trúc', N'01/12/1999', N'123123123', N'xuantruc@gmail.com', N'0286671728', N'A2-09', N'A2P013', N'3117410450', N'12/09/2021 10:03:50 PM', N'Nữ')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (17, N'fba2e289-f128-449a-9fdf-c3f66ff8f5ee', N'Bùi Thị Kiều Loan', N'16/09/2000', N'126472312', N'kieuloan@gmail.com', N'0272891829', N'A2-09', N'A2P010', N'3118410145', N'16/09/2021 10:08:34 PM', N'Nữ')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (18, N'afc240b1-ce97-4f7b-b9bf-89db084b7394', N'Cao Trúc Huyền Anh', N'28/07/1999', N'028192819', N'huyenanh@gmail.com', N'0779874774', N'A2-09', N'A2P019', N'3117410005', N'13/09/2021 12:21:50 AM', N'Nữ')
INSERT [dbo].[Examinees] ([AutoId], [ExamineeId], [FullName], [DoB], [CardId], [Email], [Phone], [ExaminationId], [RoomName], [CodeId], [DateSign], [Gender]) VALUES (19, N'e0016677-d4bc-4b0e-add8-597ae313851e', N'Nguyễn Tuấn Khoa', N'18/09/2001', N'281729197', N'tuankhoa@gmail.com', N'09827119817', N'B1-10', N'A2P06', N'3119410113', N'09/09/2021 1:55:29 AM', N'Nam')
SET IDENTITY_INSERT [dbo].[Examinees] OFF
GO
SET IDENTITY_INSERT [dbo].[Levels] ON 

INSERT [dbo].[Levels] ([AutoId], [LevelName], [Description]) VALUES (1, N'A2', N'Chứng chỉ tiếng anh trình độ A2')
INSERT [dbo].[Levels] ([AutoId], [LevelName], [Description]) VALUES (2, N'B1', N'Chứng chỉ tiếng anh trình độ B1')
SET IDENTITY_INSERT [dbo].[Levels] OFF
GO
SET IDENTITY_INSERT [dbo].[Results] ON 

INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (1, N'4XUKG8UCLYAEMGBG2H', N'4GPVA0GMVEQ8R968YA', 8, 9, 10, 7)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (3, N'XRCHPBB6IN2jauakkH', N'XRCHPBB6ING8M2YJPH', 6, 7, 5, 6.5)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (4, N'140R4O944ZB96FX0RE', N'O3XJWVNG0HRCXE01EO', 5, 6, 7, 8)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (5, N'47GAAO6FXBEJUUAB72', N'CCUY5RWANTLJN5QKQ4', 9, 8, 7, 6)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (6, N'MNQMIEJTYsadaddd25P', N'MNQMIEJTYLGNNLW25P', 10, 7, 8, 9)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (7, N'6U18O2asdasd29ZI7', N'6U18O2DWNIPPEO9ZI7', 4, 4, 5, 3)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (12, N'c83d363a-ef02-44b4-9e1d-dfaeeec67bec', N'74cee83f-01e6-4418-a83e-efe6d581080f', 7, 8, 9, 8)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (13, N'dc1e36c8-3716-4a9a-9297-9eaafb40bea6', N'b129abff-0eaf-41fc-85cf-3a8b64c88631', 7, 8, 6, 8)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (14, N'058d0790-4f1e-45ba-a51f-1f6ddff0faf3', N'bcd29e92-9479-4dd2-8330-2a7d56bc907e', 4, 3, 2, 1)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (15, N'9ab41676-9b09-4d85-84ff-9e12670032bf', N'fba2e289-f128-449a-9fdf-c3f66ff8f5ee', 8, 7, 6, 7)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (16, N'72114b37-48a2-43fd-ac5f-01b59e368f86', N'afc240b1-ce97-4f7b-b9bf-89db084b7394', 5, 5, 5, 5)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (17, N'6d909479-6cba-4a63-850f-fcd5ec4eaf81', N'e0016677-d4bc-4b0e-add8-597ae313851e', 6, 6, 6, 6)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (8, N'LJM8XI3asdasd2dasdaA', N'LJM8XI3KFBVTP4GVKA', 8, 7, 8, 9)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (9, N'SUMH1QkaiIZZVN9PLL', N'SUMH1Q9WLIZZVN9PLL', 4, 8, 9, 10)
INSERT [dbo].[Results] ([AutoId], [ResultId], [ExamineeId], [ListenGrade], [SpeakGrade], [ReadGrade], [WriteGrade]) VALUES (11, N'SUMH1QdkasdoasodasjdoasdasdjL', N'SUMH1Q9WLIZZVNKI29', 5, 7, 8, 6)
SET IDENTITY_INSERT [dbo].[Results] OFF
GO
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (1, N'A2P01', N'Phòng thi A2P01', 10, N'18/09/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (2, N'B1P02', N'Phòng thi B1P02', 10, N'10/09/2021', N'B1-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (3, N'A2P03', N'Phòng thi A2P03', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (4, N'A2P04', N'Phòng thi A2P04', 10, N'01/10/2021', N'A2-04')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (5, N'A2P05', N'Phòng thi A2P05', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (19, N'A2P019', N'Phòng thi A2P019', 10, N'15/09/2021', N'A2-09')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (20, N'A2P020', N'Phòng thi A2P020', 10, N'01/10/2021', N'A2-09')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (6, N'A2P06', N'Phòng thi A2P06', 10, N'15/09/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (7, N'A2P07', N'Phòng thi A2P07', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (8, N'A2P08', N'Phòng thi A2P08', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (9, N'A2P09', N'Phòng thi A2P09', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (10, N'A2P010', N'Phòng thi A2P010', 10, N'19/09/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (11, N'A2P011', N'Phòng thi A2P011', 10, N'16/09/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (12, N'A2P012', N'Phòng thi A2P012', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (13, N'A2P013', N'Phòng thi A2P013', 10, N'19/09/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (14, N'A2P014', N'Phòng thi A2P014', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (15, N'A2P015', N'Phòng thi A2P015', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (16, N'A2P016', N'Phòng thi A2P016', 10, N'15/09/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (17, N'A2P017', N'Phòng thi A2P017', 10, N'01/10/2021', N'A2-01')
INSERT [dbo].[Rooms] ([AutoId], [RoomName], [Description], [Total], [DateExam], [ExaminationId]) VALUES (18, N'A2P018', N'Phòng thi A2P018', 10, N'16/09/2021', N'A2-01')
SET IDENTITY_INSERT [dbo].[Rooms] OFF
GO
