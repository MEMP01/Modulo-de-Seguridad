CREATE PROCEDURE spInsertarNuevoGrupoUsuario
(@id INT OUTPUT,
@idgrupo INT ,
@Legajo INT )
AS
set nocount off;
set xact_abort on;
declare @trancount int = @@trancount;
begin try
			if @trancount=0
			begin transaction;
				insert INTO Grupo_Usuario (id_grupo,legajo) VALUES (@idgrupo, @Legajo);

				COMMIT TRANSACTION;  
	end try
	begin catch
				
				if (XACT_STATE() =-1)
									rollback;
				if (XACT_STATE() =1) AND @trancount =0
									rollback;
				if (XACT_STATE() =1) and @trancount>0
									rollback transaction spInsertarNuevoGrupoUsuario;

	end catch