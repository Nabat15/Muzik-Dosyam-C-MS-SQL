USE [muzikDosyam]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 18.5.2021 13:13:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[adminAdi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
	[ulke] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_admin_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[album]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[album](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[albumAdi] [nvarchar](50) NOT NULL,
	[tarih] [datetime] NOT NULL,
 CONSTRAINT [PK_album] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[album_sanatci]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[album_sanatci](
	[sanatciId] [int] NOT NULL,
	[albumId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[calmaListesi]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calmaListesi](
	[kullaniciId] [int] NOT NULL,
	[sarkiId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
	[abonelikTuru] [nvarchar](50) NOT NULL,
	[ulke] [nvarchar](50) NOT NULL,
	[odendiBilgisi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_kullanici] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sanatci]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sanatci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[sanatciAdi] [varchar](50) NOT NULL,
	[ulke] [varchar](50) NOT NULL,
 CONSTRAINT [PK_sanatci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sarki]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sarki](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[albumId] [int] NOT NULL,
	[sarkiAdi] [varchar](50) NOT NULL,
	[tarih] [datetime] NOT NULL,
	[turId] [int] NOT NULL,
	[sure] [int] NOT NULL,
	[dinlenmeSayisi] [int] NOT NULL,
 CONSTRAINT [PK_sarki_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sarki_sanatci]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sarki_sanatci](
	[sanatciId] [int] NOT NULL,
	[sarkiId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[takipci]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[takipci](
	[takipId] [int] NOT NULL,
	[takipciId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tur]    Script Date: 18.5.2021 13:13:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tur](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[turAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tur] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[admin] ON 

INSERT [dbo].[admin] ([Id], [adminAdi], [email], [sifre], [ulke]) VALUES (1, N'furkan', N'Yilmaz-1998@hotmail.com', N'f1998', N'Turkiye')
INSERT [dbo].[admin] ([Id], [adminAdi], [email], [sifre], [ulke]) VALUES (2, N'cihan', N'cihan.sahin@msn.com ', N'sahin11', N'Türkiye')
SET IDENTITY_INSERT [dbo].[admin] OFF
SET IDENTITY_INSERT [dbo].[album] ON 

INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (2, N'aacayipsin', CAST(N'1994-06-25 00:00:00.000' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (3, N'almora', CAST(N'2000-03-21 00:00:00.000' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (4, N'Beethoven', CAST(N'1956-06-12 00:00:00.000' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (5, N'Witchdoctor''s Son', CAST(N'1976-01-27 00:00:00.000' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (9, N'ya tabtab', CAST(N'2021-05-27 21:46:29.000' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (12, N'Ruhun Gülü', CAST(N'2021-05-15 12:42:01.957' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (13, N'Nazdarovya', CAST(N'2021-05-15 12:42:01.957' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (14, N'Üç noktanın biri', CAST(N'2021-05-15 12:42:01.957' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (15, N'Gokkuşağı', CAST(N'2021-05-15 12:42:01.957' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (16, N'Habibi', CAST(N'2021-05-15 12:42:01.957' AS DateTime))
INSERT [dbo].[album] ([Id], [albumAdi], [tarih]) VALUES (17, N'Habibi', CAST(N'2021-05-15 12:42:01.957' AS DateTime))
SET IDENTITY_INSERT [dbo].[album] OFF
INSERT [dbo].[album_sanatci] ([sanatciId], [albumId]) VALUES (26, 13)
INSERT [dbo].[album_sanatci] ([sanatciId], [albumId]) VALUES (23, 13)
INSERT [dbo].[album_sanatci] ([sanatciId], [albumId]) VALUES (2, 2)
INSERT [dbo].[album_sanatci] ([sanatciId], [albumId]) VALUES (22, 13)
INSERT [dbo].[album_sanatci] ([sanatciId], [albumId]) VALUES (21, 13)
INSERT [dbo].[album_sanatci] ([sanatciId], [albumId]) VALUES (30, 15)
INSERT [dbo].[album_sanatci] ([sanatciId], [albumId]) VALUES (32, 14)
INSERT [dbo].[album_sanatci] ([sanatciId], [albumId]) VALUES (3, 4)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (74, 7)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (74, 24)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (74, 22)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (74, 25)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (74, 12)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (74, 15)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (74, 19)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (74, 18)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (8, 12)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (8, 13)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (8, 18)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (8, 19)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 12)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 15)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 39)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 24)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 13)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 18)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 19)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 32)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (67, 36)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (70, 7)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (70, 18)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (70, 5)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (1, 7)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (1, 15)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (1, 18)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (1, 19)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (1, 24)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (5, 5)
INSERT [dbo].[calmaListesi] ([kullaniciId], [sarkiId]) VALUES (5, 12)
SET IDENTITY_INSERT [dbo].[kullanici] ON 

INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (1, N'furkan', N'fh', N'furkan', N'Premium', N'Turkiye', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (2, N'Nataşa', N'pio', N'nataşa', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (3, N'Nisa', N'ds', N'nisa', N' Normal', N'Turkiye', N'odenmedi  ')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (4, N'Maya', N'fd', N'maya', N'Premium', N'Azarbaycan', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (5, N'melis', N'df', N'melis', N'Premium', N'Turkiye', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (7, N'lale', N'lale@gmail.com', N'lale1', N'Premium', N'Kazakistan', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (8, N'Ali', N'ali@mail.tr', N'ali', N'Normal', N'Turkiye', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (9, N'Alim', N'ali@mail.tr', N'alim', N'Premium', N'Turkiye', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (10, N'Mert', N'Mert@', N'Mert', N'Premium', N'Turkiye', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (11, N'begüm', N'tttt', N'begüm', N'Normal', N'Fransa', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (12, N'Meltem', N'kkk', N'meltem', N'Normal', N'Fransa', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (13, N'Ahmet', N'ahmet@gmail.com', N'ahmet', N'Premium', N'Dubai', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (14, N'Ruslan', N'Ruslan@mail.ru', N'Ruslan', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (15, N'Burcu', N'ruslan@mail.ru', N'burcu', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (16, N'Kerem', N'ruslan@mail.ru', N'Kerem', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (17, N'Maysa', N'ruslan@mail.ru', N'maysa', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (18, N'Bulut', N'ruslan@mail.ru', N'bulut', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (19, N'Tanya', N'ruslan@mail.ru', N'tanya', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (20, N'Maksim', N'ruslan@mail.ru', N'maksim', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (21, N'Nurgul', N'ruslan@mail.ru', N'nurgul', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (22, N'Sebastiyan', N'ruslan@mail.ru', N'sebastiyan', N'Normal', N'Rusya', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (23, N'Sancar', N'ruslan@mail.ru', N'sancar', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (24, N'Dudu', N'ruslan@mail.ru', N'dudu', N'Normal', N'Rusya', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (25, N'Cennet', N'ruslan@mail.ru', N'cennet', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (26, N'caner', N'ruslan@mail.ru', N'caner', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (27, N'Onur', N'ruslan@mail..ru', N'onur', N'Normal', N'Rusya', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (28, N'Şeyma', N'gggg', N'şeyma', N'Normal', N'Almanya', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (29, N'Kubra', N'ddd', N'Kubra', N'Normal', N'Fransa', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (30, N'Nataşa', N'nataşa@mail.ru', N'natşa', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (31, N'Jhon', N'jhon@mail.com', N'jhon', N'Premium', N'Almanya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (32, N'Anna', N'anna@mail.com', N'annna', N'Premium', N'ABD', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (34, N'Ayşe', N'n', N'Ayşe', N'Normal', N'Fransa', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (35, N'Songul', N'b', N'songul', N'Normal', N'ABD', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (36, N'Rumeysa', N'b', N'rumeysa', N'Premium', N'ABD', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (37, N'Selin', N'c', N'selin', N'Premium', N'Dubai', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (38, N'Tayfun', N'z', N'tayfun', N'Premium', N'Dubai', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (39, N'Acun', N'v', N'acun', N'Premium', N'ABD', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (40, N'MAnolya', N'c', N'manolya', N'Normal', N'ABD', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (41, N'Safiye', N's', N'safiye', N'Premium', N'ABD', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (42, N'Melih', N'axa', N'melih', N'Premium', N'Almanya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (43, N'Rukiye', N'c', N'rukiye', N'Premium', N'ABD', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (44, N'Olya', N'c', N'olya', N'Premium', N'Almanya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (45, N'berk', N'c', N'berk', N'Premium', N'Dubai', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (46, N'Doru', N'm', N'doru', N'Premium', N'Almanya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (47, N'kemal', N'b', N'kemal', N'Premium', N'ABD', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (48, N'şahin', N'v', N'şahin', N'Normal', N'ABD', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (58, N'diyar', N'c', N'diyar', N'Premium', N'Fransa', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (64, N'Rita', N'rita@mail.com', N'rita', N'Normal', N'Rusya', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (65, N'Saşa', N'saşa@mail.com', N'rita', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (66, N'Mess', N'mess@mail.com', N'mess', N'Premium', N'ABD', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (67, N'Turgut', N'turgut@mail.com', N'turgut', N'Premium', N'Turkiye', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (68, N'Hanna', N'hanna@mail.com', N'hanna', N'Normal', N'ABD', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (69, N'Özge', N'özge@mail.com', N'özge', N'Premium', N'Turkiye', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (70, N'Roma', N'roma@mail.com', N'roms', N'Normal', N'Rusya', N'odenmedi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (71, N'maşa', N'maşa', N'maşa', N'Premium', N'Rusya', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (72, N'Cem', N'cem@mail.com', N'cem', N'Premium', N'Turkiye', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (73, N'Soner', N'sener@mail.com', N'soner', N'Premium', N'Turkiye', N'odendi')
INSERT [dbo].[kullanici] ([Id], [kullaniciAdi], [email], [sifre], [abonelikTuru], [ulke], [odendiBilgisi]) VALUES (74, N'rustam', N'rustam@mail.com', N'rustam', N'Premium', N'Rusya', N'odendi')
SET IDENTITY_INSERT [dbo].[kullanici] OFF
SET IDENTITY_INSERT [dbo].[sanatci] ON 

INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (2, N'Sezen Aksu', N'Turkiye')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (3, N'Nancy Ajram', N'Arabistan')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (4, N'Tarkan', N'Türkiye')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (5, N'Ludwig van Beethoven', N'Almanya')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (6, N'Soner Canozer', N'Türkiye')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (21, N'Alla Pugaceva', N'Rusya')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (22, N'Filip', N'Rusya')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (23, N'Maksim Galkin', N'Rusya')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (25, N'Zeki Muren', N'Tükiye')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (26, N'Sergey Lazerev', N'Rusya')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (27, N'Munisa Rızayeve', N'Özbekistan')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (28, N'Hulker Rahmaullayeva', N'Özbekistan')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (29, N'Shahzoda', N'Özbekistan')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (30, N'Michael Jackson', N'ABD')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (32, N'Louis Armstrong', N'ABD')
INSERT [dbo].[sanatci] ([Id], [sanatciAdi], [ulke]) VALUES (33, N'Miles Davis', N'ABD')
SET IDENTITY_INSERT [dbo].[sanatci] OFF
SET IDENTITY_INSERT [dbo].[sarki] ON 

INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (5, 9, N'Rüzgarın Kızı', CAST(N'1809-02-15 00:00:00.000' AS DateTime), 2, 5, 19)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (7, 3, N'rüzgarün kızı', CAST(N'2008-06-09 00:00:00.000' AS DateTime), 3, 5, 7)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (12, 2, N'Rüzgarın Kızı', CAST(N'1979-03-05 00:00:00.000' AS DateTime), 2, 2, 52)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (13, 5, N'şark gezintileri', CAST(N'1976-02-24 00:00:00.000' AS DateTime), 2, 8, 15)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (15, 2, N'kuzu kuzu', CAST(N'2021-05-11 19:24:00.930' AS DateTime), 1, 3, 12)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (18, 9, N'tab tab', CAST(N'2021-05-26 21:45:09.000' AS DateTime), 1, 5, 3)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (19, 9, N'VAVA', CAST(N'2021-05-13 17:55:21.110' AS DateTime), 1, 2, 5)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (21, 16, N'Habibi', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 1, 3, 5)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (22, 16, N'Qaynona', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 1, 3, 1)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (23, 16, N'All Alone', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 1, 3, 1)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (24, 16, N'Chiccita', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 1, 3, 1)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (25, 13, N'Pozovi menya s soboy', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 3, 3, 42)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (26, 13, N'Millions Of Scarlet Roses', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 3, 3, 4)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (27, 13, N'Gezi Bagı', CAST(N'2021-05-16 21:14:06.627' AS DateTime), 3, 3, 5)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (28, 13, N'Lyubov', CAST(N'2021-05-16 21:14:06.627' AS DateTime), 3, 2, 13)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (29, 13, N'mechta', CAST(N'2021-05-16 21:14:06.627' AS DateTime), 3, 2, 13)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (31, 15, N'Billie Jean', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 1, 2, 13)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (32, 15, N'Smooth Criminal', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 1, 2, 125)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (33, 15, N'Beat It', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 1, 2, 127)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (34, 14, N'What a Wonderful World', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 2, 2, 125)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (35, 14, N'La Vie En Rose', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 2, 2, 125)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (36, 14, N'Basin Street Blues', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 2, 2, 125)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (38, 14, N'Blue in Green', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 2, 2, 121)
INSERT [dbo].[sarki] ([Id], [albumId], [sarkiAdi], [tarih], [turId], [sure], [dinlenmeSayisi]) VALUES (39, 14, N'All Blues', CAST(N'2021-05-15 12:54:15.347' AS DateTime), 2, 2, 121)
SET IDENTITY_INSERT [dbo].[sarki] OFF
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (2, 5)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (2, 7)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (2, 12)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (4, 21)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (4, 22)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (4, 23)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (5, 24)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (5, 25)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (2, 26)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (6, 5)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (6, 7)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (21, 21)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (22, 25)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (22, 31)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (23, 32)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (23, 33)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (23, 34)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (2, 35)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (22, 36)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (6, 38)
INSERT [dbo].[sarki_sanatci] ([sanatciId], [sarkiId]) VALUES (21, 38)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (1, 2)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (2, 1)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (1, 5)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (1, 10)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (4, 10)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (4, 69)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (11, 69)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (11, 4)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (74, 74)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (74, 71)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (74, 69)
INSERT [dbo].[takipci] ([takipId], [takipciId]) VALUES (74, 1)
SET IDENTITY_INSERT [dbo].[tur] ON 

INSERT [dbo].[tur] ([Id], [turAdi]) VALUES (1, N'pop')
INSERT [dbo].[tur] ([Id], [turAdi]) VALUES (2, N'jazq')
INSERT [dbo].[tur] ([Id], [turAdi]) VALUES (3, N'klasik')
SET IDENTITY_INSERT [dbo].[tur] OFF
ALTER TABLE [dbo].[album_sanatci]  WITH CHECK ADD  CONSTRAINT [FK_album_sanatci_album] FOREIGN KEY([albumId])
REFERENCES [dbo].[album] ([Id])
GO
ALTER TABLE [dbo].[album_sanatci] CHECK CONSTRAINT [FK_album_sanatci_album]
GO
ALTER TABLE [dbo].[album_sanatci]  WITH CHECK ADD  CONSTRAINT [FK_album_sanatci_sanatci] FOREIGN KEY([sanatciId])
REFERENCES [dbo].[sanatci] ([Id])
GO
ALTER TABLE [dbo].[album_sanatci] CHECK CONSTRAINT [FK_album_sanatci_sanatci]
GO
ALTER TABLE [dbo].[calmaListesi]  WITH CHECK ADD  CONSTRAINT [FK_calmaListesi_kullanici] FOREIGN KEY([kullaniciId])
REFERENCES [dbo].[kullanici] ([Id])
GO
ALTER TABLE [dbo].[calmaListesi] CHECK CONSTRAINT [FK_calmaListesi_kullanici]
GO
ALTER TABLE [dbo].[calmaListesi]  WITH CHECK ADD  CONSTRAINT [FK_calmaListesi_sarki] FOREIGN KEY([sarkiId])
REFERENCES [dbo].[sarki] ([Id])
GO
ALTER TABLE [dbo].[calmaListesi] CHECK CONSTRAINT [FK_calmaListesi_sarki]
GO
ALTER TABLE [dbo].[sarki]  WITH CHECK ADD  CONSTRAINT [FK_sarki_album] FOREIGN KEY([albumId])
REFERENCES [dbo].[album] ([Id])
GO
ALTER TABLE [dbo].[sarki] CHECK CONSTRAINT [FK_sarki_album]
GO
ALTER TABLE [dbo].[sarki]  WITH CHECK ADD  CONSTRAINT [FK_sarki_tur] FOREIGN KEY([turId])
REFERENCES [dbo].[tur] ([Id])
GO
ALTER TABLE [dbo].[sarki] CHECK CONSTRAINT [FK_sarki_tur]
GO
ALTER TABLE [dbo].[sarki_sanatci]  WITH CHECK ADD  CONSTRAINT [FK_sarki_sanatci_sanatci] FOREIGN KEY([sanatciId])
REFERENCES [dbo].[sanatci] ([Id])
GO
ALTER TABLE [dbo].[sarki_sanatci] CHECK CONSTRAINT [FK_sarki_sanatci_sanatci]
GO
ALTER TABLE [dbo].[sarki_sanatci]  WITH CHECK ADD  CONSTRAINT [FK_sarki_sanatci_sarki] FOREIGN KEY([sarkiId])
REFERENCES [dbo].[sarki] ([Id])
GO
ALTER TABLE [dbo].[sarki_sanatci] CHECK CONSTRAINT [FK_sarki_sanatci_sarki]
GO
ALTER TABLE [dbo].[takipci]  WITH CHECK ADD  CONSTRAINT [FK_takipci_kullanici] FOREIGN KEY([takipId])
REFERENCES [dbo].[kullanici] ([Id])
GO
ALTER TABLE [dbo].[takipci] CHECK CONSTRAINT [FK_takipci_kullanici]
GO
ALTER TABLE [dbo].[takipci]  WITH CHECK ADD  CONSTRAINT [FK_takipci_kullanici1] FOREIGN KEY([takipciId])
REFERENCES [dbo].[kullanici] ([Id])
GO
ALTER TABLE [dbo].[takipci] CHECK CONSTRAINT [FK_takipci_kullanici1]
GO
