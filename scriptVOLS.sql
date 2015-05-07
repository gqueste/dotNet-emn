USE [master]
GO
/****** Object:  Database [VOLS]    Script Date: 07/05/2015 15:39:35 ******/
CREATE DATABASE [VOLS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VOLS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\VOLS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VOLS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\VOLS_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VOLS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VOLS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VOLS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VOLS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VOLS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VOLS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VOLS] SET ARITHABORT OFF 
GO
ALTER DATABASE [VOLS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VOLS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VOLS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VOLS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VOLS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VOLS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VOLS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VOLS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VOLS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VOLS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VOLS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VOLS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VOLS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VOLS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VOLS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VOLS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VOLS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VOLS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VOLS] SET  MULTI_USER 
GO
ALTER DATABASE [VOLS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VOLS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VOLS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VOLS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [VOLS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [VOLS]
GO
/****** Object:  Table [dbo].[Vols]    Script Date: 07/05/2015 15:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vols](
	[idVol] [int] NOT NULL,
	[nomVol] [nvarchar](50) NOT NULL,
	[companie] [nvarchar](50) NOT NULL,
	[dateVol] [datetime] NOT NULL,
	[duree] [float] NOT NULL,
	[villeDepart] [nvarchar](50) NOT NULL,
	[villeArrivee] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Vols] PRIMARY KEY CLUSTERED 
(
	[idVol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[sp_villesArrivee]    Script Date: 07/05/2015 15:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_villesArrivee]
AS
BEGIN
	SELECT DISTINCT villeArrivee FROM Vols;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_villesDepart]    Script Date: 07/05/2015 15:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_villesDepart]
AS
BEGIN
	SELECT DISTINCT villeDepart FROM Vols;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_vol_byId]    Script Date: 07/05/2015 15:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_vol_byId]
	@ID_VOL int

AS
BEGIN
	SELECT * FROM Vols 
		WHERE idVol = @ID_VOL;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_vols_dispos]    Script Date: 07/05/2015 15:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_vols_dispos]
	@VILLE_DEPART nvarchar(50),
	@VILLE_ARRIVEE nvarchar(50),
	@DATE datetime

AS
BEGIN
	SELECT * FROM Vols 
		WHERE villeArrivee = @VILLE_ARRIVEE AND villeDepart = @VILLE_DEPART AND dateVol = @DATE;
END

GO
USE [master]
GO
ALTER DATABASE [VOLS] SET  READ_WRITE 
GO
