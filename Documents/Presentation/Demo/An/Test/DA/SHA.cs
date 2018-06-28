using System;
using System.Security.Cryptography;
using System.Text;

namespace DemoCryptography
{
    public class HashData1
    {
        public static byte[] ComputeHashSHA1(byte[] toBeHashed)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHashSHA256(byte[] toBeHashed)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHashSHA512(byte[] toBeHashed)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(toBeHashed);
            }
        }
    }

    public class SHA
    {
        public static void Test()
        {
            var originalMessage = "Original Message to hash"; var originalMessage2 = "This is another message to hash";

            Console.WriteLine("Secure Hash Demonstration in .NET");
            Console.WriteLine("---------------------------------"); Console.WriteLine(); Console.WriteLine("Original Message 1 : " + originalMessage); Console.WriteLine("Original Message 2 : " + originalMessage2); Console.WriteLine();

            var sha1hashedMessage = HashData1.ComputeHashSHA1(Encoding.UTF8.GetBytes(originalMessage));
            var sha1hashedMessage2 = HashData1.ComputeHashSHA1(Encoding.UTF8.GetBytes(originalMessage2));

            var sha256hashedMessage = HashData1.ComputeHashSHA256(Encoding.UTF8.GetBytes(originalMessage));
            var sha256hashedMessage2 = HashData1.ComputeHashSHA256(Encoding.UTF8.GetBytes(originalMessage2));

            var sha512hashedMessage = HashData1.ComputeHashSHA512(Encoding.UTF8.GetBytes(originalMessage));
            var sha512hashedMessage2 = HashData1.ComputeHashSHA512(Encoding.UTF8.GetBytes(originalMessage2));

            Console.WriteLine();
            Console.WriteLine("SHA 1 Hashes");
            Console.WriteLine();
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha1hashedMessage));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha1hashedMessage2)); Console.WriteLine();

            Console.WriteLine("SHA 256 Hashes");
            Console.WriteLine();
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha256hashedMessage));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha256hashedMessage2));
            Console.WriteLine();
            Console.WriteLine("SHA 512 Hashes");
            Console.WriteLine();
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha512hashedMessage));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha512hashedMessage2));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}