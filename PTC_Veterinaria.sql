create database PTC_Veterinaria
go
Use PTC_Veterinaria
go


create table Rol(
rolID int primary key identity (1000,1),
nombreRol varchar (50	))

create table Usuarios (
usuarioID int primary key identity (1000,1),
usuario varchar (50) not null,
contrase�a varchar (50) not null);

create table Propietarios (
PropietarioID int identity (1,1) primary key,
NombreProp varchar (100)not null,
TelefonoProp varchar (20)not null,
DireccionProp varchar (150)not null,
EmailProp varchar (100)not null
);

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
)

create table Facturas (
FacturaID int identity (1,1) primary key,
PropietarioID int constraint fk_PropietarioID_factura foreign key (PropietarioID) references Propietarios (PropietarioID) on delete cascade not null,
FechaFactura date not null,
MontoTotal decimal (8,2) not null,
)

Create table Pagos (
PagoID int identity (1,1) primary key,
FacturaID int constraint fk_facutraID foreign key (FacturaID) references Facturas(FacturaID) on delete cascade not null,
FechaPago date not null,
MontoPago decimal (8,2) not null,
MetodoPago varchar (50)not null,
ReferenciaPago varchar (50)not null
)

create table Servicios (
ServicioID int identity (1,1) primary key,
NombreServ varchar (100) not null,
DescripcionServ varchar (100) not null,
PrecioServ decimal (8,2) not null,
)

create table Medicamentos (
MedicamentoID int identity (1,1) primary key,
nombreMedic varchar (30)not null,
DescripcionMedic varchar (100) not null,
UnidadMedida varchar (20) not null,
PrecioUnitario decimal (8,2)not null,
StockActual int not null,
StockMinimo int not null,
FechaUltimaEntrada date not null
)

create table DetalleFactura (
DetalleFacturaID int identity (1,1) primary key,
FacturaID int constraint fk_facturaID_DetalleFactura foreign key (FacturaID) references Facturas(FacturaID) on delete cascade not null,
ServicioID int constraint fk_ServicioID foreign key (ServicioID) references Servicios(ServicioID) on delete cascade not null,
MedicamentoID int constraint fk_MedicamentoID foreign key (MedicamentoID) references Medicamentos(MedicamentoID) on delete cascade not null,
Cantidad int not null,
PrecioUnitorioAplicado decimal (8,2) not null,
Subtotal decimal (8,2) not null
)

create table Personal (
PersonalID int identity (1,1) primary key,
NombrePers varchar (50) not null,
ApellidoPers varchar (50)not null,
TelefonoPers varchar (12)not null,
EmailPers varchar (100)not null
)

create table Vacunas (
VacunaID int identity (1,1) primary key,
NombreVacuna varchar (50) not null,
TipoVacuna varchar (50) not null,
DosisRecomendada varchar (50) not null
)

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

create table Citas (
CitaID int identity (1,1) primary key,
PacienteID int foreign key (PacienteID) references Pacientes(PacienteID) not null,
PropietarioID int constraint fk_PropietarioID_Citas foreign key (PropietarioID) references Propietarios(PropietarioID) on delete cascade not null,
PersonalID int constraint fk_PersonalID_Citas foreign key (PersonalID) references Personal(PersonalID) on delete cascade not null,
FechaCita date not null,
HoraCita varchar (20) not null,
MotivoCita varchar (100) not null,
NotasCita Varchar (100)
)

create table ConsultasMedicas (
ConsultaID int identity (1,1) primary key,
PacienteID int constraint fk_PacienteID foreign key (PacienteID) references Pacientes(PacienteID) on delete cascade ,
PersonalID int constraint fk_personalID_Consultas foreign key (PersonalID) references Personal(PersonalID) on delete cascade ,
CitaID int foreign key (CitaID) references Citas(CitaID) ,
FechaConsulta date not null,
Sintomas varchar (100) not null,
Diagnostico varchar (60) not null,
Tratamiento varchar (100) not null,
Observaciones varchar (100) not null,
PesoActual varchar (20) not null,
Temperatura varchar (20)not null
)

