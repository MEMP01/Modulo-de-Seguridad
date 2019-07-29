CREATE PROCEDURE SpUdatespNuevoGrupoUsuario
(@id INT ,
@idgrupo INT ,
@Legajo INT )
AS
set nocount off;
set xact_abort on;
declare @trancount int = @@trancount;
begin try
			if @trancount=0
			begin transaction;
			UPDATE Grupo_Usuario SET
            id_grupo=@idgrupo,
			legajo=@Legajo
			WHERE Grupo_Usuario.Id=@id;
			COMMIT TRANSACTION;  
end TRY
BEGIN catch
				
				if (XACT_STATE() =-1)
									rollback;
				if (XACT_STATE() =1) AND @trancount =0
									rollback;
				if (XACT_STATE() =1) and @trancount>0
									rollback transaction SpUdatespNuevoGrupoUsuario;
end catch
