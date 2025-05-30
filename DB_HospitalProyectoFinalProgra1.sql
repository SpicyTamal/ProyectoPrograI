USE [master]
GO
/****** Object:  Database [db_ab9111_hospital]    Script Date: 30/05/2025 22:40:35 ******/
CREATE DATABASE [db_ab9111_hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_ab9111_hospital_Data', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_ab9111_hospital_DATA.mdf' , SIZE = 8192KB , MAXSIZE = 1024000KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'db_ab9111_hospital_Log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_ab9111_hospital_Log.LDF' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_ab9111_hospital] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_ab9111_hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_ab9111_hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_ab9111_hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_ab9111_hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_ab9111_hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_ab9111_hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_ab9111_hospital] SET  MULTI_USER 
GO
ALTER DATABASE [db_ab9111_hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_ab9111_hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_ab9111_hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_ab9111_hospital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_ab9111_hospital] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_ab9111_hospital] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_ab9111_hospital] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_ab9111_hospital] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_ab9111_hospital]
GO
/****** Object:  Table [dbo].[tbl_Citas]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Citas](
	[CodigoCita] [int] IDENTITY(1,1) NOT NULL,
	[CodigoPaciente] [int] NULL,
	[CodigoEmpleado] [int] NULL,
	[FechaIngreso] [datetime] NULL,
	[FechaEgreso] [datetime] NULL,
	[CostoTratamiento] [decimal](10, 2) NULL,
	[CostoHabitacion] [decimal](10, 2) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Empleados]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Empleados](
	[CodigoEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](100) NULL,
	[TipoTrabajo] [varchar](100) NULL,
	[Especialidad] [varchar](100) NULL,
	[Sueldo] [decimal](10, 2) NULL,
	[FechaAlta] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_GestionHabitaciones]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_GestionHabitaciones](
	[CodigoGestion] [int] IDENTITY(1,1) NOT NULL,
	[CodigoEmpleado] [int] NULL,
	[CodigoHabitacion] [int] NULL,
	[TipoGestion] [varchar](50) NULL,
	[FechaGestion] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoGestion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Habitaciones]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Habitaciones](
	[CodigoHabitacion] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [varchar](10) NULL,
	[Ubicacion] [varchar](100) NULL,
	[TipoHabitaciones] [varchar](50) NULL,
	[Costo] [decimal](10, 2) NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Medicamentos]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Medicamentos](
	[CodigoMedicamento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[TipoMedicamento] [varchar](100) NULL,
	[Costo] [decimal](10, 2) NULL,
	[Stock] [int] NULL,
	[FechaVencimiento] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoMedicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Pacientes]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Pacientes](
	[CodigoPaciente] [int] IDENTITY(1,1) NOT NULL,
	[CodigoHabitacion] [int] NULL,
	[Nombres] [varchar](100) NULL,
	[Nit] [varchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[TipoPaciente] [varchar](50) NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PagoCitas]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PagoCitas](
	[CodigoPagoCita] [int] IDENTITY(1,1) NOT NULL,
	[CodigoCita] [int] NULL,
	[MontoCita] [decimal](10, 2) NULL,
	[Impuestos] [decimal](10, 2) NULL,
	[Descuento] [decimal](10, 2) NULL,
	[TotalPago] [decimal](10, 2) NULL,
	[FechaPago] [datetime] NULL,
	[TipoPago] [varchar](50) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoPagoCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PagoEmpleados]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PagoEmpleados](
	[CodigoPago] [int] IDENTITY(1,1) NOT NULL,
	[CodigoEmpleado] [int] NULL,
	[FechaPago] [datetime] NULL,
	[Sueldo] [decimal](10, 2) NULL,
	[Bono] [decimal](10, 2) NULL,
	[MontoHorasExtra] [int] NULL,
	[TotalMonto] [decimal](10, 2) NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditora] [datetime] NULL,
	[HorasExtras] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Tratamiento]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Tratamiento](
	[CodigoTratamiento] [int] IDENTITY(1,1) NOT NULL,
	[CodigoCita] [int] NULL,
	[CodigoMedicamento] [int] NULL,
	[Costo] [decimal](10, 2) NULL,
	[FechaTratamiento] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoTratamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Usuarios]    Script Date: 30/05/2025 22:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Usuarios](
	[CodigoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[CodigoEmpleado] [int] NULL,
	[Usuario] [varchar](50) NULL,
	[Clave] [varchar](256) NULL,
	[TipoUsuario] [varchar](20) NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioAuditoria] [varchar](100) NULL,
	[FechaAuditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Citas] ON 

INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (1, 1, 2, CAST(N'2025-05-21T00:00:00.000' AS DateTime), CAST(N'2025-05-21T00:00:00.000' AS DateTime), CAST(50.00 AS Decimal(10, 2)), CAST(1000.00 AS Decimal(10, 2)), N'Kevin_Monterroso', CAST(N'2025-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (2, 2, 8, CAST(N'1911-06-18T00:00:00.000' AS DateTime), CAST(N'1916-08-09T00:00:00.000' AS DateTime), CAST(15.99 AS Decimal(10, 2)), CAST(500.00 AS Decimal(10, 2)), N'Dylan', CAST(N'1900-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (4, 2, 10, CAST(N'2023-07-27T00:06:44.000' AS DateTime), CAST(N'2025-04-22T00:06:44.000' AS DateTime), CAST(75.00 AS Decimal(10, 2)), CAST(500.00 AS Decimal(10, 2)), N'Dylan', CAST(N'2025-05-29T00:07:18.070' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (5, 9, 9, CAST(N'2025-05-13T00:07:19.000' AS DateTime), CAST(N'2025-05-29T00:07:19.000' AS DateTime), CAST(14.75 AS Decimal(10, 2)), CAST(1000.00 AS Decimal(10, 2)), N'Dylan', CAST(N'2025-05-29T00:07:31.560' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (6, 9, 8, CAST(N'2020-01-28T00:07:32.000' AS DateTime), CAST(N'2024-06-29T00:07:32.000' AS DateTime), CAST(2.05 AS Decimal(10, 2)), CAST(1000.00 AS Decimal(10, 2)), N'Dylan', CAST(N'2025-05-29T00:07:52.433' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, 10, 1, CAST(N'2024-06-29T00:07:53.000' AS DateTime), CAST(N'2025-04-23T00:07:53.000' AS DateTime), CAST(3.50 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), N'Dylan', CAST(N'2025-05-29T00:08:18.117' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, 7, 8, CAST(N'2025-04-14T00:08:19.000' AS DateTime), CAST(N'2025-05-16T00:08:19.000' AS DateTime), CAST(1.45 AS Decimal(10, 2)), CAST(3000.00 AS Decimal(10, 2)), N'Dylan', CAST(N'2025-05-29T00:08:37.607' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (10, 4, 7, CAST(N'2024-06-29T00:24:27.000' AS DateTime), CAST(N'2025-04-29T00:24:27.000' AS DateTime), CAST(0.00 AS Decimal(10, 2)), CAST(500.00 AS Decimal(10, 2)), N'Dylan', CAST(N'2025-05-29T00:24:38.470' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (12, 11, 9, CAST(N'2025-03-12T18:17:01.000' AS DateTime), CAST(N'2025-05-07T18:17:01.000' AS DateTime), CAST(1.45 AS Decimal(10, 2)), CAST(1000.00 AS Decimal(10, 2)), N'Dylan', CAST(N'2025-05-30T18:17:36.637' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (13, 7, 1, CAST(N'2025-05-16T20:29:37.000' AS DateTime), CAST(N'2025-05-30T20:29:37.797' AS DateTime), NULL, NULL, N'Dylan', CAST(N'2025-05-30T20:31:55.997' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (14, 8, 3, CAST(N'2025-05-30T20:31:56.730' AS DateTime), CAST(N'2025-05-30T20:31:56.730' AS DateTime), NULL, NULL, N'Dylan', CAST(N'2025-05-30T20:32:09.400' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (15, 11, 2, CAST(N'2025-05-30T20:32:10.613' AS DateTime), CAST(N'2025-05-30T20:32:10.613' AS DateTime), NULL, NULL, N'Dylan', CAST(N'2025-05-30T20:32:17.193' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (16, 1, 13, CAST(N'2025-05-13T20:32:18.000' AS DateTime), CAST(N'2025-05-28T20:32:18.000' AS DateTime), NULL, NULL, N'Dylan', CAST(N'2025-05-30T20:32:32.467' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (17, 8, 15, CAST(N'2025-05-06T20:32:33.000' AS DateTime), CAST(N'2025-05-07T20:32:33.000' AS DateTime), NULL, NULL, N'Dylan', CAST(N'2025-05-30T20:32:58.107' AS DateTime))
INSERT [dbo].[tbl_Citas] ([CodigoCita], [CodigoPaciente], [CodigoEmpleado], [FechaIngreso], [FechaEgreso], [CostoTratamiento], [CostoHabitacion], [UsuarioAuditoria], [FechaAuditoria]) VALUES (18, 6, 7, CAST(N'2025-05-27T20:32:59.000' AS DateTime), CAST(N'2025-05-28T20:32:59.000' AS DateTime), NULL, NULL, N'Dylan', CAST(N'2025-05-30T20:33:12.513' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Citas] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Empleados] ON 

INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (1, N'Kevin', N'Tecnico', N'IT', CAST(3000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Activo', N'Kevin_Monterroso', CAST(N'2025-02-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (2, N'Paolo', N'Farmaceutico', N'Pediatria', CAST(6000.00 AS Decimal(10, 2)), CAST(N'2025-06-15T00:00:00.000' AS DateTime), N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-28T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (3, N'Musculoso', N'Medico', N'Conserje', CAST(20000.00 AS Decimal(10, 2)), CAST(N'2025-12-24T00:00:00.000' AS DateTime), N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-28T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, N'Mariana', N'Enfermero', N'Geriatria', CAST(10000.00 AS Decimal(10, 2)), CAST(N'2025-05-01T00:00:00.000' AS DateTime), N'Activo', N'alex', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, N'Santi', N'Enfermero', N'Lobotomía', CAST(10000.00 AS Decimal(10, 2)), CAST(N'2025-07-16T00:00:00.000' AS DateTime), N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (9, N'Chavelo', N'Farmaceutico', N'Inyecciones', CAST(6000.00 AS Decimal(10, 2)), CAST(N'2025-08-14T00:00:00.000' AS DateTime), N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (10, N'Hernesto', N'Tecnico', N'Servidores', CAST(7000.00 AS Decimal(10, 2)), CAST(N'2025-10-22T00:00:00.000' AS DateTime), N'Inactivo', N'Kevin_Monterroso', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (13, N'Elvis Morales', N'Medico', N'Doctor', CAST(20000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Activo', N'Admin', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (14, N'Richard', N'Medico', N'Cardiologia', CAST(20000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Empleados] ([CodigoEmpleado], [Nombres], [TipoTrabajo], [Especialidad], [Sueldo], [FechaAlta], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (15, N'Nicole', N'Medico', N'Traumatologia', CAST(20000.00 AS Decimal(10, 2)), CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_GestionHabitaciones] ON 

INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (2, 7, 9, N'Observacion', CAST(N'2025-05-05T00:00:00.000' AS DateTime), N'Completa ', N'Fernanda', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (3, 7, 9, N'Limpieza', CAST(N'2025-05-29T00:00:00.000' AS DateTime), N'Completa ', N'Ryan', CAST(N'2025-05-29T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (5, 1, 1, N'Preparacion ', CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Pendiente ', N'Musculoso', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (6, 2, 7, N'Limpieza', CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Pendiente ', N'Musculoso', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, 3, 8, N'Observacion', CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Pendiente ', N'KevinIT', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, 7, 9, N'Observacion', CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Progreso ', N'KevinIT', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (9, 8, 10, N'Alimentacion', CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Creada', N'KevinIT', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (10, 9, 11, N'Preparacion ', CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Progreso ', N'KevinIT', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (11, 10, 12, N'Observacion', CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Completa ', N'KevinIT', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_GestionHabitaciones] ([CodigoGestion], [CodigoEmpleado], [CodigoHabitacion], [TipoGestion], [FechaGestion], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (12, 14, 13, N'Limpieza', CAST(N'2025-05-30T00:00:00.000' AS DateTime), N'Pendiente ', N'KevinIT', CAST(N'2025-05-30T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_GestionHabitaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Habitaciones] ON 

INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (1, N'3', N'Primer Nivel', N'Maternidad', CAST(1000.00 AS Decimal(10, 2)), N'Cancelado', N'Dylan', CAST(N'2025-05-25T22:48:36.320' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, N'1', N'Segundo Nivel', N'Pediatria', CAST(500.00 AS Decimal(10, 2)), N'Progreso', N'Dylan', CAST(N'2025-05-26T21:21:54.740' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, N'2', N'Tercer Nivel', N'General', CAST(300.00 AS Decimal(10, 2)), N'Completado', N'Dylan', CAST(N'2025-05-26T21:25:05.790' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (9, N'3', N'Tercer Nivel', N'Maternidad', CAST(1000.00 AS Decimal(10, 2)), N'Cancelado', N'Dylan', CAST(N'2025-05-26T21:25:18.750' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (10, N'4', N'Segundo Nivel', N'Aislamiento', CAST(3000.00 AS Decimal(10, 2)), N'Suspendido', N'Dylan', CAST(N'2025-05-28T22:58:25.523' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (11, N'2', N'Tercer Nivel', N'Maternidad', CAST(1000.00 AS Decimal(10, 2)), N'Completado', N'Dylan', CAST(N'2025-05-28T22:58:39.810' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (12, N'5', N'Primer Nivel', N'Observacion', CAST(100.00 AS Decimal(10, 2)), N'Progreso', N'Dylan', CAST(N'2025-05-28T22:59:02.067' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (13, N'5', N'Segundo Nivel', N'Maternidad', CAST(1000.00 AS Decimal(10, 2)), N'Completado', N'Dylan', CAST(N'2025-05-28T22:59:20.883' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (14, N'2', N'Primer Nivel', N'General', CAST(300.00 AS Decimal(10, 2)), N'Pendiente', N'Dylan', CAST(N'2025-05-28T22:59:35.627' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (15, N'4', N'Tercer Nivel', N'Maternidad', CAST(1000.00 AS Decimal(10, 2)), N'Suspendido', N'Dylan', CAST(N'2025-05-29T19:29:03.350' AS DateTime))
INSERT [dbo].[tbl_Habitaciones] ([CodigoHabitacion], [Numero], [Ubicacion], [TipoHabitaciones], [Costo], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (16, N'2', N'Segundo Nivel', N'Aislamiento', CAST(3000.00 AS Decimal(10, 2)), N'Suspendido', N'KevinIT', CAST(N'2025-05-30T20:08:09.570' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Habitaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Medicamentos] ON 

INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (1, N'SuxIonno', N'Inyeccion', CAST(50.00 AS Decimal(10, 2)), 99, CAST(N'2030-05-20T00:00:00.000' AS DateTime), N'Disponible', N'Kevin', CAST(N'2025-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (2, N'Vitaflenaco', N'Tableta', CAST(15.99 AS Decimal(10, 2)), 23, CAST(N'2026-09-11T00:00:00.000' AS DateTime), N'Disponible', N'Kevin', CAST(N'2025-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (3, N'PeptoBismol', N'Jarabe', CAST(29.99 AS Decimal(10, 2)), 10, CAST(N'2027-01-27T00:00:00.000' AS DateTime), N'Disponible', N'Kevin', CAST(N'2025-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (4, N'Permmatrago', N'Tableta', CAST(14.75 AS Decimal(10, 2)), 12, CAST(N'2025-04-19T00:00:00.000' AS DateTime), N'Vencido', N'Kevin', CAST(N'2025-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (5, N'AlkaAD', N'Tableta', CAST(2.05 AS Decimal(10, 2)), 0, CAST(N'2026-12-23T00:00:00.000' AS DateTime), N'Agotado', N'Kevin', CAST(N'2025-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (6, N'VickVaporub', N'Crema', CAST(3.50 AS Decimal(10, 2)), 9, CAST(N'2027-07-07T00:00:00.000' AS DateTime), N'Transito', N'Kevin', CAST(N'2025-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, N'Masstiko', N'Tableta', CAST(1.45 AS Decimal(10, 2)), 7, CAST(N'2026-02-28T00:00:00.000' AS DateTime), N'Retirado', N'Kevin', CAST(N'2025-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, N'AriGamex', N'Aerosol', CAST(3.99 AS Decimal(10, 2)), 999, CAST(N'2028-03-15T00:00:00.000' AS DateTime), N'Disponible', N'Kevin', CAST(N'2025-05-22T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (11, N'Pad-Aluztro', N'Crema', CAST(75.00 AS Decimal(10, 2)), 55, CAST(N'2028-07-05T09:01:26.000' AS DateTime), N'Disponible', N'Kevin_Monterroso', CAST(N'2025-05-24T09:02:10.113' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (12, N'CotroLammox', N'Suero', CAST(25.00 AS Decimal(10, 2)), 6, CAST(N'2025-03-20T09:02:11.000' AS DateTime), N'Agotado', N'Kevin_Monterroso', CAST(N'2025-05-24T09:03:27.093' AS DateTime))
INSERT [dbo].[tbl_Medicamentos] ([CodigoMedicamento], [Nombre], [TipoMedicamento], [Costo], [Stock], [FechaVencimiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (13, N'Metalastrano', N'Crema', CAST(75.00 AS Decimal(10, 2)), 51, CAST(N'2028-07-04T17:22:11.000' AS DateTime), N'Disponible', N'Kevin_Monterroso', CAST(N'2025-05-28T17:23:10.433' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Medicamentos] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Pacientes] ON 

INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (1, 1, N'Andre', N'24724572', CAST(N'2004-02-03T22:07:22.000' AS DateTime), N'Cita', N'Aislamiento', N'Kevin_Monterroso', CAST(N'2025-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (2, 7, N'Jonathan', N'2456245', CAST(N'2000-06-26T22:07:22.000' AS DateTime), N'Emergencia', N'Estable', N'Dylan', CAST(N'2025-05-26T22:07:45.947' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (4, 7, N'Jose ', N'24356262', CAST(N'2015-07-16T20:05:03.000' AS DateTime), N'Cita', N'Estable', N'Dylan', CAST(N'2025-05-27T20:05:51.963' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (5, 1, N'Daniel', N'2345672', CAST(N'2025-05-28T22:57:15.553' AS DateTime), N'Infeccioso', N'Aislamiento', N'Dylan', CAST(N'2025-05-28T22:57:37.613' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (6, 10, N'Alex', N'34578385', CAST(N'2021-06-10T00:03:20.000' AS DateTime), N'Infeccioso', N'Aislamiento', N'Dylan', CAST(N'2025-05-29T00:04:02.350' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, 10, N'Kevin', N'24565626', CAST(N'2025-05-29T00:04:03.963' AS DateTime), N'Infeccioso', N'Aislamiento', N'Dylan', CAST(N'2025-05-29T00:04:39.983' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, 14, N'Jose Emanuel', N'2346624', CAST(N'2022-07-20T00:04:41.000' AS DateTime), N'Quirurgicos', N'Fallecido', N'Dylan', CAST(N'2025-05-29T00:05:24.737' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (9, 11, N'El Brayan', N'6738357', CAST(N'2025-05-29T00:05:26.507' AS DateTime), N'Quirurgicos', N'Observacion', N'Dylan', CAST(N'2025-05-29T00:05:58.937' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (10, 12, N'El kevo', N'82725626', CAST(N'2025-05-29T00:06:00.597' AS DateTime), N'Infeccioso', N'Aislamiento', N'Dylan', CAST(N'2025-05-29T00:06:22.497' AS DateTime))
INSERT [dbo].[tbl_Pacientes] ([CodigoPaciente], [CodigoHabitacion], [Nombres], [Nit], [FechaNacimiento], [TipoPaciente], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (11, 15, N'Leonel', N'2567256254', CAST(N'2025-05-29T19:29:42.467' AS DateTime), N'Cita', N'Estable', N'Dylan', CAST(N'2025-05-29T19:30:05.720' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Pacientes] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_PagoCitas] ON 

INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (1, 1, CAST(1050.00 AS Decimal(10, 2)), CAST(126.00 AS Decimal(10, 2)), CAST(52.50 AS Decimal(10, 2)), CAST(1123.50 AS Decimal(10, 2)), CAST(N'2025-05-14T21:11:47.000' AS DateTime), N'Efectivo', N'Dylan', CAST(N'2025-05-28T21:11:55.950' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (3, 2, CAST(515.99 AS Decimal(10, 2)), CAST(61.92 AS Decimal(10, 2)), CAST(25.80 AS Decimal(10, 2)), CAST(552.11 AS Decimal(10, 2)), CAST(N'2025-05-20T18:40:22.000' AS DateTime), N'Transferencia', N'Dylan', CAST(N'2025-05-29T18:40:41.917' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (4, 7, CAST(103.50 AS Decimal(10, 2)), CAST(12.42 AS Decimal(10, 2)), CAST(3.10 AS Decimal(10, 2)), CAST(112.81 AS Decimal(10, 2)), CAST(N'2024-11-28T19:31:49.000' AS DateTime), N'Efectivo', N'Dylan', CAST(N'2025-05-29T19:32:13.667' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (5, 5, CAST(1014.75 AS Decimal(10, 2)), CAST(121.77 AS Decimal(10, 2)), CAST(50.74 AS Decimal(10, 2)), CAST(1085.78 AS Decimal(10, 2)), CAST(N'2025-05-24T19:32:14.000' AS DateTime), N'Tarjeta', N'Dylan', CAST(N'2025-05-29T19:32:32.480' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (6, 4, CAST(575.00 AS Decimal(10, 2)), CAST(69.00 AS Decimal(10, 2)), CAST(28.75 AS Decimal(10, 2)), CAST(615.25 AS Decimal(10, 2)), CAST(N'2024-01-01T19:32:33.000' AS DateTime), N'Transferencia', N'Dylan', CAST(N'2025-05-29T19:33:00.583' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, 8, CAST(3001.45 AS Decimal(10, 2)), CAST(360.17 AS Decimal(10, 2)), CAST(150.07 AS Decimal(10, 2)), CAST(3211.55 AS Decimal(10, 2)), CAST(N'2025-05-07T19:33:02.000' AS DateTime), N'Tarjeta', N'Dylan', CAST(N'2025-05-29T19:33:25.507' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, 10, CAST(500.00 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), CAST(545.00 AS Decimal(10, 2)), CAST(N'2025-05-29T19:33:48.703' AS DateTime), N'Tarjeta', N'Dylan', CAST(N'2025-05-29T19:34:09.613' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (9, 6, CAST(1002.05 AS Decimal(10, 2)), CAST(120.25 AS Decimal(10, 2)), CAST(50.10 AS Decimal(10, 2)), CAST(1072.19 AS Decimal(10, 2)), CAST(N'2021-03-04T19:34:11.000' AS DateTime), N'Transferencia', N'Dylan', CAST(N'2025-05-29T19:34:36.723' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (11, 7, CAST(103.50 AS Decimal(10, 2)), CAST(12.42 AS Decimal(10, 2)), CAST(3.10 AS Decimal(10, 2)), CAST(112.81 AS Decimal(10, 2)), CAST(N'2025-07-03T20:26:14.000' AS DateTime), N'Efectivo', N'Dylan', CAST(N'2025-05-30T20:26:40.850' AS DateTime))
INSERT [dbo].[tbl_PagoCitas] ([CodigoPagoCita], [CodigoCita], [MontoCita], [Impuestos], [Descuento], [TotalPago], [FechaPago], [TipoPago], [UsuarioAuditoria], [FechaAuditoria]) VALUES (12, 4, CAST(575.00 AS Decimal(10, 2)), CAST(69.00 AS Decimal(10, 2)), CAST(28.75 AS Decimal(10, 2)), CAST(615.25 AS Decimal(10, 2)), CAST(N'2026-07-07T20:26:41.000' AS DateTime), N'Efectivo', N'Dylan', CAST(N'2025-05-30T20:27:01.240' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_PagoCitas] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_PagoEmpleados] ON 

INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (1, 3, CAST(N'2025-05-29T00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), CAST(2400.00 AS Decimal(10, 2)), 4, CAST(22480.00 AS Decimal(10, 2)), N'Rechazado', N'Starla', CAST(N'2025-05-29T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (4, 2, CAST(N'2025-04-30T00:00:00.000' AS DateTime), CAST(6000.00 AS Decimal(10, 2)), CAST(720.00 AS Decimal(10, 2)), 8, CAST(6880.00 AS Decimal(10, 2)), N'Proceso', N'Juan', CAST(N'2025-05-29T00:00:00.000' AS DateTime), 8)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (11, 3, CAST(N'2025-05-29T00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), CAST(2400.00 AS Decimal(10, 2)), 160, CAST(22560.00 AS Decimal(10, 2)), N'Rechazado', N'Dylan', CAST(N'2025-05-29T00:00:00.000' AS DateTime), 8)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (12, 3, CAST(N'2025-05-29T00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), CAST(2400.00 AS Decimal(10, 2)), 160, CAST(22560.00 AS Decimal(10, 2)), N'Pagado', N'Alex', CAST(N'2025-05-29T00:00:00.000' AS DateTime), 8)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (13, 3, CAST(N'2025-05-29T00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), CAST(2400.00 AS Decimal(10, 2)), 480, CAST(22880.00 AS Decimal(10, 2)), N'Proceso', N'Alexander', CAST(N'2025-05-29T00:00:00.000' AS DateTime), 24)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (14, 3, CAST(N'2025-05-29T00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), CAST(2400.00 AS Decimal(10, 2)), 40, CAST(22440.00 AS Decimal(10, 2)), N'Pagado', N'Briyit', CAST(N'2025-05-29T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (15, 8, CAST(N'2025-05-29T00:00:00.000' AS DateTime), CAST(10000.00 AS Decimal(10, 2)), CAST(1200.00 AS Decimal(10, 2)), 160, CAST(11360.00 AS Decimal(10, 2)), N'Pendiente', N'alex', CAST(N'2025-05-29T00:00:00.000' AS DateTime), 8)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (16, 14, CAST(N'2025-05-30T00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), CAST(2400.00 AS Decimal(10, 2)), 240, CAST(22640.00 AS Decimal(10, 2)), N'Pendiente', N'Musculoso', CAST(N'2025-05-30T00:00:00.000' AS DateTime), 12)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (17, 15, CAST(N'2025-05-30T00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), CAST(2400.00 AS Decimal(10, 2)), 300, CAST(22700.00 AS Decimal(10, 2)), N'Proceso', N'Musculoso', CAST(N'2025-05-30T00:00:00.000' AS DateTime), 15)
INSERT [dbo].[tbl_PagoEmpleados] ([CodigoPago], [CodigoEmpleado], [FechaPago], [Sueldo], [Bono], [MontoHorasExtra], [TotalMonto], [Estado], [UsuarioAuditoria], [FechaAuditora], [HorasExtras]) VALUES (18, 7, CAST(N'2025-05-30T00:00:00.000' AS DateTime), CAST(10000.00 AS Decimal(10, 2)), CAST(1200.00 AS Decimal(10, 2)), 60, CAST(11260.00 AS Decimal(10, 2)), N'Pendiente', N'Musculoso', CAST(N'2025-05-30T00:00:00.000' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[tbl_PagoEmpleados] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Tratamiento] ON 

INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (6, 1, 1, CAST(50.00 AS Decimal(10, 2)), CAST(N'2025-02-26T00:00:00.000' AS DateTime), N'Completado', N'Kevin_Monterroso', CAST(N'2025-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, 1, 1, CAST(50.00 AS Decimal(10, 2)), CAST(N'2027-06-14T00:13:18.000' AS DateTime), N'Pendiente', N'Kevin_Monterroso', CAST(N'2025-05-29T00:13:38.203' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, 2, 2, CAST(15.99 AS Decimal(10, 2)), CAST(N'2025-07-16T00:13:39.000' AS DateTime), N'Pendiente', N'Kevin_Monterroso', CAST(N'2025-05-29T00:14:04.713' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (9, 4, 13, CAST(75.00 AS Decimal(10, 2)), CAST(N'2027-11-22T00:14:05.000' AS DateTime), N'Cancelado', N'Kevin_Monterroso', CAST(N'2025-05-29T00:18:21.477' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (10, 5, 4, CAST(14.75 AS Decimal(10, 2)), CAST(N'2025-05-28T00:14:24.000' AS DateTime), N'Suspendido', N'Kevin_Monterroso', CAST(N'2025-05-29T00:14:35.220' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (11, 6, 5, CAST(2.05 AS Decimal(10, 2)), CAST(N'2025-05-31T00:14:36.000' AS DateTime), N'Progreso', N'Kevin_Monterroso', CAST(N'2025-05-29T00:16:27.327' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (12, 7, 6, CAST(3.50 AS Decimal(10, 2)), CAST(N'2025-05-23T00:16:28.000' AS DateTime), N'Completado', N'Kevin_Monterroso', CAST(N'2025-05-29T00:16:41.210' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (13, 8, 7, CAST(1.45 AS Decimal(10, 2)), CAST(N'2025-05-31T00:16:42.000' AS DateTime), N'Cancelado', N'Kevin_Monterroso', CAST(N'2025-05-29T00:17:18.593' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (15, 12, 7, CAST(1.45 AS Decimal(10, 2)), CAST(N'2025-02-18T18:18:14.000' AS DateTime), N'Pendiente', N'Musculoso', CAST(N'2025-05-30T18:18:47.917' AS DateTime))
INSERT [dbo].[tbl_Tratamiento] ([CodigoTratamiento], [CodigoCita], [CodigoMedicamento], [Costo], [FechaTratamiento], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (16, 4, 13, CAST(75.00 AS Decimal(10, 2)), CAST(N'2025-05-30T20:25:22.923' AS DateTime), N'Pendiente', N'Musculoso', CAST(N'2025-05-30T20:26:05.270' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Tratamiento] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Usuarios] ON 

INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (1, 1, N'KevinIT', N'uncevichePls', N'Admin', N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-29T09:30:02.750' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (2, 2, N'Paolo', N'paracetamol1', N'Doctor', N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (3, 3, N'Musculoso', N'mimami', N'Asistente', N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-26T14:24:56.037' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (7, 7, N'Marii', N'pupusas', N'Asistente', N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-29T09:30:15.063' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (8, 8, N'Santiago', N'vivaTerraria', N'Asistente', N'Activo', N'Kevin_Monterroso', CAST(N'2025-05-29T09:30:58.143' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (9, 9, N'Chave', N'klkMami', N'Digitador', N'Inactivo', N'Kevin_Monterroso', CAST(N'2025-05-29T09:31:26.410' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (17, 10, N'her', N'123', N'Asistente', N'Activo', N'KevinIT', CAST(N'2025-05-29T13:26:32.080' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (18, 1, N'Kevin2', N'salchipapa', N'Digitador', N'Activo', N'KevinIT', CAST(N'2025-05-29T14:16:15.220' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (19, 14, N'Rich', N'money3', N'Doctor', N'Activo', N'Musculoso', CAST(N'2025-05-30T20:10:44.943' AS DateTime))
INSERT [dbo].[tbl_Usuarios] ([CodigoUsuario], [CodigoEmpleado], [Usuario], [Clave], [TipoUsuario], [Estado], [UsuarioAuditoria], [FechaAuditoria]) VALUES (20, 15, N'Nicki', N'trueno', N'Asistente', N'Activo', N'Musculoso', CAST(N'2025-05-30T20:11:40.287' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Usuarios] OFF
GO
ALTER TABLE [dbo].[tbl_PagoEmpleados] ADD  DEFAULT ((0)) FOR [HorasExtras]
GO
ALTER TABLE [dbo].[tbl_Citas]  WITH CHECK ADD FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[tbl_Citas]  WITH CHECK ADD  CONSTRAINT [FK__tbl_Citas__CodigoEmpleado] FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Citas] CHECK CONSTRAINT [FK__tbl_Citas__CodigoEmpleado]
GO
ALTER TABLE [dbo].[tbl_Citas]  WITH CHECK ADD  CONSTRAINT [FK__tbl_Citas__CodigoPaciente] FOREIGN KEY([CodigoPaciente])
REFERENCES [dbo].[tbl_Pacientes] ([CodigoPaciente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Citas] CHECK CONSTRAINT [FK__tbl_Citas__CodigoPaciente]
GO
ALTER TABLE [dbo].[tbl_Citas]  WITH CHECK ADD FOREIGN KEY([CodigoPaciente])
REFERENCES [dbo].[tbl_Pacientes] ([CodigoPaciente])
GO
ALTER TABLE [dbo].[tbl_GestionHabitaciones]  WITH CHECK ADD FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[tbl_GestionHabitaciones]  WITH CHECK ADD FOREIGN KEY([CodigoHabitacion])
REFERENCES [dbo].[tbl_Habitaciones] ([CodigoHabitacion])
GO
ALTER TABLE [dbo].[tbl_GestionHabitaciones]  WITH CHECK ADD  CONSTRAINT [FK__tbl_GestionHabitaciones__CodigoEmpleado] FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_GestionHabitaciones] CHECK CONSTRAINT [FK__tbl_GestionHabitaciones__CodigoEmpleado]
GO
ALTER TABLE [dbo].[tbl_GestionHabitaciones]  WITH CHECK ADD  CONSTRAINT [FK__tbl_GestionHabitaciones__CodigoHabitacion] FOREIGN KEY([CodigoHabitacion])
REFERENCES [dbo].[tbl_Habitaciones] ([CodigoHabitacion])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_GestionHabitaciones] CHECK CONSTRAINT [FK__tbl_GestionHabitaciones__CodigoHabitacion]
GO
ALTER TABLE [dbo].[tbl_Pacientes]  WITH CHECK ADD  CONSTRAINT [FK__tbl_Pacientes] FOREIGN KEY([CodigoHabitacion])
REFERENCES [dbo].[tbl_Habitaciones] ([CodigoHabitacion])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Pacientes] CHECK CONSTRAINT [FK__tbl_Pacientes]
GO
ALTER TABLE [dbo].[tbl_PagoCitas]  WITH CHECK ADD FOREIGN KEY([CodigoCita])
REFERENCES [dbo].[tbl_Citas] ([CodigoCita])
GO
ALTER TABLE [dbo].[tbl_PagoCitas]  WITH CHECK ADD  CONSTRAINT [FK__tbl_PagoCitas__CodigoCita] FOREIGN KEY([CodigoCita])
REFERENCES [dbo].[tbl_Citas] ([CodigoCita])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PagoCitas] CHECK CONSTRAINT [FK__tbl_PagoCitas__CodigoCita]
GO
ALTER TABLE [dbo].[tbl_PagoEmpleados]  WITH CHECK ADD FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[tbl_PagoEmpleados]  WITH CHECK ADD  CONSTRAINT [FK__tbl_PagoEmpleados__CodigoEmpleado] FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PagoEmpleados] CHECK CONSTRAINT [FK__tbl_PagoEmpleados__CodigoEmpleado]
GO
ALTER TABLE [dbo].[tbl_Tratamiento]  WITH CHECK ADD FOREIGN KEY([CodigoCita])
REFERENCES [dbo].[tbl_Citas] ([CodigoCita])
GO
ALTER TABLE [dbo].[tbl_Tratamiento]  WITH CHECK ADD FOREIGN KEY([CodigoMedicamento])
REFERENCES [dbo].[tbl_Medicamentos] ([CodigoMedicamento])
GO
ALTER TABLE [dbo].[tbl_Tratamiento]  WITH CHECK ADD  CONSTRAINT [FK__tbl_Tratamiento__CodigoCita] FOREIGN KEY([CodigoCita])
REFERENCES [dbo].[tbl_Citas] ([CodigoCita])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Tratamiento] CHECK CONSTRAINT [FK__tbl_Tratamiento__CodigoCita]
GO
ALTER TABLE [dbo].[tbl_Tratamiento]  WITH CHECK ADD  CONSTRAINT [FK__tbl_Tratamiento__CodigoMedicamento] FOREIGN KEY([CodigoMedicamento])
REFERENCES [dbo].[tbl_Medicamentos] ([CodigoMedicamento])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Tratamiento] CHECK CONSTRAINT [FK__tbl_Tratamiento__CodigoMedicamento]
GO
ALTER TABLE [dbo].[tbl_Usuarios]  WITH CHECK ADD FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[tbl_Usuarios]  WITH CHECK ADD  CONSTRAINT [FK__tbl_Usuarios__CodigoEmpleado] FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_Usuarios] CHECK CONSTRAINT [FK__tbl_Usuarios__CodigoEmpleado]
GO
USE [master]
GO
ALTER DATABASE [db_ab9111_hospital] SET  READ_WRITE 
GO
