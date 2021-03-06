USE [master]
GO
/****** Object:  Database [BDWebCursos]    Script Date: 22/11/2021 22:54:11 ******/
CREATE DATABASE [BDWebCursos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDWebCursos', FILENAME = N'E:\MySQL\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDWebCursos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDWebCursos_log', FILENAME = N'E:\MySQL\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDWebCursos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDWebCursos] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDWebCursos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDWebCursos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDWebCursos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDWebCursos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDWebCursos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDWebCursos] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDWebCursos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDWebCursos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDWebCursos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDWebCursos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDWebCursos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDWebCursos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDWebCursos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDWebCursos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDWebCursos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDWebCursos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDWebCursos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDWebCursos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDWebCursos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDWebCursos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDWebCursos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDWebCursos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDWebCursos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDWebCursos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDWebCursos] SET  MULTI_USER 
GO
ALTER DATABASE [BDWebCursos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDWebCursos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDWebCursos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDWebCursos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDWebCursos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDWebCursos] SET QUERY_STORE = OFF
GO
USE [BDWebCursos]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 22/11/2021 22:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Descripcion] [text] NULL,
	[Imagen] [varchar](200) NULL,
	[UrlCurso] [varchar](250) NULL,
	[CantidadVotos] [int] NULL,
	[AcumuladorEstrellas] [int] NULL,
	[IdEspecialidad] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 22/11/2021 22:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[IdEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Materia] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cursos] ON 

INSERT [dbo].[Cursos] ([IdCurso], [Nombre], [Descripcion], [Imagen], [UrlCurso], [CantidadVotos], [AcumuladorEstrellas], [IdEspecialidad]) VALUES (1, N'PHP para principiantes', N'El curso inicia con los fundamentos de PHP, en los cuales aprenderás y dominaras todas las estructuras del lenguaje de programación tales como variables, ciclos, condicionales, arreglos, funciones y programación orientada a objetos.', N'https://digibuc.com/cursos/wp-content/uploads/2020/01/050209d3-04f8-4606-b140-e50b376fbcae-2.png', N'<iframe width="560" height="315" src="https://www.youtube.com/embed/mX0z6wSWJtA" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>', 6, 30, 1)
INSERT [dbo].[Cursos] ([IdCurso], [Nombre], [Descripcion], [Imagen], [UrlCurso], [CantidadVotos], [AcumuladorEstrellas], [IdEspecialidad]) VALUES (7, N'JavaScript para principiantes', N'El curso inicia con los fundamentos de PHP, en los cuales aprenderás y dominaras todas las estructuras del lenguaje de programación tales como variables, ciclos, condicionales, arreglos, funciones y p', N'https://edteam-media.s3.amazonaws.com/courses/original/61e5a210-8dab-412e-a6dc-802c070cc18c.jpg', N'url', 5, 13, 1)
INSERT [dbo].[Cursos] ([IdCurso], [Nombre], [Descripcion], [Imagen], [UrlCurso], [CantidadVotos], [AcumuladorEstrellas], [IdEspecialidad]) VALUES (9, N'Photoshop para principiantes', N'El curso inicia con los fundamentos de PHP, en los cuales aprenderás y dominaras todas las estructuras del lenguaje de programación tales como variables, ciclos, condicionales, arreglos, funciones y programación orientada a objetos.dddddddddddddddddd', N'https://robertopuentec.com/wp-content/uploads/2021/05/curso-gratuito-roberto-puente-de-adobe-photshop.png', N'url', 11, 20, 2)
SET IDENTITY_INSERT [dbo].[Cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidades] ON 

INSERT [dbo].[Especialidades] ([IdEspecialidad], [Nombre], [Materia]) VALUES (1, N'Lenguajes', N'Programacion')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Nombre], [Materia]) VALUES (2, N'Programas Diseño', N'Imagen y Comunicacion')
INSERT [dbo].[Especialidades] ([IdEspecialidad], [Nombre], [Materia]) VALUES (3, N'Metodologías', N'Efsi')
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
GO
USE [master]
GO
ALTER DATABASE [BDWebCursos] SET  READ_WRITE 
GO
