INSERT INTO dbo.Acciones
(
    NombreAccion
)
VALUES
('Alta' -- NombreAccion - varchar(60)
    ),('Baja'),('Modificar'),('Buscar'),
	('Listar'),('Exportar'),('Importar')

	DELETE  FROM Acciones

	SELECT * FROM	dbo.Acciones
INSERT INTO dbo.EstadoGrupo
(
    Estadogrupo
)
VALUES
('Activo' -- Estadogrupo - varchar(60)
    ), ('Inactivo')

	SELECT * FROM	dbo.EstadoGrupo

	INSERT INTO dbo.EstadoUsuario
	(
	    Estado
	)
	VALUES
	('Activo' -- Estado - varchar(60)
	    ),('Inactivo')

		SELECT * FROM dbo.EstadoUsuario

		INSERT INTO dbo.EstadoUsuarios
		(
		    Estado
		)
		VALUES
		('Activo' -- Estado - varchar(60)
	    ),('Inactivo')

		SELECT * FROM dbo.EstadoUsuarios

		INSERT INTO dbo.Modulo
		(
		    NombreModulo
		)
		VALUES
		('Modulo de Seguridad' -- NombreModulo - varchar(60)
		    ),('Modulo de Compras'),('Modulo Ventas'),('Modulo de Auditoria'),
			('Modulo de Facturacion'),('Modulo de Stock')
			SELECT * FROM dbo.Modulo

		INSERT INTO dbo.Formularios
		(
		    Nombre_Formulario,
		    Modulo
		)
		VALUES
		(   'Login',-- Nombre_Formulario - varchar(60)
			1  -- Modulo - int
		    ),('Gestion de Grupo',1),
			('Gestion de Usuarios',1),
			('Gestionar de Usuario',1),
			('Permisos para Formularios ',1),
			('Cambiar Clave',1),
			('Recuperar Clave',1),
			('Auditoria',4)

			SELECT * FROM dbo.Formularios

INSERT INTO dbo.Usuarios
(
    DNI,
    Apellido,
    Nombre,
    Sexo,
    Edad,
    Email,
    Telefono,
    Pais,
    Provincia,
    Direccion,
    CodigoPostal,
    Estado
)
VALUES
(   35567890,  -- DNI - int
    'MOMO', -- Apellido - varchar(60)
    'PEP', -- Nombre - varchar(60)
    'M', -- Sexo - char(1)
    30,  -- Edad - int
    'oahdñwqhed@ñoahdw.com', -- Email - varchar(120)
    813598413,  -- Telefono - int
    'Argentina', -- Pais - varchar(60)
    'Santa Fe', -- Provincia - varchar(120)
    'ALGO', -- Direccion - varchar(200)
    1250,  -- CodigoPostal - int
    1   -- Estado - int
    ),
	(   456852124,  -- DNI - int
    'LALA', -- Apellido - varchar(60)
    'Pepa', -- Nombre - varchar(60)
    'F', -- Sexo - char(1)
    32,  -- Edad - int
    'oqejlasdjoi@faee.com', -- Email - varchar(120)
    7896541025,  -- Telefono - int
    'Argentina', -- Pais - varchar(60)
    'Santa Fe', -- Provincia - varchar(120)
    'ALGO', -- Direccion - varchar(200)
    6398,  -- CodigoPostal - int
    2   -- Estado - int
    )
	SELECT * FROM dbo.Usuarios

	INSERT into