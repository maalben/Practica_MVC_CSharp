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
