using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Functions
{
    public class Authentication
    {
        int hashLen = 20;
        static List<char> lHex = new List<char>{'0', '1', '2', '3', '4', '5', '6', '7',
                    '8' , '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        public string Encrypt(string user_input_password)
        {
            var password = user_input_password;
            var sha = new SHA1CryptoServiceProvider();
            var passwordByteArray = ASCIIEncoding.ASCII.GetBytes(password);
            var getTimeNow = DateTime.Now.Millisecond.ToString();
            var TimeByteArray = ASCIIEncoding.ASCII.GetBytes(getTimeNow);
            var passwordSaltArray = new byte[passwordByteArray.Length + TimeByteArray.Length];

            Array.Copy(passwordByteArray, passwordSaltArray, passwordByteArray.Length);
            Array.Copy(TimeByteArray, 0, passwordSaltArray, passwordByteArray.Length, TimeByteArray.Length);

            var passwordHashArray = sha.ComputeHash(passwordByteArray);
            var passwordSaltArrayHashed = new byte[passwordHashArray.Length + TimeByteArray.Length];

            Array.Copy(passwordHashArray, passwordSaltArrayHashed, passwordHashArray.Length);
            Array.Copy(TimeByteArray, 0, passwordSaltArrayHashed, passwordHashArray.Length, TimeByteArray.Length);

            var encryptedPassword = BitConverter.ToString(passwordHashArray).Replace("-", "");

            return encryptedPassword;
        }

        public string Decrypt(string user_input_password, string db_password)
        {
            var password = user_input_password;
            var sha = new SHA1CryptoServiceProvider();
            var passwordByteArray = ASCIIEncoding.ASCII.GetBytes(password);
            var db_passwordCharArray = db_password.ToCharArray();
            var db_passwordByteArray = new byte[db_password.Length / 2 - hashLen];

            for (int i = hashLen * 2, j = 0; i < db_passwordCharArray.Length; i++)
            {
                db_passwordByteArray[j++] = (byte)(lHex.IndexOf(db_passwordCharArray[i]) * 16 + lHex.IndexOf(db_passwordCharArray[i + 1]));
            }

            var passwordSaltArray = new byte[passwordByteArray.Length + db_passwordByteArray.Length];
            Array.Copy(passwordByteArray, passwordSaltArray, passwordByteArray.Length);
            Array.Copy(db_passwordByteArray, 0, passwordSaltArray, passwordByteArray.Length, db_passwordByteArray.Length);

            var passwordHashArray = sha.ComputeHash(passwordByteArray);
            var passwordSaltArrayHashed = new byte[passwordHashArray.Length + db_passwordByteArray.Length];

            Array.Copy(passwordHashArray, passwordSaltArrayHashed, passwordHashArray.Length);
            Array.Copy(db_passwordByteArray, 0, passwordSaltArrayHashed, passwordHashArray.Length, db_passwordByteArray.Length);

            var decryptedPassword = BitConverter.ToString(passwordHashArray).Replace("-", "");

            return decryptedPassword;
        }
    }
}
