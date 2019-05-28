using Acceso_a_Datos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{                      /// <summary>
/// Esta Clase se utiliza para realizar ejecutar Altas, Bajas , Modificacion, Busquedas y Listados de elementos para la tabla Usuarios 
/// </summary>
    public class DatosUsuarios
    {

        private int DNI;
        private string apellido;
        private string nombreusuario;
        private char sexo;
        private int edad;
        private string email;
        private int telefono;
        private string pais;
        private string provincia;
        private string direcion;
        private int codigopostal;
        private int estado;


        /// <summary>
        ///    encapsulado del campo DNI
        /// </summary>
        public int DNI1 { get => DNI; set => DNI = value; }
        /// <summary>
        ///    encapsulado del campo Apellido
        /// </summary>
        public string Apellido { get => apellido; set => apellido = value; }
        /// <summary>
        ///    encapsulado del campo Nombre
        /// </summary>
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        /// <summary>
        ///    encapsulado del campo sexo
        /// </summary>
        public char Sexo { get => sexo; set => sexo = value; }
        /// <summary>
        ///    encapsulado del campo Edad
        /// </summary>
        public int Edad { get => edad; set => edad = value; }
        /// <summary>
        ///   encapsulado del campo Email
        /// </summary>
        public string Email { get => email; set => email = value; }
        /// <summary>
        ///    encapsulado del campo Telefono
        /// </summary>
        public int Telefono { get => telefono; set => telefono = value; }
        /// <summary>
        ///    encapsulado del campo Pais
        /// </summary>
        public string Pais { get => pais; set => pais = value; }
        /// <summary>
        ///    encapsulado del campo provincia
        /// </summary>
        public string Provincia { get => provincia; set => provincia = value; }
        /// <summary>
        ///    encapsulado del campo Direccion
        /// </summary>
        public string Direcion { get => direcion; set => direcion = value; }
        /// <summary>
        ///    encapsulado del campo Codigo Postal
        /// </summary>
        public int Codigopostal { get => codigopostal; set => codigopostal = value; }
        /// <summary>
        ///    encapsulado del campo Estado del Usuario
        /// </summary>
        public int Estado { get => estado; set => estado = value; }

        //campos auxiliares
        private SqlCommand SqlComando;
        private ConneccionSql ConneccionSql;

        /// <summary>
        /// Constructor datos usuario sin parametros
        /// </summary>
        public DatosUsuarios()
        {
        }
        /// <summary>
        /// Constructor datos usuarios
        /// </summary>
        /// <param name="dNI1">Dni del usuario</param>
        /// <param name="apellido">Apellido del usuario</param>
        /// <param name="nombreusuario">Nomrbre del usuario</param>
        /// <param name="sexo">Sexo del usuario</param>
        /// <param name="edad">Edad del usuario</param>
        /// <param name="email">Email del usuario</param>
        /// <param name="telefono">Telefono del usuario</param>
        /// <param name="pais">pais del usuario</param>
        /// <param name="provincia">provincia del usuario</param>
        /// <param name="direcion">direccion del usuario</param>
        /// <param name="codigopostal">codigo postal del usuario</param>
        /// <param name="estado">estado del usuario</param>
        public DatosUsuarios(int dNI1, string apellido, string nombreusuario, char sexo, int edad, string email, int telefono, string pais, string provincia, string direcion, int codigopostal, int estado)
        {

            DNI1 = dNI1;
            Apellido = apellido;
            Nombreusuario = nombreusuario;
            Sexo = sexo;
            Edad = edad;
            Email = email;
            Telefono = telefono;
            Pais = pais;
            Provincia = provincia;
            Direcion = direcion;
            Codigopostal = codigopostal;
            Estado = estado;
        }
        /// <summary>
        /// Metodo para ingresar un usuario al sistema
        /// </summary>
        /// <param name="datosUsuarios">Ingresar objeto del tipo DatosUsuarios</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string IngresarUsuarios(DatosUsuarios datosUsuarios)
        {
            string rta = "";
            ConneccionSql = new ConneccionSql();

            try
            {
                ConneccionSql.OpenConneccion();
                SqlConnection sqlConnection = new SqlConnection(ConneccionSql.ObtenerConeccion());

                SqlComando = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Sp_ABMC_Usuarios",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparametersDNI = new SqlParameter
                {
                    ParameterName = "@DNI",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.DNI1
                };

                SqlComando.Parameters.Add(sqlparametersDNI);

                SqlParameter sqlparametreApellido = new SqlParameter
                {
                    ParameterName = "@Apellido",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuarios.Apellido
                };
                SqlComando.Parameters.Add(sqlparametreApellido);

                SqlParameter sqlparametersNombre = new SqlParameter
                {
                    ParameterName = "@Nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuarios.Nombreusuario

                };

                SqlComando.Parameters.Add(sqlparametersNombre);

                SqlParameter sqlparametersSexo = new SqlParameter
                {
                    ParameterName = "@Sexo",
                    SqlDbType = SqlDbType.Char,
                    Value = datosUsuarios.Sexo

                };

                SqlComando.Parameters.Add(sqlparametersSexo);

                SqlParameter sqlparametersEdad = new SqlParameter
                {
                    ParameterName = "@Edad",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.Edad

                };

                SqlComando.Parameters.Add(sqlparametersEdad);

                SqlParameter sqlparametersEmail = new SqlParameter
                {
                    ParameterName = "@Email",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 120,
                    Value = datosUsuarios.Email

                };

                SqlComando.Parameters.Add(sqlparametersEmail);

                SqlParameter sqlparametersTelefono = new SqlParameter
                {
                    ParameterName = "@Telefono",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.Telefono

                };

                SqlComando.Parameters.Add(sqlparametersTelefono);

                SqlParameter sqlparametersPais = new SqlParameter
                {
                    ParameterName = "@Pais",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuarios.Pais
                };

                SqlComando.Parameters.Add(sqlparametersPais);

                SqlParameter sqlparametersProvincia = new SqlParameter
                {
                    ParameterName = "@Provincia",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 120,
                    Value = datosUsuarios.Provincia

                };

                SqlComando.Parameters.Add(sqlparametersProvincia);

                SqlParameter sqlparametersDireccion = new SqlParameter
                {
                    ParameterName = "@Direccion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 200,
                    Value = datosUsuarios.Direcion
                };

                SqlComando.Parameters.Add(sqlparametersDireccion);

                SqlParameter sqlparametersCodigoPostal = new SqlParameter
                {
                    ParameterName = "@CodigoPostal",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.Codigopostal
                };

                SqlComando.Parameters.Add(sqlparametersCodigoPostal);


                SqlParameter sqlparametersEstado = new SqlParameter
                {
                    ParameterName = "@Estado",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.Estado
                };

                SqlComando.Parameters.Add(sqlparametersEstado);

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Insert"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);

                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                ConneccionSql.CloseConneccion();
            }
            return rta;
        }

        /// <summary>
        ///   Metodo para modificar un usuario al sistema
        /// </summary>
        /// <param name="datosUsuarios">Ingresar objeto del tipo DatosUsuarios</param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string UpdateUsuarios(DatosUsuarios datosUsuarios)
        {
            string rta = "";
            ConneccionSql = new ConneccionSql();

            try
            {
                ConneccionSql.OpenConneccion();
                SqlConnection sqlConnection = new SqlConnection(ConneccionSql.ObtenerConeccion());

                SqlComando = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Sp_ABMC_Usuarios",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparametersDNI = new SqlParameter
                {
                    ParameterName = "@DNI",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.DNI1
                };

                SqlComando.Parameters.Add(sqlparametersDNI);

                SqlParameter sqlparametreApellido = new SqlParameter
                {
                    ParameterName = "@Apellido",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuarios.Apellido
                };
                SqlComando.Parameters.Add(sqlparametreApellido);

                SqlParameter sqlparametersNombre = new SqlParameter
                {
                    ParameterName = "@Nombre",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuarios.Nombreusuario

                };

                SqlComando.Parameters.Add(sqlparametersNombre);

                SqlParameter sqlparametersSexo = new SqlParameter
                {
                    ParameterName = "@Sexo",
                    SqlDbType = SqlDbType.Char,
                    Value = datosUsuarios.Sexo

                };

                SqlComando.Parameters.Add(sqlparametersSexo);

                SqlParameter sqlparametersEdad = new SqlParameter
                {
                    ParameterName = "@Edad",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.Edad

                };

                SqlComando.Parameters.Add(sqlparametersEdad);

                SqlParameter sqlparametersEmail = new SqlParameter
                {
                    ParameterName = "@Email",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 120,
                    Value = datosUsuarios.Email

                };

                SqlComando.Parameters.Add(sqlparametersEmail);

                SqlParameter sqlparametersTelefono = new SqlParameter
                {
                    ParameterName = "@Telefono",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.Telefono

                };

                SqlComando.Parameters.Add(sqlparametersTelefono);

                SqlParameter sqlparametersPais = new SqlParameter
                {
                    ParameterName = "@Pais",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 60,
                    Value = datosUsuarios.Pais
                };

                SqlComando.Parameters.Add(sqlparametersPais);

                SqlParameter sqlparametersProvincia = new SqlParameter
                {
                    ParameterName = "@Provincia",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 120,
                    Value = datosUsuarios.Provincia

                };

                SqlComando.Parameters.Add(sqlparametersProvincia);

                SqlParameter sqlparametersDireccion = new SqlParameter
                {
                    ParameterName = "@Direccion",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 200,
                    Value = datosUsuarios.Direcion
                };

                SqlComando.Parameters.Add(sqlparametersDireccion);

                SqlParameter sqlparametersCodigoPostal = new SqlParameter
                {
                    ParameterName = "@CodigoPostal",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.Codigopostal
                };

                SqlComando.Parameters.Add(sqlparametersCodigoPostal);


                SqlParameter sqlparametersEstado = new SqlParameter
                {
                    ParameterName = "@Estado",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.Estado
                };

                SqlComando.Parameters.Add(sqlparametersEstado);

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Update"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);

                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                ConneccionSql.CloseConneccion();
            }
            return rta;

        }

        /// <summary>
        ///    Metodo para Eliminar un usuario al sistema
        /// </summary>
        /// <param name="datosUsuarios"></param>
        /// <returns>respuesta Si o No fue exitosa la operacion</returns>
        public string EliminarUsuario(DatosUsuarios datosUsuarios)
        {

            string rta = "";
            ConneccionSql = new ConneccionSql();

            try
            {


                ConneccionSql.OpenConneccion();
                SqlConnection sqlConnection = new SqlConnection(ConneccionSql.ObtenerConeccion());
                SqlComando = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Sp_ABMC_Usuarios",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparametersDNI = new SqlParameter()
                {
                    ParameterName = "@DNI",
                    SqlDbType = SqlDbType.Int,

                    Value = datosUsuarios.DNI1

                };

                SqlComando.Parameters.Add(sqlparametersDNI);

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Delete"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);



                rta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Ingresar el registro ";

            }
            catch (Exception ex)
            {
                rta = ex.Message;
            }
            finally
            {
                ConneccionSql.CloseConneccion();
            }
            return rta;

        }

        /// <summary>
        ///  Metodo para Listar todos los usuarios del sistema
        /// </summary>
        /// <returns>devuelve todos los usuarios con objeto de tipo datatable</returns>
        public DataTable ListarUsuarios()
        {
            DataTable dataTable;
            ConneccionSql = new ConneccionSql();
            try
            {

                ConneccionSql.OpenConneccion();
                SqlConnection sql = new SqlConnection(ConneccionSql.ObtenerConeccion());
                SqlComando = new SqlCommand
                {
                    Connection = sql,
                    CommandText = "Sp_ABMC_Usuarios",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "select"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);

                SqlDataAdapter sqltabla = new SqlDataAdapter(SqlComando);
                dataTable = new DataTable();
                sqltabla.Fill(dataTable);

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error de Listado", ex);
            }
            finally
            {
                ConneccionSql.CloseConneccion();
            }
            return dataTable;

        }

        /// <summary>
        ///  Metodo para Buscar  a  los usuarios del sistema mediante su DNI
        /// </summary>
        /// <param name="datosUsuarios"></param>
        /// <returns>devuelve el usuario</returns>
        public DataTable BuscarUsuariosPorDNI(DatosUsuarios datosUsuarios)
        {

            DataTable dataTable;
            ConneccionSql = new ConneccionSql();
            try
            {
                ConneccionSql.OpenConneccion();
                SqlConnection sql = new SqlConnection(ConneccionSql.ObtenerConeccion());
                SqlComando = new SqlCommand
                {
                    Connection = sql,
                    CommandText = "Sp_ABMC_Usuarios",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter sqlparametersDNI = new SqlParameter
                {
                    ParameterName = "@DNI",
                    SqlDbType = SqlDbType.Int,
                    Value = datosUsuarios.DNI1
                };

                SqlComando.Parameters.Add(sqlparametersDNI);


                SqlParameter sqlparameterStatementType = new SqlParameter
                {
                    ParameterName = "@statementType",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = "Buscar"
                };

                SqlComando.Parameters.Add(sqlparameterStatementType);

                SqlDataAdapter sqltabla = new SqlDataAdapter(SqlComando);
                dataTable = new DataTable();
                sqltabla.Fill(dataTable);



            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error de Busqueda", ex);
            }
            finally
            {
                ConneccionSql.CloseConneccion();
            }

            return dataTable;
        }







    }
}
