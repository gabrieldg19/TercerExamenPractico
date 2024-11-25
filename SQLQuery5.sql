-- Crear la base de datos
CREATE DATABASE MiBaseDeDatos;
GO

-- Usar la base de datos creada
USE MiBaseDeDatos;
GO

-- Crear la tabla Empleados
CREATE TABLE Empleados (
    EmpleadoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Edad INT NOT NULL,
    Salario DECIMAL(18,2) NOT NULL,
    DepartamentoID INT NOT NULL
);

-- Insertar datos de prueba
INSERT INTO Empleados (Nombre, Apellido, Edad, Salario, DepartamentoID)
VALUES ('Juan', 'Pérez', 30, 50000, 1),
       ('María', 'López', 25, 45000, 2),
       ('Carlos', 'González', 35, 60000, 1);
GO