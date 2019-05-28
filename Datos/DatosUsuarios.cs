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
        
            private int     DNI  ;
            private string apellido ;
            private string nombreusuario      ;
            private char sexo ;
            private int edad ;
        private string email;
            private int  telefono ;
            private string  pais;
            private string provincia ;
            private string direcion ;
            private int  codigopostal ;
            private int estado ;

      
       
        public int DNI1 { get => DNI; set => DNI = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Direcion { get => direcion; set => direcion = value; }
        public int Codigopostal { get => codigopostal; set => codigopostal = value; }
        public int Estado { get => estado; set => estado = value; }

            
        public DatosUsuarios()
        {
        }

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





    }
}
