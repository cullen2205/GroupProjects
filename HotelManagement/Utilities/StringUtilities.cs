using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace HotelManagement
{
    public static class StringUtilities
    {
        static readonly string numberPattern = @"^\d+$";
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("X2"));
            }
            return hash.ToString();
        }

        public static bool IsNumber(string input)
        {
            return Regex.IsMatch(input, numberPattern);
        }

        public static string LazyFormat(int i)
        {
            return string.Format("{0:n0}", i);
        }
    }
}