create table MedicamentosAdministrados (
MedicamentoAdminID int identity (1,1) primary key,
ConsultaID int constraint fk_ConsultaID foreign key (ConsultaID) references ConsultasMedicas(ConsultaID) on delete cascade not null,
MedicamentoID int constraint fk_MedicamentoID_AdminMedic foreign key (MedicamentoID) references Medicamentos(MedicamentoID) on delete cascade not null,
FechaAdministracion date not null,
Dosis varchar (30) not null,
ViaAdministracion varchar (50) not null,
CantidadUtilizada varchar (60) not null
)

INSERT INTO Usuarios (usuario,contrase�a) VALUES
('Andrea.Gonzalez','1001'),
('Jorge.Ramirez','1002'),
('Lucia.Mendoza','1003'),
('Carlos.Ruiz','1004'),
('Monica.Zelaya','1005'),
('Eduardo.Paredes','1006'),
('Paola.Martinez','1007'),
('Fernando.Castro','1008'),
('Karen.Ortiz','1009'),
('David.Morales','1010'),
('Tatiana.Lemus','1011'),
('Sergio.Vazquez','1012'),
('Valeria.Quintanilla','1013'),
('Melissa.Lopez','1014'),
('Ricardo.Delgaado','1015');

INSERT INTO Propietarios (NombreProp, TelefonoProp, DireccionProp, EmailProp) VALUES
('Carlos Mart�nez', '7777-1234', 'Calle El Progreso', 'carlos.martinez@gmail.com'),
('Mar�a L�pez', '7999-8888', 'Av. Roosevelt', 'maria.lopez@gmail.com'),
('Luis Rivera', '7888-5432', 'Col. Escal�n', 'luis.rivera@gmail.com'),
('Andrea Torres', '7654-5678', 'Santa Tecla', 'andrea.torres@hotmail.com'),
('Pedro G�mez', '7123-4567', 'Mejicanos', 'pedro.gomez@gmail.com'),
('Sof�a Delgado', '7987-4561', 'Col. San Benito', 'sofia@gmail.com'),
('Natalia Jim�nez', '7000-1234', 'Santa Tecla', 'natalia123@gmail.com'),
('Juan Carlos', '7111-5678', 'Ayutuxtepeque', 'juanxd@hotmail.com'),
('Karla M�ndez', '7222-5678', 'Ciudad Delgado', 'karla44@gmail.com'),
('Roberto P�rez', '7333-9876', 'Col. Miramonte', 'roberto3313@hotmail.com'),
('Gloria Hern�ndez', '7444-3333', 'San Jacinto', 'gloria2009@gmail.com'),
('Esteban Castro', '7555-1111', 'Col. M�dica', 'estebancoxd@hotmail.com'),
('Carmen Aguilar', '7666-2222', 'Santa Ana', 'carmen.aguilar@gmail.com'),
('Daniela Varela', '7777-9090', 'San Miguel', 'daniela.varela@hotmail.com'),
('Felipe Romero', '7888-6060', 'Col. Escal�n', 'felipe.romero@hotmail.com');

