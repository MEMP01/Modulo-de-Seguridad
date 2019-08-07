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
            SHA256 sha256 = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        /// <summary>
        ///     metodo de encriptacion con   SHA512
        /// </summary>
        /// <param name="input">ingrese la cadena de tipo string a encriptar</param>
        /// <returns>devuelve la cadena pasada por parametro encriptada con SHA256</returns>
        public string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
