CREATE PROCEDURE EliminarUsuario
(@legajo INT)
AS
set nocount off;
set xact_abort on;
declare @trancount int = @@trancount;
begin try 
if @trancount=0
begin transaction ;
DELETE FROM Usuario WHERE Usuario.Legajo=@legajo;
commit transaction
end try
begin catch
				if (XACT_STATE() =-1)
									rollback;
				if (XACT_STATE() =1) AND @trancount =0
									rollback;
				if (XACT_STATE() =1) and @trancount>0
									rollback transaction EliminarUsuario;
end catch
