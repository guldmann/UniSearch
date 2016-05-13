using System.Security.Cryptography;
using System.Text;

namespace Pcis.common
{
    public static class SHA256Hash
    {
        private static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}
