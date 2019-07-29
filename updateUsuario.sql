CREATE PROCEDURE updateUsuario
(
@Legajo int,
@Clave varchar(1024) ,
@NombreDeUsuario varchar(60),
@DNI int ,
@EstadoDelUsuario  varchar (60)
)
AS 
set nocount off;
set xact_abort on;
declare @trancount int = @@trancount;
begin try
			if @trancount=0
			begin transaction;
			UPDATE usuario SET
            @Clave=Clave,
			@NombreDeUsuario=NombreDeUsuario,
			@DNI=DNI,
			@EstadoDelUsuario=EstadoDelUsuario
			WHERE Legajo=@Legajo;
			COMMIT TRANSACTION;  
end TRY
BEGIN catch
				
				if (XACT_STATE() =-1)
									rollback;
				if (XACT_STATE() =1) AND @trancount =0
									rollback;
				if (XACT_STATE() =1) and @trancount>0
									rollback transaction updateUsuario;
end catch