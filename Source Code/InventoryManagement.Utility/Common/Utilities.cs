using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace InventoryManagement.Utility.Common
{
    public class Utilities
    {
        public static string GetMd5Hash(string input)
        {
            using (var md5Hash = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash. 
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes 
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data  
                // and format each one as a hexadecimal string. 
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("X2"));
                }

                // Return the hexadecimal string. 
                return sBuilder.ToString();
            }
        }

        public static string GetEncodedPassword(string password)
        {
            return GetMd5Hash(password + "@inventoryM");
        }

        public static string GetExceptionText(Exception ex)
        {
            //if (ex is EntityValidationException)
            //{
            //    return ex.ToString();
            //}

            if (ex.InnerException == null)
                return ex.Message;

            return ex.Message + "\r\n\r\n+ " + GetExceptionName(ex.InnerException) + GetExceptionText(ex.InnerException);
        }

        private static string GetExceptionName(Exception ex)
        {
            if (ex == null)
                return "";

            return ex.GetType().Name + "\r\n ";
        }
    }
}
