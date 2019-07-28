CREATE PROCEDURE insertUsuarios
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
			begin transaction;
				insert into
				 Usuarios(
	DNI  ,
Apellido  ,
Nombre  ,
Sexo  ,
Edad   ,
Email  ,
Telefono  ,
Pais ,
Provincia ,
Direccion  ,
CodigoPostal   ,
Estado  )  values
 (  @DNI  ,
@Apellido  ,
@Nombre  ,
@Sexo  ,
@Edad   ,
@Email  ,
@Telefono ,
@Pais  ,
@Provincia ,
@Direccion  ,
@CodigoPostal  ,
@Estado  
									  );
			
			COMMIT TRANSACTION;  
	end try
	begin catch
				
				if (XACT_STATE() =-1)
									rollback;
				if (XACT_STATE() =1) AND @trancount =0
									rollback;
				if (XACT_STATE() =1) and @trancount>0
									rollback transaction insertUsuarios;



	
	end catch


    