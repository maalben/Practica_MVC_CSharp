CREATE PROC spConsultaPaises
AS
SELECT * FROM dbo.tblpaises
GO


CREATE PROC spNuevoPais
@nombrepais VARCHAR(50)
AS
INSERT INTO dbo.tblpaises (nombrepais)
VALUES (@nombrepais)
GO


CREATE PROC spGuarCambiosPais
@idpais INT,
@nombrepais VARCHAR(50)
AS
UPDATE dbo.tblpaises SET
nombrepais = @nombrepais WHERE
idpais = @idpais
GO


CREATE PROC spEliminarPais
@idpais INT
AS
DELETE FROM dbo.tblpaises WHERE
idpais = @idpais
GO


CREATE PROC spGuardarNuevoParticipantes
@cedula INT,
@nombre VARCHAR(100),
@pais INT,
@edad TINYINT = NULL
AS
INSERT INTO dbo.tblparticipantes (cedula, nombre, pais, edad)
VALUES (@cedula, @nombre, @pais, @edad)
GO


CREATE PROC spConsultaParticipantes
AS
SELECT 
par.cedula AS "CÉDULA",
par.nombre AS "NOMBRE PARTICIPANTE",
pai.nombrepais AS "PAÍS",
par.edad AS "EDAD"
FROM dbo.tblparticipantes par
INNER JOIN dbo.tblpaises pai
ON par.pais = pai.idpais
GO


CREATE PROC spGuardarCambiosParticipantesSINPais
@cedula INT,
@nombre VARCHAR(100),
@edad TINYINT = NULL
AS
UPDATE dbo.tblparticipantes SET 
nombre = @nombre, edad = @edad
WHERE cedula = @cedula
GO


CREATE PROC spGuardarCambiosParticipantesCONPais
@cedula INT,
@nombre VARCHAR(100),
@pais INT,
@edad TINYINT = NULL
AS
UPDATE dbo.tblparticipantes SET 
nombre = @nombre, pais = @pais, edad = @edad
WHERE cedula = @cedula
GO


CREATE PROC spEliminarParticipantes
@cedula INT
AS
DELETE FROM dbo.tblparticipantes  
WHERE cedula = @cedula
GO