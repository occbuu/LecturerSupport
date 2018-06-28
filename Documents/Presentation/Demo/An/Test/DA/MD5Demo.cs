using System;
using System.Security.Cryptography;
using System.Text;

namespace DemoCryptography
{
    public class MD5Demo
    {
        public static void Test(string s)
        {
            Console.WriteLine("Original Message : " + s);
            Console.WriteLine();
            var md5hashedMessage = ComputeHashMD5(Encoding.UTF8.GetBytes(s));
            Console.WriteLine("MD5 Hashes");
            Console.WriteLine("Message 1 hash = " + md5hashedMessage + "affefegrg");
            Console.ReadLine();
        }

        public static string ComputeHashMD5(byte[] toBeHashed)
        {
            using (var md5 = MD5.Create())
            {
                var data = md5.ComputeHash(toBeHashed);
                var sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }
    }
}