INSERT INTO Pacientes (PropietarioID, NombrePac, EspeciePac, RazaPac, NacimientoPac, PesoPac, SexoPac, ColorPac, CaracteristicasPac) VALUES
(1, 'Luna', 'Perro', 'Poodle', '2020-05-12', 8.5, 'Hembra', 'Blanco', 'Juguetona'),
(2, 'Max', 'Gato', 'Siam�s', '2022-09-18', 4.2, 'Macho', 'Gris', 'T�mido'),
(3, 'Bruno', 'Perro', 'Labrador', '2019-08-01', 22.4, 'Macho', 'Negro', 'Tranquilo'),
(4, 'Kira', 'Gato', 'Persa', '2021-11-10', 3.8, 'Hembra', 'Blanca', 'Tranquila'),
(5, 'Rocky', 'Perro', 'Pitbull', '2018-01-25', 28.0, 'Macho', 'Caf�', 'Protector'),
(6, 'Nala', 'Gato', 'Europea', '2022-03-03', 3.9, 'Hembra', 'Atigrada', 'Curiosa'),
(7, 'Toby', 'Perro', 'Chihuahua', '2023-02-18', 2.5, 'Macho', 'Miel', 'Valiente'),
(8, 'Milo', 'Perro', 'Pomerania', '2021-12-04', 1.9, 'Macho', 'Blanco y gris', 'Pelaje Largo'),
(9, 'Zoe', 'Perro', 'Pomerania', '2020-06-14', 1.4, 'Hembra', 'Verde', 'Amorosa'),
(10, 'Simba', 'Gato', 'Bengala', '2019-10-20', 5.6, 'Macho', 'Dorado', 'Juguet�n'),
(11, 'Lola', 'Perro', 'Beagle', '2020-04-11', 10.5, 'Hembra', 'Tricolor', 'Obediente'),
(12, 'Bobby', 'Perro', 'Golden Retriever', '2017-05-07', 26.5, 'Macho', 'Dorado', 'Amoroso'),
(13, 'Estela', 'Perro', 'Mini toy french', '2022-08-22', 5.0, 'Hembra', 'Blanco', 'T�mida'),
(14, 'Estrella', 'Gato', 'Angora', '2023-01-15', 3.0, 'Hembra', 'Nieve', 'Pelaje largo'),
(15, 'Manchas', 'Perro', 'D�lmata', '2018-09-30', 18.5, 'Macho', 'Blanco con negro', 'Juguet�n');

INSERT INTO Personal (NombrePers, ApellidoPers, Rol, TelefonoPers, EmailPers) VALUES
('Andrea', 'Gonz�lez', 'Veterinaria', '7888-4567', 'andrea.G@email.com'),
('Jorge', 'Ram�rez', 'Recepcionista', '7999-1234', 'jorge.R@email.com'),
('Luc�a', 'Mendoza', 'Veterinaria', '7222-8765', 'lucia.M@email.com'),
('Carlos', 'Ruiz', 'Asistente T�cnico', '7111-4567', 'carlos.R@email.com'),
('M�nica', 'Zelaya', 'Auxiliar', '7333-7890', 'monica.Z@email.com'),
('Eduardo', 'Paredes', 'Veterinario', '7001-3210', 'eduardo.P@email.com'),
('Paola', 'Mart�nez', 'Administradora', '7654-8989', 'paola.M@email.com'),
('Fernando', 'Castro', 'Veterinario', '7123-4444', 'fernando.C@email.com'),
('Karen', 'Ortiz', 'Recepcionista', '7444-5678', 'karen.O@email.com'),
('David', 'Morales', 'Asistente T�cnico', '7887-3322', 'david.M@email.com'),
('Tatiana', 'Lemus', 'Veterinaria', '7555-6677', 'tatiana.L@email.com'),
('Sergio', 'V�squez', 'Veterinario', '7666-8080', 'sergio.V@email.com'),
('Valeria', 'Quintanilla', 'Auxiliar', '7777-2222', 'valeria.Q@email.com'),
('Melissa', 'L�pez', 'Veterinaria', '7888-7777', 'melissa.L@email.com'),
('Ricardo', 'Delgado', 'Administrador', '7990-9090', 'ricardo.DD@email.com');

