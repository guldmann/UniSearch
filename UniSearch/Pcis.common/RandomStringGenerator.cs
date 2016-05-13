using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pcis.common
{
    public static class RandomStringGenerator
    {
        private static Random random;
        const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        const string NUMBERS = "0123456789";
        const string SYMBOLS = @"~`!@#$%^&*()-_=+<>?:,./\[]{}|'";

        static RandomStringGenerator()
        {
            random = new Random();
        }
        public static string NextString(int length)
        {
            return StringGenerator(length);
        }

        private static string StringGenerator(int length, bool lowerCase = true, bool upperCase = true, bool numbers = true, bool symbols = true)
        {
            char[] charArray = new char[length];
            string charPool = string.Empty;

            if (lowerCase) charPool += LOWERCASE;
            if (upperCase) charPool += UPPERCASE;
            if (numbers) charPool += NUMBERS;
            if (symbols) charPool += SYMBOLS;

            for (int i = 0; i < charArray.Length; i++)
            {
                int index = random.Next(0, charPool.Length);
                charArray[i] = charPool[index];
            }
            return new string(charArray);
        }
    }
}