using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data base.Utils
{
    public class Criptografia
    {
        public static void CriarPasswordHash(string password, out byte[] hash, out byte[] salt)
        {
            using (var hmac = new System.Security.Criptography.HMACSHAS12())
            {
                salt = hmac.key;
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        
    }
}