INSERT INTO Servicios (NombreServ, DescripcionServ, PrecioServ) VALUES
('Consulta General', 'Evaluaci�n m�dica b�sica', 25.00),
('Vacunaci�n', 'Aplicaci�n de vacunas preventivas', 15.00),
('Desparasitaci�n', 'Tratamiento antiparasitario', 12.00),
('Cirug�a menor', 'Intervenci�n quir�rgica leve', 120.00),
('Radiograf�a', 'Imagen diagn�stica por rayos X', 35.00),
('Limpieza dental', 'Higiene bucal profesional', 40.00),
('Ba�o medicado', 'Ba�o con shampoo terap�utico', 22.00),
('Hospitalizaci�n', 'Internamiento temporal del paciente', 80.00),
('Control prenatal', 'Seguimiento de gestaci�n animal', 30.00),
('Terapia f�sica', 'Rehabilitaci�n muscular', 45.00),
('Consulta especializada', 'Atenci�n por especialista', 50.00),
('Ecograf�a', 'Imagen por ultrasonido', 38.00),
('Microchip', 'Implantaci�n de identificaci�n electr�nica', 18.00),
('Certificado de salud', 'Documento oficial de estado sanitario', 20.00),
('Evaluaci�n nutricional', 'Asesor�a sobre dieta animal', 28.00);

INSERT INTO Medicamentos (NombreMedic, DescripcionMedic, UnidadMedida, PrecioUnitario, StockActual, StockMinimo, FechaUltimaEntrada) VALUES
('Amoxicilina', 'Antibi�tico oral', 'Tableta', 0.35, 500, 100, '2025-07-01'),
('Ibuprofeno', 'Antiinflamatorio', 'Tableta', 0.25, 300, 50, '2025-07-03'),
('Cefalexina', 'Antibi�tico', 'C�psula', 0.45, 400, 80, '2025-07-02'),
('Prednisolona', 'Corticoide oral', 'Tableta', 0.38, 280, 50, '2025-07-04'),
('Metronidazol', 'Antiparasitario', 'Tableta', 0.30, 200, 40, '2025-06-30'),
('Enrofloxacina', 'Antibi�tico veterinario', 'Tableta', 0.50, 250, 60, '2025-07-05'),
('Furosemida', 'Diur�tico', 'Tableta', 0.42, 150, 30, '2025-07-01'),
('Doxiciclina', 'Antibi�tico', 'Tableta', 0.33, 350, 70, '2025-07-06'),
('Ketamina', 'Anest�sico inyectable', 'ml', 1.20, 120, 30, '2025-07-02'),
('Meloxicam', 'Antiinflamatorio', 'ml', 1.50, 100, 25, '2025-07-03'),
('Tramadol', 'Analg�sico', 'ml', 1.80, 110, 20, '2025-07-04'),
('Vitamina B', 'Suplemento nutricional', 'ml', 0.90, 200, 40, '2025-07-02'),
('Ivermectina', 'Antiparasitario', 'ml', 0.75, 180, 35, '2025-07-03'),
('Ranitidina', 'Protector g�strico', 'Tableta', 0.28, 260, 50, '2025-07-01'),
('Omeprazol', 'Reductor de �cido estomacal', 'Tableta', 0.36, 300, 60, '2025-07-05');

INSERT INTO Facturas (PropietarioID, FechaFactura, MontoTotal) VALUES
(1, '2025-07-01', 45.00),
(2, '2025-07-02', 22.00),
(3, '2025-07-03', 80.00),
(4, '2025-07-04', 65.00),
(5, '2025-07-05', 50.00),
(6, '2025-07-06', 28.00),
(7, '2025-07-07', 72.00),
(8, '2025-07-08', 34.00),
(9, '2025-07-09', 91.00),
(10, '2025-07-10', 29.00),
(11, '2025-07-11', 41.00),
(12, '2025-07-12', 55.00),
(13, '2025-07-13', 63.00),
(14, '2025-07-14', 44.00),
(15, '2025-07-15', 37.00);

