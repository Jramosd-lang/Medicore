-- Crear la base de datos
CREATE DATABASE IF NOT EXISTS medicore CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

-- Seleccionar la base de datos
USE medicore;

-- Eliminar tablas en orden inverso por dependencias
DROP TABLE IF EXISTS facturas;
DROP TABLE IF EXISTS evento_historial_medico;
DROP TABLE IF EXISTS historial_medico;
DROP TABLE IF EXISTS citas;
DROP TABLE IF EXISTS especialidades;
DROP TABLE IF EXISTS doctores;
DROP TABLE IF EXISTS pacientes;

-- PACIENTES
CREATE TABLE pacientes (
    id_paciente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    numero_documento VARCHAR(50) NOT NULL,
    tipo_documento VARCHAR(30),
    correo VARCHAR(100),
    telefono VARCHAR(20),
    sexo VARCHAR(10) NOT NULL,
    ocupacion VARCHAR(100),
    religion VARCHAR(50),
    UNIQUE INDEX idx_documento_paciente (numero_documento),
    INDEX idx_nombre_paciente (nombre, apellido),
    INDEX idx_sexo_paciente (sexo)
);

-- DOCTORES
CREATE TABLE doctores (
    id_doctor INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    numero_documento VARCHAR(50) NOT NULL,
    tipo_documento VARCHAR(30),
    correo VARCHAR(100),
    telefono VARCHAR(20),
    sexo VARCHAR(10) NOT NULL,
    especialidad VARCHAR(100) NOT NULL,
    numero_licencia VARCHAR(100) NOT NULL,
    password_ VARCHAR(100) NOT NULL,
    UNIQUE INDEX idx_documento_doctor (numero_documento),
    INDEX idx_nombre_doctor (nombre, apellido),
    INDEX idx_especialidad_doctor (especialidad)
);

-- ESPECIALIDADES
CREATE TABLE especialidades (
    id_especialidad INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    UNIQUE INDEX idx_nombre_especialidad (nombre)
);

-- CITAS
CREATE TABLE citas (
    id_cita INT AUTO_INCREMENT PRIMARY KEY,
    id_paciente INT NOT NULL,
    id_doctor INT NOT NULL,
    id_especialidad INT NOT NULL,
    ruta_cita VARCHAR(255) NOT NULL,
    fecha_cita DATETIME NOT NULL,
    hora_cita VARCHAR(10) NOT NULL,
    estado_cita VARCHAR(50) NOT NULL,
    motivo_cita VARCHAR(255) NOT NULL,
    observaciones TEXT,
    FOREIGN KEY (id_paciente) REFERENCES pacientes(id_paciente) ON DELETE CASCADE,
    FOREIGN KEY (id_doctor) REFERENCES doctores(id_doctor) ON DELETE CASCADE,
    FOREIGN KEY (id_especialidad) REFERENCES especialidades(id_especialidad) ON DELETE CASCADE,
    INDEX idx_fecha_cita (fecha_cita),
    INDEX idx_estado_cita (estado_cita),
    INDEX idx_id_paciente (id_paciente),
    INDEX idx_id_doctor (id_doctor)
);

-- HISTORIAL_MEDICO
CREATE TABLE historial_medico (
    id_historial_medico INT AUTO_INCREMENT PRIMARY KEY,
    id_paciente INT NOT NULL,
    tipo_sangre VARCHAR(5),
    alergias TEXT,
    enfermedades_cronicas TEXT,
    medicamentos_actuales TEXT,
    antecedentes_familiares TEXT,
    vacunas TEXT,
    FOREIGN KEY (id_paciente) REFERENCES pacientes(id_paciente) ON DELETE CASCADE,
    INDEX idx_id_paciente_historial (id_paciente)
);

-- EVENTO_HISTORIAL_MEDICO
CREATE TABLE evento_historial_medico (
    id_evento INT AUTO_INCREMENT PRIMARY KEY,
    id_historial_medico INT NOT NULL,
    fecha DATETIME NOT NULL,
    descripcion TEXT,
    observaciones TEXT,
    diagnostico TEXT,
    tratamiento TEXT,
    medicamentos TEXT,
    recomendaciones TEXT,
    examenes TEXT,
    FOREIGN KEY (id_historial_medico) REFERENCES historial_medico(id_historial_medico) ON DELETE CASCADE,
    INDEX idx_fecha_evento (fecha),
    INDEX idx_id_historial_evento (id_historial_medico)
);

-- FACTURAS
CREATE TABLE facturas (
    id_factura INT AUTO_INCREMENT PRIMARY KEY,
    id_cita INT NOT NULL UNIQUE,
    id_paciente INT NOT NULL,
    monto_total DECIMAL(10,2) NOT NULL,
    servicio_ofrecido VARCHAR(255) NOT NULL,
    fecha_emision DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    ruta_pdf VARCHAR(255),
    FOREIGN KEY (id_cita) REFERENCES citas(id_cita) ON DELETE CASCADE,
    FOREIGN KEY (id_paciente) REFERENCES pacientes(id_paciente) ON DELETE CASCADE,
    INDEX idx_id_paciente_factura (id_paciente),
    INDEX idx_fecha_emision (fecha_emision)
);
