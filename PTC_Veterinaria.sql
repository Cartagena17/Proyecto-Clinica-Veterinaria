create database PTC_Veterinaria
go
Use PTC_Veterinaria
go


--Aqui podes ver si tenes usuarios
--Y su hay borrarlos para el frmPrimerUsuario
delete from usuarios
select *from usuarios

--Primera ejecucion
create table Propietarios (
PropietarioID int identity (1,1) primary key,
NombreProp varchar (100)not null,
TelefonoProp varchar (20)not null,
DireccionProp varchar (150)not null,
EmailProp varchar (100)not null
);

--Segunda ejecucion
    create table Personal (
    PersonalID int identity (1,1) primary key,
    NombrePers varchar (50) not null,
    ApellidoPers varchar (50)not null,
    TelefonoPers varchar (12)not null,
    EmailPers varchar (100)not null
    )

--Tercera ejecucion
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    PersonalId INT NULL,
    Usuario NVARCHAR(50) UNIQUE NOT NULL,
    Email NVARCHAR(100) NOT NULL DEFAULT '',
    Contraseña NVARCHAR(255) NOT NULL,
    Rol NVARCHAR(20) NOT NULL CHECK (Rol IN ('Administrador', 'Empleado')),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    Activo BIT DEFAULT 1,
    TokenRecuperacion NVARCHAR(255) NULL,
    FechaExpiracionToken DATETIME NULL,
    constraint FK_Usuarios_Personal
    FOREIGN KEY (PersonalId) REFERENCES Personal(PersonalId)
);

--Cuarta ejecucion
create table Pacientes (
PacienteID int identity (1,1) primary key,
PropietarioID int constraint fk_PropietarioID foreign key (PropietarioID) references Propietarios(PropietarioID) on delete cascade,
NombrePac varchar (100)not null,
EspeciePac varchar (100)not null,
RazaPac varchar (100)not null,
NacimientoPac date not null,
PesoPac decimal (6,1)not null,
SexoPac varchar (20)not null,
ColorPac varchar (20)not null,
CaracteristicasPac varchar (100)
);

--Esto no es necesario
create table Facturas (
FacturaID int identity (1,1) primary key,
PropietarioID int constraint fk_PropietarioID_factura foreign key (PropietarioID) references Propietarios (PropietarioID) on delete cascade not null,
FechaFactura date not null,
MontoTotal decimal (8,2) not null,
)

--No necesario
Create table Pagos (
PagoID int identity (1,1) primary key,
FacturaID int constraint fk_facutraID foreign key (FacturaID) references Facturas(FacturaID) on delete cascade not null,
FechaPago date not null,
MontoPago decimal (8,2) not null,
MetodoPago varchar (50)not null,
ReferenciaPago varchar (50)not null
)

--No necesario
create table Servicios (
ServicioID int identity (1,1) primary key,
NombreServ varchar (100) not null,
DescripcionServ varchar (100) not null,
PrecioServ decimal (8,2) not null,
)

--No necesario
create table Medicamentos (
MedicamentoID int identity (1,1) primary key,
nombreMedic varchar (30)not null,
DescripcionMedic varchar (100) not null,
UnidadMedida varchar (20) not null,
PrecioUnitario decimal (8,2)not null,
StockActual int not null,
StockMinimo int not null,
FechaUltimaEntrada date not null
);

--No necesario
create table DetalleFactura (
DetalleFacturaID int identity (1,1) primary key,
FacturaID int constraint fk_facturaID_DetalleFactura foreign key (FacturaID) references Facturas(FacturaID) on delete cascade not null,
ServicioID int constraint fk_ServicioID foreign key (ServicioID) references Servicios(ServicioID) on delete cascade not null,
MedicamentoID int constraint fk_MedicamentoID foreign key (MedicamentoID) references Medicamentos(MedicamentoID) on delete cascade not null,
Cantidad int not null,
PrecioUnitorioAplicado decimal (8,2) not null,
Subtotal decimal (8,2) not null
)