INSERT INTO Pagos (FacturaID, FechaPago, MontoPago, MetodoPago, ReferenciaPago) VALUES
(1, '2025-07-01', 45.00, 'Efectivo', '111111'),
(2, '2025-07-02', 22.00, 'Tarjeta', '111112'),
(3, '2025-07-03', 80.00, 'Transferencia', '111113'),
(4, '2025-07-04', 65.00, 'Efectivo', '111114'),
(5, '2025-07-05', 50.00, 'Tarjeta', '111115'),
(6, '2025-07-06', 28.00, 'Transferencia', '111116'),
(7, '2025-07-07', 72.00, 'Efectivo', '111117'),
(8, '2025-07-08', 34.00, 'Tarjeta', '123456'),
(9, '2025-07-09', 91.00, 'Transferencia', '324152'),
(10, '2025-07-10', 29.00, 'Efectivo', '321654'),
(11, '2025-07-11', 41.00, 'Tarjeta', '321423'),
(12, '2025-07-12', 55.00, 'Transferencia', '456789'),
(13, '2025-07-13', 63.00, 'Efectivo', '221133'),
(14, '2025-07-14', 44.00, 'Tarjeta', '113322'),
(15, '2025-07-15', 37.00, 'Transferencia', '112233');

INSERT INTO DetalleFactura (FacturaID, ServicioID, MedicamentoID, Cantidad, PrecioUnitorioAplicado, Subtotal) VALUES
(1, 1, 1, 10, 0.35, 3.50),
(2, 2, 2, 1, 15.00, 15.00),
(3, 3, 3, 2, 12.00, 24.00),
(4, 4, 4, 1, 120.00, 120.00),
(5, 5, 5, 1, 35.00, 35.00),
(6, 6, 6, 1, 40.00, 40.00),
(7, 7, 7, 1, 22.00, 22.00),
(8, 8, 8, 1, 80.00, 80.00),
(9, 9, 9, 1, 30.00, 30.00),
(10, 10, 10, 1, 45.00, 45.00),
(11, 11, 11, 1, 50.00, 50.00),
(12, 12, 12, 1, 38.00, 38.00),
(13, 13, 13, 1, 18.00, 18.00),
(14, 14, 14, 1, 20.00, 20.00),
(15, 15, 15, 1, 28.00, 28.00);

INSERT INTO Vacunas (NombreVacuna, TipoVacuna, DosisRecomendada) VALUES
('Rabia', 'Virus', '1 ml anual'),
('Parvovirus', 'Virus', '2 ml cada 6 meses'),
('Moquillo', 'Virus', '1 ml anual'),
('Hepatitis', 'Virus', '2 ml anual'),
('Leptospirosis', 'Bacteria', '1 ml anual'),
('Tos de las perreras', 'Bacteria', '1 ml semestral'),
('Panleucopenia', 'Virus', '2 ml anual'),
('Calicivirus', 'Virus', '1 ml anual'),
('Herpesvirus felino', 'Virus', '1 ml anual'),
('Coronavirus canino', 'Virus', '1 ml anual'),
('Virus del Nilo', 'Virus', '1 ml anual'),
('Influenza canina', 'Virus', '1 ml anual'),
('Brucelosis', 'Bacteria', '1 ml anual'),
('T�tanos', 'Bacteria', '1 ml anual'),
('Virus de la leucemia felina', 'Virus', '1 ml anual');

