using System;
using System.Security.Cryptography;
using System.Text;

namespace coWorking.Data.Tools
{
    public static class EncryptData
    {
        public static string EncryptText(string text) {

            using(var sha256 = SHA256.Create())
            {
                var hashByte = 
                sha256.ComputeHash(Encoding.UTF8.GetBytes(text));

                var has = BitConverter.ToString(hashByte)
                    .Replace("-","")
                    .ToLower();

                return has;
            }
        }
    }
}