--No necesario
create table Vacunas (
VacunaID int identity (1,1) primary key,
NombreVacuna varchar (50) not null,
TipoVacuna varchar (50) not null,
DosisRecomendada varchar (50) not null
)
--No necesario
create table VacunasAplicadas (
VacunaAplicadaID int identity (1,1) primary key,
PacienteID int constraint fk_PacienteID_VacAplicadas foreign key (PacienteID) references Pacientes(PacienteID) on delete cascade not null,
VacunaID int constraint fk_VacunaID foreign key (VacunaID) references Vacunas(VacunaID) on delete cascade not null,
PersonalID int constraint fk_PersonalID foreign key (PersonalID) references Personal(PersonalID) on delete cascade not null,
FechaAplicacion date not null,
Dosis varchar (30) not null,
Lote varchar (30) not null,
FechaProximoRefuerzo date not null
)

--Siguiente ejecucion
create table Citas (
CitaID int identity (1,1) primary key,
PacienteID int foreign key (PacienteID) references Pacientes(PacienteID) not null,
PropietarioID int constraint fk_PropietarioID_Citas foreign key (PropietarioID) references Propietarios(PropietarioID) on delete cascade not null,
PersonalID int constraint fk_PersonalID_Citas foreign key (PersonalID) references Personal(PersonalID) on delete cascade not null,
FechaCita date not null,
HoraCita varchar (20) not null,
MotivoCita varchar (100) not null,
NotasCita Varchar (100)
);

--Siguiente ejecucion
create table ConsultasMedicas (
    ConsultaID int identity (1,1) primary key,
    CitaID int constraint fk_citaID_Consultas 
        foreign key (CitaID) references Citas(CitaID) on delete cascade,
    FechaConsulta date not null,
    Sintomas varchar(100) not null,
    Diagnostico varchar(60) not null,
    Tratamiento varchar(100) not null,
    Observaciones varchar(100) not null,
    PesoActual decimal(6,2) not null,
    Temperatura decimal(4,1) not null
);

--No necesario
create table MedicamentosAdministrados (
MedicamentoAdminID int identity (1,1) primary key,
ConsultaID int constraint fk_ConsultaID foreign key (ConsultaID) references ConsultasMedicas(ConsultaID) on delete cascade not null,
MedicamentoID int constraint fk_MedicamentoID_AdminMedic foreign key (MedicamentoID) references Medicamentos(MedicamentoID) on delete cascade not null,
FechaAdministracion date not null,
Dosis varchar (30) not null,
ViaAdministracion varchar (50) not null,
CantidadUtilizada varchar (60) not null
);

--Como no tenes ningun registro ni nada no son necesarios
select *from Usuarios
select *from Propietarios
select *from Pacientes
select *from Facturas
select *from Pagos
select *from Servicios
select *from Medicamentos
select *from DetalleFactura
select *from Personal
select *from Vacunas
select *from VacunasAplicadas
select *from Citas
select *from ConsultasMedicas
select *from MedicamentosAdministrados

--Esta vista sirve para los DataGridView osea los datos que vemos en las tablas de C#
create view CargarPacientes as
select pacienteId AS #,NombrePac AS Nombre_Paciente,nombreProp AS Nombre_Propietario, especiepac AS Especie,razapac AS Raza,nacimientopac As Nacimiento,
pesopac As Peso,sexopac as Sexo,colorpac as color from Pacientes
inner join Propietarios on Propietarios.PropietarioID=Pacientes.PropietarioID

--Para ver y para eliminar la vista de arriba
select *from CargarPacientes
drop view CargarPacientes


--Segunda Vista que ejecutas
create or alter view CargarCitas2 as
SELECT CitaID AS '#',NombreProp,NombrePac,NombrePers,FechaCita,HoraCita,MotivoCita,NotasCita
FROM Citas c
INNER JOIN Pacientes p ON c.PacienteID = p.PacienteID
INNER JOIN Propietarios pr ON c.PropietarioID = pr.PropietarioID
INNER JOIN Personal pe ON c.PersonalID = pe.PersonalID;

--Ver o eliminar vista
select *from CargarCitas2
drop view CargarCitas2


