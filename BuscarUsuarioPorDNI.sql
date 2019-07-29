CREATE PROCEDURE BuscarUsuarioPorDNI
(@DNI INT)
AS 
BEGIN
		SELECT   Usuario.Legajo AS 'Legajo',
				 Usuario.NombreDeUsuario AS 'Nombre de Usuario',	
				 Usuario.DNI AS 'DNI',
				 Usuario.EstadoDelUsuario AS 'Estado del Usuario'
	    FROM Usuario
	    WHERE Usuario.DNI=@DNI
 END       