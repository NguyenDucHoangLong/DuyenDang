USE [master]
GO
/****** Object:  Database [DUYENDANGDB]    Script Date: 4/3/2016 11:16:55 pm ******/
CREATE DATABASE [DUYENDANGDB]
 CONTAINMENT = NONE
GO
ALTER DATABASE [DUYENDANGDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DUYENDANGDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DUYENDANGDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DUYENDANGDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DUYENDANGDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DUYENDANGDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DUYENDANGDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DUYENDANGDB] SET  MULTI_USER 
GO
ALTER DATABASE [DUYENDANGDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DUYENDANGDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DUYENDANGDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DUYENDANGDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DUYENDANGDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DUYENDANGDB]
GO
/****** Object:  Table [dbo].[album]    Script Date: 4/3/2016 11:16:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[album](
	[id] [int] NOT NULL,
	[image] [nvarchar](max) NULL,
	[catalogeId] [int] NULL,
 CONSTRAINT [PK_album] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cataloge]    Script Date: 4/3/2016 11:16:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cataloge](
	[id] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[image] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[show] [bit] NULL,
 CONSTRAINT [PK_cataloge] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[information]    Script Date: 4/3/2016 11:16:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[information](
	[id] [int] NOT NULL,
	[title] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[image] [nvarchar](max) NULL,
	[catalogeId] [int] NULL,
 CONSTRAINT [PK_information] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user]    Script Date: 4/3/2016 11:16:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] NOT NULL,
	[name] [nchar](50) NULL,
	[password] [nvarchar](max) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[album] ([id], [image], [catalogeId]) VALUES (1, N'thumb-02.jpg', 3)
INSERT [dbo].[album] ([id], [image], [catalogeId]) VALUES (2, N'thumb-02.jpg', 3)
INSERT [dbo].[album] ([id], [image], [catalogeId]) VALUES (3, N'thumb-02.jpg', 3)
INSERT [dbo].[album] ([id], [image], [catalogeId]) VALUES (4, N'thumb-02.jpg', 3)
INSERT [dbo].[album] ([id], [image], [catalogeId]) VALUES (5, N'thumb-02.jpg', 3)
INSERT [dbo].[album] ([id], [image], [catalogeId]) VALUES (6, N'thumb-02.jpg', NULL)
INSERT [dbo].[cataloge] ([id], [name], [image], [description], [show]) VALUES (1, N'home', N'pic1.jpg', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras hendrerit sagittis arcu ac hendrerit. Nulla vitae congue turpis, ut rutrum sapien. Donec quis venenatis nisl. Proin enim massa, euismod eu nulla at, gravida sollicitudin dolor. In pellentesque bibendum arcu, id ornare mi ultricies non. In mauris ipsum, pellentesque vel erat eget, luctus convallis nibh. 

Donec hendrerit in nulla nec dignissim. Morbi mattis, quam nec lobortis luctus, dui mauris iaculis sem, ac laoreet urna odio sit amet eros. Phasellus sodales fermentum libero quis vestibulum. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. 

Curabitur mattis turpis sit amet magna venenatis, efficitur pharetra eros dapibus. Class aptent taci ti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Suspendisse tincidunt.', 0)
INSERT [dbo].[cataloge] ([id], [name], [image], [description], [show]) VALUES (2, N'photobook', N'pic1.png', N'Integer volutpat hendrerit libero id laor eet. Etiam risus ipsum, cursus ut pretiu m ac, sollicitudin vel lorem. Sed in fauci bus urna, ac scelerisque justo.', 1)
INSERT [dbo].[cataloge] ([id], [name], [image], [description], [show]) VALUES (3, N'baby', N'pic2.png', N'Integer volutpat hendrerit libero id laor eet. Etiam risus ipsum, cursus ut pretiu m ac, sollicitudin vel lorem. Sed in fauci bus urna, ac scelerisque justo.', 1)
INSERT [dbo].[cataloge] ([id], [name], [image], [description], [show]) VALUES (4, N'calendar', N'pic3.png', N'Integer volutpat hendrerit libero id laor eet. Etiam risus ipsum, cursus ut pretiu m ac, sollicitudin vel lorem. Sed in fauci bus urna, ac scelerisque justo.', 1)
INSERT [dbo].[cataloge] ([id], [name], [image], [description], [show]) VALUES (5, N'signaturebook', N'pic4.png', N'Integer volutpat hendrerit libero id laor eet. Etiam risus ipsum, cursus ut pretiu m ac, sollicitudin vel lorem. Sed in fauci bus urna, ac scelerisque justo.', 1)
INSERT [dbo].[cataloge] ([id], [name], [image], [description], [show]) VALUES (6, N'ecard', N'pic5.png', N'Integer volutpat hendrerit libero id laor eet. Etiam risus ipsum, cursus ut pretiu m ac, sollicitudin vel lorem. Sed in fauci bus urna, ac scelerisque justo.', 1)
INSERT [dbo].[cataloge] ([id], [name], [image], [description], [show]) VALUES (7, N'cardvisit', N'pic6.png', N'Integer volutpat hendrerit libero id laor eet. Etiam risus ipsum, cursus ut pretiu m ac, sollicitudin vel lorem. Sed in fauci bus urna, ac scelerisque justo.', 1)
INSERT [dbo].[cataloge] ([id], [name], [image], [description], [show]) VALUES (8, N'price', NULL, NULL, 0)
INSERT [dbo].[information] ([id], [title], [description], [image], [catalogeId]) VALUES (1, NULL, N'Là một kiểu album khái niệm mới. Được hiểu như một loại SÁCH ẢNH, để ghi chép lại các câu truyện của bạn theo dạng hình ảnh. 
Với chất lượng in ảnh hiện đại trên nhiều loại giấy cao cấp, giúp chất lượng hình ảnh chân thật hơn và không phai màu theo thời gian.', N'book1.jpg', 2)
INSERT [dbo].[information] ([id], [title], [description], [image], [catalogeId]) VALUES (2, NULL, N'Photobook có thể dành cho tất cả các chủ đề. Ví dụ: để ghi nhớ các sự kiện như đi du lịch hay đi nghỉ, vũ hội, đám cưới, sinh nhật, ảnh cưới, cuốn sách ảnh em bé, sách ảnh tốt nghiệp, album ảnh gia đình của năm mới, ... 
Đối với các doanh nghiệp có thể sử dụng sách ảnh để thực hiện các kiểu catologue sang trọng, bắt mắt với khách hành và đối tác.', N'book2.png', 2)
INSERT [dbo].[information] ([id], [title], [description], [image], [catalogeId]) VALUES (3, NULL, N'Photobook có nhiều kiểu trình bày và tùy vào chất lượng giấy in mà bạn chọn, gồm hai kiểu nói chung sau:
- Photobook kiểu tạp chí: là loại sách thông dụng nhất, với chất liệu giấy mỏng, gọn nhẹ, không phai màu theo thời gian.
- Photobook kiểu mở phẳng: được đóng cuốn với phương pháp mở phẳng, hình ảnh sẽ không bị che khuất bởi gáy sách. Chất liệu giấy bền chắc, từng trang giấy được phủ 2 lớp màng không thấm nước.', N'book-3.jpg', 2)
INSERT [dbo].[user] ([id], [name], [password]) VALUES (1, N'admin                                             ', N'123456X@x')
ALTER TABLE [dbo].[album]  WITH CHECK ADD  CONSTRAINT [FK_album_cataloge] FOREIGN KEY([catalogeId])
REFERENCES [dbo].[cataloge] ([id])
GO
ALTER TABLE [dbo].[album] CHECK CONSTRAINT [FK_album_cataloge]
GO
ALTER TABLE [dbo].[information]  WITH CHECK ADD  CONSTRAINT [FK_information_cataloge] FOREIGN KEY([catalogeId])
REFERENCES [dbo].[cataloge] ([id])
GO
ALTER TABLE [dbo].[information] CHECK CONSTRAINT [FK_information_cataloge]
GO
USE [master]
GO
ALTER DATABASE [DUYENDANGDB] SET  READ_WRITE 
GO
