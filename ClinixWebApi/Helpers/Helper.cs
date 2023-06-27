using System.Security.Cryptography;
using System.Text;
using ClinixWebApi.Models;

namespace ClinixWebApi.Helpers
{
    public class Helper
    {

        public static string HashingString(string password)
        {
                var sha = SHA256.Create();
                var asByteArray = Encoding.Default.GetBytes(password);
                var hashedPassword = sha.ComputeHash(asByteArray); 
            return Convert.ToBase64String(hashedPassword);
        }

    }
}
