CREATE PROCEDURE updateUsuarios
(@DNI int ,
@Apellido varchar(60) ,
@Nombre varchar(60) ,
@Sexo char ,
@Edad  int ,
@Email varchar (120) ,
@Telefono int ,
@Pais varchar (60) ,
@Provincia varchar (120),
@Direccion varchar (200) ,
@CodigoPostal int  ,
@Estado int )
AS
set nocount off;
set xact_abort on;
declare @trancount int = @@trancount;
begin try 
if @trancount=0
begin transaction ;
Update Usuarios set
DNI  =@DNI,
				Apellido =@Apellido ,
Nombre=@Nombre  ,
Sexo =@Sexo ,
Edad   =@Edad,
Email =@Email ,
Telefono  =@Telefono,
Pais =@Pais,
Provincia =@Provincia,
Direccion =@Direccion ,
CodigoPostal =@CodigoPostal  ,
Estado =@Estado 	
			where DNI =@DNI

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
