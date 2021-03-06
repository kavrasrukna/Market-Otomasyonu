USE [master]
GO
/****** Object:  Database [market]    Script Date: 31.5.2022 21:12:42 ******/
CREATE DATABASE [market]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'market', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\market.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'market_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\market_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [market] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [market].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [market] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [market] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [market] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [market] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [market] SET ARITHABORT OFF 
GO
ALTER DATABASE [market] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [market] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [market] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [market] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [market] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [market] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [market] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [market] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [market] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [market] SET  DISABLE_BROKER 
GO
ALTER DATABASE [market] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [market] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [market] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [market] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [market] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [market] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [market] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [market] SET RECOVERY FULL 
GO
ALTER DATABASE [market] SET  MULTI_USER 
GO
ALTER DATABASE [market] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [market] SET DB_CHAINING OFF 
GO
ALTER DATABASE [market] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [market] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [market] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [market] SET QUERY_STORE = OFF
GO
USE [market]
GO
/****** Object:  User [HP_\RÜKNA]    Script Date: 31.5.2022 21:12:42 ******/
CREATE USER [HP_\RÜKNA] FOR LOGIN [HP_\RÜKNA] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_datareader] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [HP_\RÜKNA]
GO
/****** Object:  Table [dbo].[elemanlar]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[elemanlar](
	[elemanno] [int] IDENTITY(1,1) NOT NULL,
	[elemanadi] [varchar](50) NULL,
	[elemanpozisyon] [varchar](50) NULL,
	[elemanmaas] [money] NULL,
	[elemanstatu] [varchar](50) NULL,
	[gorevno] [int] NULL,
 CONSTRAINT [PK_elemanlar] PRIMARY KEY CLUSTERED 
(
	[elemanno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gorevler]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gorevler](
	[gorevno] [int] IDENTITY(1,1) NOT NULL,
	[gorevadi] [varchar](50) NULL,
	[gorevtanimi] [varchar](50) NULL,
	[gorevfiyat] [money] NULL,
	[gorevsuresi] [varchar](50) NULL,
	[gorevdurum] [varchar](50) NULL,
 CONSTRAINT [PK_gorevler] PRIMARY KEY CLUSTERED 
(
	[gorevno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanicilar]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanicilar](
	[kullanicino] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciadi] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[telefon] [char](15) NULL,
 CONSTRAINT [PK_kullanicilar] PRIMARY KEY CLUSTERED 
(
	[kullanicino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[elemanlar] ON 

INSERT [dbo].[elemanlar] ([elemanno], [elemanadi], [elemanpozisyon], [elemanmaas], [elemanstatu], [gorevno]) VALUES (1, N'ali güneş', N'kasaya bakar', 5000.0000, N'stajyer', 1)
INSERT [dbo].[elemanlar] ([elemanno], [elemanadi], [elemanpozisyon], [elemanmaas], [elemanstatu], [gorevno]) VALUES (2, N'kübra şahin', N'reyonları temizler', 4500.0000, N'çalışan', 2)
INSERT [dbo].[elemanlar] ([elemanno], [elemanadi], [elemanpozisyon], [elemanmaas], [elemanstatu], [gorevno]) VALUES (3, N'merve öz', N'manav reyonuyla ilgilenir', 2500.0000, N'çalışan', 2)
INSERT [dbo].[elemanlar] ([elemanno], [elemanadi], [elemanpozisyon], [elemanmaas], [elemanstatu], [gorevno]) VALUES (4, N'ayşe şen', N'sebze reyonuna bakar', 6000.0000, N'stajyer', 2)
SET IDENTITY_INSERT [dbo].[elemanlar] OFF
GO
SET IDENTITY_INSERT [dbo].[gorevler] ON 

INSERT [dbo].[gorevler] ([gorevno], [gorevadi], [gorevtanimi], [gorevfiyat], [gorevsuresi], [gorevdurum]) VALUES (1, N'reyon sorumlusu', N'reyonları düzenler', 1500.0000, N'5', N'daimi')
INSERT [dbo].[gorevler] ([gorevno], [gorevadi], [gorevtanimi], [gorevfiyat], [gorevsuresi], [gorevdurum]) VALUES (2, N'kasa sorumlusu', N'kasa giriş çıkış işlemlerini yapar', 2000.0000, N'8', N'geçici')
INSERT [dbo].[gorevler] ([gorevno], [gorevadi], [gorevtanimi], [gorevfiyat], [gorevsuresi], [gorevdurum]) VALUES (3, N'sebze reyonu', N'sebze reyonundan sorumludur', 2500.0000, N'7', N'daimi')
INSERT [dbo].[gorevler] ([gorevno], [gorevadi], [gorevtanimi], [gorevfiyat], [gorevsuresi], [gorevdurum]) VALUES (4, N'manav reyonu', N'manav reyonundan sorumludur', 3000.0000, N'8', N'geçici')
INSERT [dbo].[gorevler] ([gorevno], [gorevadi], [gorevtanimi], [gorevfiyat], [gorevsuresi], [gorevdurum]) VALUES (5, N'sebze reyonu', N'sebze reyonundan sorumludur', 2500.0000, N'7', N'geçici')
INSERT [dbo].[gorevler] ([gorevno], [gorevadi], [gorevtanimi], [gorevfiyat], [gorevsuresi], [gorevdurum]) VALUES (1005, N'kasa sorumlusu', N'kasa giriş çıkış işlemlerini yapar', 2000.0000, N'8', N'geçici')
SET IDENTITY_INSERT [dbo].[gorevler] OFF
GO
SET IDENTITY_INSERT [dbo].[kullanicilar] ON 

INSERT [dbo].[kullanicilar] ([kullanicino], [kullaniciadi], [sifre], [mail], [telefon]) VALUES (1, N'Rükna', N'1234', N'rukna@gmail.com', N'5392596597     ')
INSERT [dbo].[kullanicilar] ([kullanicino], [kullaniciadi], [sifre], [mail], [telefon]) VALUES (2, N'ayse', N'1515', N'ayse@gmail.com', N'5362965965     ')
INSERT [dbo].[kullanicilar] ([kullanicino], [kullaniciadi], [sifre], [mail], [telefon]) VALUES (1002, N'mehtap', N'1516', N'mehtap@gmail.com', N'5553695968     ')
SET IDENTITY_INSERT [dbo].[kullanicilar] OFF
GO
ALTER TABLE [dbo].[elemanlar]  WITH CHECK ADD  CONSTRAINT [FK_elemanlar_gorevler] FOREIGN KEY([gorevno])
REFERENCES [dbo].[gorevler] ([gorevno])
GO
ALTER TABLE [dbo].[elemanlar] CHECK CONSTRAINT [FK_elemanlar_gorevler]
GO
/****** Object:  StoredProcedure [dbo].[elemanara]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[elemanara] (
@elemanadi varchar(50)
)
as 
begin
select * from elemanlar where elemanadi=@elemanadi
end
GO
/****** Object:  StoredProcedure [dbo].[elemanekle]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[elemanekle](
@elemanadi varchar(50),
@elemanpozisyon varchar(50),
@elemanmaas money,
@elemanstatu varchar(50),
@gorevno int
)
as begin
insert into elemanlar(elemanadi,elemanpozisyon,elemanmaas,elemanstatu,gorevno) values (@elemanadi,@elemanpozisyon,@elemanmaas,@elemanstatu,@gorevno)
end
GO
/****** Object:  StoredProcedure [dbo].[elemanlistele]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[elemanlistele]
as begin
select * from elemanlar
end
GO
/****** Object:  StoredProcedure [dbo].[elemansil]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[elemansil]
@elemanno int
as begin
delete from elemanlar where elemanno=@elemanno
end
GO
/****** Object:  StoredProcedure [dbo].[elemanyenile]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[elemanyenile](
@elemanno int,
@elemanadi varchar(50),
@elemanpozisyon varchar(50),
@elemanmaas money,
@elemanstatu varchar(50),
@gorevno int
)
as begin
update elemanlar set
@elemanadi=@elemanadi,elemanadi=@elemanadi,elemanpozisyon=@elemanpozisyon,elemanmaas=@elemanmaas,elemanstatu=@elemanstatu,gorevno=@gorevno
where elemanno=@elemanno
end
GO
/****** Object:  StoredProcedure [dbo].[gorev1]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gorev1]
as begin
select gorevadi,sum(e.elemanmaas) as 'kasa sorumlusu olan elemanların maaşları toplamı' from gorevler g join elemanlar e on g.gorevno=e.gorevno where e.gorevno=2 group by gorevadi
end
GO
/****** Object:  StoredProcedure [dbo].[gorevara]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gorevara] (
@gorevadi varchar(50)
)
as 
begin
select * from gorevler where gorevadi=@gorevadi
end
GO
/****** Object:  StoredProcedure [dbo].[gorevekle]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gorevekle](
@gorevadi varchar(50),
@gorevtanimi varchar(50),
@gorevfiyat money,
@gorevsuresi varchar(50),
@gorevdurum varchar(50)
)
as begin
insert into gorevler(gorevadi,gorevtanimi,gorevfiyat,gorevsuresi,gorevdurum) values (@gorevadi,@gorevtanimi,@gorevfiyat,@gorevsuresi,@gorevdurum)
end
GO
/****** Object:  StoredProcedure [dbo].[goreveleman]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[goreveleman]
as
begin
select e.elemanadi,e.elemanmaas from gorevler g join elemanlar e on g.gorevno=e.gorevno
where g.gorevno=2 order by e.elemanadi desc
end
GO
/****** Object:  StoredProcedure [dbo].[goreveleman3]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[goreveleman3]
as
begin
select e.elemanadi,e.elemanmaas,gorevdurum from gorevler g join elemanlar e on g.gorevno=e.gorevno
where e.elemanstatu='stajyer' order by gorevdurum desc
end
GO
/****** Object:  StoredProcedure [dbo].[gorevlistele]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gorevlistele]
as begin
select * from gorevler
end
GO
/****** Object:  StoredProcedure [dbo].[gorevmaas]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gorevmaas]
as
begin
select elemanmaas,g.gorevadi  from gorevler g inner join elemanlar e on g.gorevno=e.gorevno
where elemanmaas>3500 
end
GO
/****** Object:  StoredProcedure [dbo].[gorevsil]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gorevsil]
@gorevno int
as begin
delete from gorevler where gorevno=@gorevno
end
GO
/****** Object:  StoredProcedure [dbo].[gorevstatü]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[gorevstatü]
as
begin
select sum(elemanmaas) as 'Statüsü stajyer olanların maaş ortalamaları'  from elemanlar 
where elemanstatu='stajyer'
end
GO
/****** Object:  StoredProcedure [dbo].[gorevsure]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[gorevsure]
as
begin
select gorevdurum as 'Görev süresi 8 saatten az olanların görev durumları' from gorevler 
where gorevsuresi<8 group by gorevdurum 
end
GO
/****** Object:  StoredProcedure [dbo].[gorevyenile]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gorevyenile](
@gorevno int,
@gorevadi varchar(50),
@gorevtanimi varchar(50),
@gorevfiyat money,
@gorevsuresi varchar(50),
@gorevdurum varchar(50)
)
as begin
update gorevler set
gorevadi=@gorevadi,gorevtanimi=@gorevtanimi,gorevfiyat=@gorevfiyat,gorevsuresi=@gorevsuresi,gorevdurum=@gorevdurum
where gorevno=@gorevno
end
GO
/****** Object:  StoredProcedure [dbo].[kullaniciekle]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[kullaniciekle](

@kullaniciadi varchar(50),
@sifre varchar(50),
@mail varchar(50),
@telefon char(15)
)
as begin 
insert into kullanicilar(kullaniciadi,sifre,mail,telefon) values (@kullaniciadi,@sifre,@mail,@telefon)
end
GO
/****** Object:  StoredProcedure [dbo].[kullanicigiris]    Script Date: 31.5.2022 21:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[kullanicigiris](
@kullaniciadi varchar(50),
@sifre varchar(50)
)
as 
begin
select * from kullanicilar where kullaniciadi=@kullaniciadi and sifre=@sifre
end
GO
USE [master]
GO
ALTER DATABASE [market] SET  READ_WRITE 
GO
