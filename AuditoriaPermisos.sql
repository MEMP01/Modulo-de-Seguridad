﻿CREATE TABLE AuditoriaPermisos
(
id INT IDENTITY NOT NULL,
legajo INT NOT NULL,
accion VARCHAR (60) NOT NULL,
idGrupo INT NOT NULL,
idformulario INT NOT NULL,
fecha DATETIME NOT NULL,
)