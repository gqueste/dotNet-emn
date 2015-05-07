USE [master]
GO
/****** Object:  Database [CMDVOLS]    Script Date: 07/05/2015 16:42:32 ******/
CREATE DATABASE [CMDVOLS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CMDVOLS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CMDVOLS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CMDVOLS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CMDVOLS_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CMDVOLS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CMDVOLS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CMDVOLS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CMDVOLS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CMDVOLS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CMDVOLS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CMDVOLS] SET ARITHABORT OFF 
GO
ALTER DATABASE [CMDVOLS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CMDVOLS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CMDVOLS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CMDVOLS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CMDVOLS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CMDVOLS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CMDVOLS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CMDVOLS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CMDVOLS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CMDVOLS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CMDVOLS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CMDVOLS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CMDVOLS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CMDVOLS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CMDVOLS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CMDVOLS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CMDVOLS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CMDVOLS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CMDVOLS] SET  MULTI_USER 
GO
ALTER DATABASE [CMDVOLS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CMDVOLS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CMDVOLS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CMDVOLS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CMDVOLS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CMDVOLS]
GO
/****** Object:  Table [dbo].[CmdVols]    Script Date: 07/05/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CmdVols](
	[idCmdVol] [int] NOT NULL,
	[idVol] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[nomUtilisateur] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CmdVols] PRIMARY KEY CLUSTERED 
(
	[idCmdVol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[sp_reservation_vol]    Script Date: 07/05/2015 16:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_reservation_vol]
	@ID_VOL int,
	@DATE date,
	@NOM_UTILISATEUR nvarchar(50)

AS
BEGIN
	INSERT INTO CmdVols(idVol, date, nomUtilisateur) VALUES (@ID_VOL, @DATE, @NOM_UTILISATEUR);
END

GO
USE [master]
GO
ALTER DATABASE [CMDVOLS] SET  READ_WRITE 
GO
