using System.Text;
using System.Security.Cryptography;

namespace Vista
{        /// <summary>
/// Clase dedicada a encriptiar cadenas de caracteres
/// </summary>
    public class EncriptarContraseñas
    {
        /// <summary>
        /// Contructor de la clase   EncriptarContraseñas
        /// </summary>
        public EncriptarContraseñas() { }

                  /// <summary>
                  /// metodo de encriptacion con SHA256
                  /// </summary>
                  /// <param name="str">ingrese la cadena de tipo string a encriptar</param>
                  /// <returns>devuelve la cadena pasada por parametro encriptada con SHA256</returns>
        public  string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    
    }
}