INSERT INTO VacunasAplicadas (PacienteID, VacunaID, PersonalID, FechaAplicacion, Dosis, Lote, FechaProximoRefuerzo) VALUES
(1, 1, 1, '2025-07-01', '1 ml', 'L001', '2026-07-01'),
(2, 2, 2, '2025-07-02', '2 ml', 'L002', '2026-01-02'),
(3, 3, 3, '2025-07-03', '1 ml', 'L003', '2026-07-03'),
(4, 4, 4, '2025-07-04', '2 ml', 'L004', '2026-07-04'),
(5, 5, 5, '2025-07-05', '1 ml', 'L005', '2026-07-05'),
(6, 6, 6, '2025-07-06', '1 ml', 'L006', '2026-01-06'),
(7, 7, 7, '2025-07-07', '2 ml', 'L007', '2026-07-07'),
(8, 8, 8, '2025-07-08', '1 ml', 'L008', '2026-07-08'),
(9, 9, 9, '2025-07-09', '2 ml', 'L009', '2026-01-09'),
(10, 10, 10, '2025-07-10', '1 ml', 'L010', '2026-07-10'),
(11, 11, 11, '2025-07-11', '1 ml', 'L011', '2026-07-11'),
(12, 12, 12, '2025-07-12', '1 ml', 'L012', '2026-07-12'),
(13, 13, 13, '2025-07-13', '2 ml', 'L013', '2026-01-13'),
(14, 14, 14, '2025-07-14', '1 ml', 'L014', '2026-07-14'),
(15, 15, 15, '2025-07-15', '2 ml', 'L015', '2026-01-15');

INSERT INTO Citas (PacienteID, PropietarioID, PersonalID, FechaCita, HoraCita, MotivoCita, NotasCita) VALUES
(1, 1, 1, '2025-07-01', '10:00 AM', 'Chequeo', 'Paciente saludable'),
(2, 2, 2, '2025-07-02', '11:00 AM', 'Vacuna anual', 'Aplicaci�n sin complicaciones'),
(3, 3, 3, '2025-07-03', '09:30 AM', 'Dolor de o�do', 'Se agita al tocarle la oreja'),
(4, 4, 4, '2025-07-04', '10:30 AM', 'Limpieza dental', 'Dentadura sin sarro'),
(5, 5, 5, '2025-07-05', '02:00 PM', 'Revisi�n general', 'Buen estado f�sico'),
(6, 6, 6, '2025-07-06', '03:00 PM', 'Desparasitaci�n', 'Peso adecuado'),
(7, 7, 7, '2025-07-07', '12:00 PM', 'Consulta por v�mitos', 'Se recomienda dieta blanda'),
(8, 8, 8, '2025-07-08', '01:00 PM', 'Dolor de est�mago', 'Posible infecci�n'),
(9, 9, 9, '2025-07-09', '11:30 AM', 'Corte de u�as', 'Cooperativo'),
(10, 10, 10, '2025-07-10', '04:00 PM', 'Vacuna de refuerzo', 'Sin reacciones'),
(11, 11, 11, '2025-07-11', '05:00 PM', 'Chequeo post cirug�a', 'Recuperaci�n exitosa'),
(12, 12, 12, '2025-07-12', '09:00 AM', 'Evaluaci�n nutricional', 'Se recomienda cambio de alimento'),
(13, 13, 13, '2025-07-13', '08:00 AM', 'Revisi�n por diarrea', 'Dieta especial por 3 d�as'),
(14, 14, 14, '2025-07-14', '07:30 AM', 'Aplicaci�n microchip', 'Todo en orden'),
(15, 15, 15, '2025-07-15', '10:00 AM', 'Molestia ocular', 'Ojos irritados, prescripci�n de gotas');

