CREATE PROCEDURE SpInsertPermisos
(
@id_permisos INT OUTPUT	,
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
			INSERT INTO Permisos 
			(id_Grupo,Id_formulario,id_Accion) VALUES (@idgrupo, @idformulario, @idAccion);
			COMMIT TRANSACTION;  
	end try
	begin catch
				
				if (XACT_STATE() =-1)
									rollback;
				if (XACT_STATE() =1) AND @trancount =0
									rollback;
				if (XACT_STATE() =1) and @trancount>0
									rollback transaction SpInsertPermisos;

	end catch