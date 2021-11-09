using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    class Util
    {
        public static bool FormIsOpen(string name)
        {
            // Chack is winwos is alreadi open or not
            var OpanForm = Application.OpenForms.Cast<Form>();
            var isOpan = OpanForm.Any(form => form.Name == name);
            return isOpan;
        }

        public static string HasePassword(string password)
        {
            SHA256 sha = SHA256.Create();

            // Convert i/p to byte array and compute the hash.
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Create A new Stringbuilder to collect the bytes and create a string
            StringBuilder stringBuilder = new StringBuilder();

            // loop through each byte of hashed data and format each one as haxadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static string DefultHasePassword()
        {
            SHA256 sha = SHA256.Create();

            // Convert i/p to byte array and compute the hash.
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("password"));

            // Create A new Stringbuilder to collect the bytes and create a string
            StringBuilder stringBuilder = new StringBuilder();

            // loop through each byte of hashed data and format each one as haxadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

    }

}