--Siguiente Vista
create or alter view CargarConsultasMedicas as
SELECT 
    CM.ConsultaID AS #,
    C.CitaID AS CodigoCita,
    P.NombrePac AS Nombre_Paciente,
    PR.NombreProp AS Nombre_Propietario,
    PE.NombrePers AS Nombre_Personal,
    C.FechaCita AS Fecha_Consulta,
    CM.Sintomas,
    CM.Diagnostico,
    CM.Tratamiento,
    CM.Observaciones,
    CM.PesoActual AS Peso_Actual,
    CM.Temperatura
FROM ConsultasMedicas CM
INNER JOIN Citas C ON CM.CitaID = C.CitaID
INNER JOIN Pacientes P ON C.PacienteID = P.PacienteID
INNER JOIN Propietarios PR ON C.PropietarioID = PR.PropietarioID
INNER JOIN Personal PE ON C.PersonalID = PE.PersonalID

--Ver o eliminar vista
select *from CargarConsultasMedicas
drop view CargarConsultasMedicas

--Creas siguiente vista
CREATE OR ALTER VIEW CargarPacientes AS
SELECT 
    p.PacienteID AS '#',
    p.NombrePac AS Nombre_Paciente,
    pr.PropietarioID AS,                 -- 🔹 Lo agregamos para uso interno
    pr.NombreProp AS Nombre_Propietario,
    p.EspeciePac AS Especie,
    p.RazaPac AS Raza,
    p.NacimientoPac AS Nacimiento,
    p.PesoPac AS Peso,
    p.SexoPac AS Sexo,
    p.ColorPac AS Color
FROM Pacientes p
INNER JOIN Propietarios pr ON p.PropietarioID = pr.PropietarioID;



--Siguiente Vista
    create view CargarPropietarios AS
    Select propietarioId AS '#',
    nombreprop AS Nombre,
    TelefonoProp AS Telefono,
    direccionprop AS Dirección,
    Emailprop AS Correo_electrónico
    FROM Propietarios
--Ver o eliminar vista
select *from CargarPropietarios
drop view CargarPropietarios

--creas siguiente vista
   create view CargarPersonal AS
    select 
    personalid AS '#',
    nombrepers AS Nombre,
    apellidopers AS Apellido,
    Telefonopers AS Telefono,
    emailpers AS Correo_electrónico
    from Personal
--Ver o eliminar vista
select *from CargarPersonal
drop view CargarPersonal

--Esto lo ejecutas tambien como ya ejecutaste la tabla ConsultasMedicas
--Quito el registro de FechaConsulta y solo me quedo con el de FechaCita
alter table ConsultasMedicas drop column FechaConsulta

--Esto no me acuerdo pero ay dejalo por si acaso
 SELECT c.CitaID, 
                       p.NombrePac + ' / ' + pr.NombreProp + ' / ' + CONVERT(varchar, c.FechaCita, 103) AS InfoCita,
                C.fechaCita
                FROM Citas c
                INNER JOIN Pacientes p ON c.PacienteId = p.PacienteId
                INNER JOIN Propietarios pr ON p.PropietarioId = pr.PropietarioId
                WHERE c.CitaID NOT IN (SELECT CitaID FROM ConsultasMedicas);


--Por si queres ver las columnas de Pacientes
                SELECT COLUMN_NAME 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Pacientes'

--Si queres ver el numero de registros que tenemos en cada tabla
SELECT 
    t.name AS Tabla,
    p.rows AS Registros
FROM 
    sys.tables t
INNER JOIN 
    sys.partitions p ON t.object_id = p.object_id
WHERE 
    p.index_id IN (0, 1)
    AND p.rows > 0
ORDER BY 
    p.rows DESC

/*Si vas a eliminar los registros de todas las tablas primero ejecutas esto*/
    EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"
--Luego esto
    delete from propietarios
    delete from servicios
    delete from medicamentos
    delete from vacunas
    delete from pacientes
    delete from facturas
    delete from pagos
    delete from detallefactura
    delete from personal
    delete from citas
    delete from vacunasaplicadas
    delete from consultasmedicas
--Por ultimo esto
    EXEC sp_MSforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"
