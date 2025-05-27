--crear una base de datos


create table tbl_Habitaciones
(
	CodigoHabitacion int primary key identity(1,1) not null,
	Numero varchar(10),
	Ubicacion varchar(100),
	TipoHabitaciones varchar(50),
	Costo DECIMAL(10,2),
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditoria DATETIME
);
go
--crear tabla pacientes
create table tbl_Pacientes
(
	CodigoPaciente int primary key identity(1,1) not null,
	CodigoHabitacion int,
	Nombres varchar(100),
	Nit varchar(50),
	FechaNacimiento DATETIME,
	TipoPaciente varchar(50),
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditoria DATETIME,
	foreign key (CodigoHabitacion) references tbl_Habitaciones(CodigoHabitacion)
);
go
create table tbl_Empleados 
(
		CodigoEmpleado int primary key identity (1,1) not null,
		Nombres varchar(100),
		TipoTrabajo varchar(100),
		Especialidad varchar(100),
		Sueldo decimal(10,2),
		FechaAlta datetime,
		Estado varchar(20),
		UsuarioAuditoria varchar(100),
		FechaAuditoria datetime
);
go
create table tbl_PagoEmpleados 
(
	CodigoPago int primary key identity(1,1) not null,
	CodigoEmpleado int,
	FechaPago DateTime,
	Sueldo Decimal(10,2),
	Bono Decimal(10,2),
	MontoHorasExtra Decimal(10,2),
	TotalMonto Decimal(10,2),
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditora DateTime
	foreign key (CodigoEmpleado) references tbl_Empleados(CodigoEmpleado)
);
go
create table tbl_Usuarios
(
	CodigoUsuario int primary key identity(1,1) not null,
	CodigoEmpleado int,
	Usuario varchar(50),
	Clave varchar(256),
	TipoUsuario varchar(20),
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditoria DateTime
	foreign key (CodigoEmpleado) references tbl_Empleados(CodigoEmpleado)
);
go
create table tbl_Citas
(
	CodigoCita int primary key identity(1,1) not null,
	CodigoPaciente int,
	CodigoEmpleado int,
	FechaIngreso DateTime,
	FechaEgreso DateTime,
	CostoTratamiento Decimal(10,2),
	CostoHabitacion Decimal(10,2),
	UsuarioAuditoria varchar(100),
	FechaAuditoria DateTime
	foreign key (CodigoPaciente) references tbl_Pacientes(CodigoPaciente),
	foreign key (CodigoEmpleado) references tbl_Empleados(CodigoEmpleado)
);
go
create table tbl_GestionHabitaciones
(
	CodigoGestion int primary key identity(1,1) not null,
	CodigoEmpleado int,
	CodigoHabitacion int,
	TipoGestion varchar(50),
	FechaGestion DateTime,
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditoria DateTime,
	foreign key (CodigoEmpleado) references tbl_Empleados(CodigoEmpleado),
	foreign key (CodigoHabitacion) references tbl_Habitaciones(CodigoHabitacion)
);
go
create table tbl_PagoCitas
(
	CodigoPagoCita int primary key identity(1,1) not null,
	CodigoCita int,
	MontoCita Decimal(10,2),
	Impuestos Decimal(10,2),
	Descuento Decimal(10,2),
	TotalPago Decimal(10,2),
	FechaPago DateTime,
	TipoPago varchar(50),
	UsuarioAuditoria varchar(100),
	FechaAuditoria DateTime,
	foreign key (CodigoCita) references tbl_Citas(CodigoCita)
);
go
create table tbl_Medicamentos
(
	CodigoMedicamento int primary key identity(1,1) not null,
	Nombre varchar(100),
	TipoMedicamento varchar(100),
	Costo Decimal(10,2),
	Stock int,
	FechaVencimiento DateTime,
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditoria DateTime
);
go
Create table tbl_Tratamiento
(
	CodigoTratamiento int primary key identity(1,1) not null,
	CodigoCita int,
	CodigoMedicamento int,
	Costo Decimal(10,2),
	FechaTratamiento DateTime,
	Estado varchar(20),
	UsuarioAuditoria varchar(100),
	FechaAuditoria DateTime,
	foreign key (CodigoCita) references tbl_Citas(CodigoCita),
	foreign key (CodigoMedicamento) references tbl_Medicamentos(CodigoMedicamento)
);

select * from tbl_Pacientes;