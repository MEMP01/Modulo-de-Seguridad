CREATE PROCEDURE EliminarUsuarios 
(@DNI int 

)
AS
set nocount off;
set xact_abort on;
declare @trancount int = @@trancount;
begin try 
if @trancount=0
begin transaction ;
DELETE FROM Usuarios WHERE DNI=@DNI;
commit transaction
end try
begin catch
				
				if (XACT_STATE() =-1)
									rollback;
				if (XACT_STATE() =1) AND @trancount =0
									rollback;
				if (XACT_STATE() =1) and @trancount>0
									rollback transaction updateUsuarioss;



	
	end catch