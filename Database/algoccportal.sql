USE [master]
GO
/****** Object:  Database [algoccportal]    Script Date: 27/1/2020 22:19:55 ******/
CREATE DATABASE [algoccportal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'algoccportal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\algoccportal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'algoccportal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\algoccportal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [algoccportal] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [algoccportal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [algoccportal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [algoccportal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [algoccportal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [algoccportal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [algoccportal] SET ARITHABORT OFF 
GO
ALTER DATABASE [algoccportal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [algoccportal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [algoccportal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [algoccportal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [algoccportal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [algoccportal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [algoccportal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [algoccportal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [algoccportal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [algoccportal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [algoccportal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [algoccportal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [algoccportal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [algoccportal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [algoccportal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [algoccportal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [algoccportal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [algoccportal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [algoccportal] SET  MULTI_USER 
GO
ALTER DATABASE [algoccportal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [algoccportal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [algoccportal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [algoccportal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [algoccportal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [algoccportal] SET QUERY_STORE = OFF
GO
USE [algoccportal]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27/1/2020 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blwl_contact_list]    Script Date: 27/1/2020 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blwl_contact_list](
	[pkey] [int] IDENTITY(1,1) NOT NULL,
	[contact_list_group_pkey] [int] NOT NULL,
	[phone_number] [nvarchar](20) NOT NULL,
	[from] [datetime] NOT NULL,
	[to] [datetime] NOT NULL,
	[comment] [nvarchar](500) NULL,
 CONSTRAINT [PK_blwl_contact_list] PRIMARY KEY CLUSTERED 
(
	[pkey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blwl_contact_list_group]    Script Date: 27/1/2020 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blwl_contact_list_group](
	[pkey] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[list_type_pkey] [int] NULL,
 CONSTRAINT [PK_blwl_ontact_list_group] PRIMARY KEY CLUSTERED 
(
	[pkey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[blwl_list_type]    Script Date: 27/1/2020 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blwl_list_type](
	[pkey] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_blwl_list_type] PRIMARY KEY CLUSTERED 
(
	[pkey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[link_roles_menus]    Script Date: 27/1/2020 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[link_roles_menus](
	[pkey] [int] IDENTITY(1,1) NOT NULL,
	[roles_pkey] [int] NOT NULL,
	[menus_pkey] [int] NOT NULL,
 CONSTRAINT [PK_link_roles_menus] PRIMARY KEY CLUSTERED 
(
	[pkey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menus]    Script Date: 27/1/2020 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menus](
	[pkey] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[icon] [nvarchar](50) NOT NULL,
	[url] [nvarchar](255) NOT NULL,
	[parent_pkey] [int] NOT NULL,
 CONSTRAINT [PK_menus] PRIMARY KEY CLUSTERED 
(
	[pkey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 27/1/2020 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[pkey] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[description] [nvarchar](255) NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[pkey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 27/1/2020 22:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[pkey] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NULL,
	[email] [nvarchar](100) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[roles_pkey] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[pkey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[blwl_contact_list]  WITH CHECK ADD FOREIGN KEY([contact_list_group_pkey])
REFERENCES [dbo].[blwl_contact_list_group] ([pkey])
GO
ALTER TABLE [dbo].[blwl_contact_list_group]  WITH CHECK ADD FOREIGN KEY([list_type_pkey])
REFERENCES [dbo].[blwl_list_type] ([pkey])
GO
ALTER TABLE [dbo].[link_roles_menus]  WITH CHECK ADD  CONSTRAINT [FK_link_roles_menus-menus] FOREIGN KEY([menus_pkey])
REFERENCES [dbo].[menus] ([pkey])
GO
ALTER TABLE [dbo].[link_roles_menus] CHECK CONSTRAINT [FK_link_roles_menus-menus]
GO
ALTER TABLE [dbo].[link_roles_menus]  WITH CHECK ADD  CONSTRAINT [FK_link_roles_menus-roles] FOREIGN KEY([roles_pkey])
REFERENCES [dbo].[roles] ([pkey])
GO
ALTER TABLE [dbo].[link_roles_menus] CHECK CONSTRAINT [FK_link_roles_menus-roles]
GO
ALTER TABLE [dbo].[menus]  WITH CHECK ADD  CONSTRAINT [FK_menus_] FOREIGN KEY([pkey])
REFERENCES [dbo].[menus] ([pkey])
GO
ALTER TABLE [dbo].[menus] CHECK CONSTRAINT [FK_menus_]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_roles] FOREIGN KEY([roles_pkey])
REFERENCES [dbo].[roles] ([pkey])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_roles]
GO
USE [master]
GO
ALTER DATABASE [algoccportal] SET  READ_WRITE 
GO
