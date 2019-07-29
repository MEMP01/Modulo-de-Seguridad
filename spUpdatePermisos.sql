CREATE PROCEDURE spUpdatePermisos
(
@id_permisos INT ,
@idgrupo INT ,
@idformulario INT,
@idAccion INT
)
AS 
set nocount off;
set xact_abort on;
declare @trancount int = @@trancount;
begin try
			if @trancount=0
			begin transaction;
			UPDATE Permisos SET
            id_Grupo=@idgrupo,
			Id_formulario=@idformulario,
			id_Accion=@idAccion
			WHERE Permisos.ID_Permisos=@id_permisos;
COMMIT TRANSACTION;  
end TRY
BEGIN catch
				
				if (XACT_STATE() =-1)
									rollback;
				if (XACT_STATE() =1) AND @trancount =0
									rollback;
				if (XACT_STATE() =1) and @trancount>0
									rollback transaction spUpdatePermisos;
end catch