INSERT INTO ConsultasMedicas (PacienteID, PersonalID, CitaID, FechaConsulta, Sintomas, Diagnostico, Tratamiento, Observaciones, PesoActual, Temperatura) VALUES
(1, 1, 1, '2025-07-01', 'Ninguno', 'Salud estable', 'Vitaminas', 'Activo', '8.5', '38.2'),
(2, 2, 2, '2025-07-02', 'Sin s�ntomas', 'Vacuna aplicada', 'Control anual', 'Cooperativo', '4.2', '38.0'),
(3, 3, 3, '2025-07-03', 'Irritaci�n', 'Otitis leve', 'Antibi�tico', 'Revisi�n en 7 d�as', '22.4', '37.9'),
(4, 4, 4, '2025-07-04', 'Mal aliento', 'Acumulaci�n de sarro', 'Limpieza dental', 'Us� anestesia', '3.8', '38.1'),
(5, 5, 5, '2025-07-05', 'Ninguno', 'Salud estable', 'Vitaminas', 'Ninguna complicaci�n', '28.0', '38.5'),
(6, 6, 6, '2025-07-06', 'Leve p�rdida de apetito', 'Par�sitos internos', 'Desparasitaci�n', 'Repetir en 3 semanas', '3.9', '38.3'),
(7, 7, 7, '2025-07-07', 'V�mito y debilidad', 'Gastritis leve', 'Anti�cido', 'Dieta blanda recomendada', '2.5', '38.6'),
(8, 8, 8, '2025-07-08', 'Dolor abdominal', 'Posible infecci�n', 'Antibi�tico', 'Monitorear por 5 d�as', '1.1', '38.0'),
(9, 9, 9, '2025-07-09', 'Sin s�ntomas', 'Solo grooming', 'Sin medicamentos', 'Paciente tranquilo', '0.3', '39.2'),
(10, 10, 10, '2025-07-10', 'Sin s�ntomas', 'Refuerzo aplicado', 'Observaci�n 24h', 'Sin complicaciones', '5.6', '38.1'),
(11, 11, 11, '2025-07-11', 'Cicatrizaci�n', 'Postquir�rgico estable', 'Cuidados locales', 'Sin infecci�n', '10.5', '38.3'),
(12, 12, 12, '2025-07-12', 'Bajo peso', 'Desnutrici�n leve', 'Suplementos', 'Cambio de alimento', '26.5', '37.8'),
(13, 13, 13, '2025-07-13', 'Diarrea', 'Infecci�n intestinal', 'Antibi�ticos y dieta especial', 'Revisi�n en 5 d�as', '0.8', '39.0'),
(14, 14, 14, '2025-07-14', 'Ninguno', 'Microchip aplicado', 'Observaci�n por 48h', 'Todo en orden', '3.0', '38.0'),
(15, 15, 15, '2025-07-15', 'Irritaci�n ocular', 'Conjuntivitis', 'Gotas oft�lmicas', 'Evitar exposici�n al polvo', '18.5', '38.4');

INSERT INTO MedicamentosAdministrados (ConsultaID, MedicamentoID, FechaAdministracion, Dosis, ViaAdministracion, CantidadUtilizada) VALUES
(1, 1, '2025-07-01', '1 tableta', 'Oral', '1'),
(2, 2, '2025-07-02', '2 tabletas', 'Oral', '2'),
(3, 3, '2025-07-03', '1 c�psula', 'Oral', '1'),
(4, 4, '2025-07-04', '1 tableta', 'Oral', '1'),
(5, 5, '2025-07-05', '1 tableta', 'Oral', '1'),
(6, 6, '2025-07-06', '2 tabletas', 'Oral', '2'),
(7, 7, '2025-07-07', '1 ml', 'Inyectable', '1'),
(8, 8, '2025-07-08', '1 ml', 'Inyectable', '1'),
(9, 9, '2025-07-09', 'Sin dosis', 'No administrado', '0'),
(10, 10, '2025-07-10', '1 ml', 'Inyectable', '1'),
(11, 11, '2025-07-11', '2 ml', 'Inyectable', '2'),
(12, 12, '2025-07-12', '2 ml', 'Oral', '2'),
(13, 13, '2025-07-13', '1 ml', 'Oral', '1'),
(14, 14, '2025-07-14', '1 tableta', 'Oral', '1'),
(15, 15, '2025-07-15', '1 tableta', 'Oral', '1');

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


ALTER TABLE Personal
DROP COLUMN rol;	

create view CargarPacientes as
select pacienteId,nombrePac,especiepac,razapac,nacimientopac,pesopac,sexopac,colorpac from Pacientes
select *from CargarPacientes