using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SteamGuardCodeGiver
{


    /**
     * most important methods
     *  Encryption.Crypt(string) // returns encrypted string 
     *  Encryption.Decrypt(string) // returns unencrypts string
     *  Can only be unencrypted on the same machine!
     *  Using Microsoft's ProtectedData Class
     *  Reference: https://stackoverflow.com/questions/9031537/really-simple-encryption-with-c-sharp-and-symmetricalgorithm  
     **/

    public static class c
    {
        static byte[] z = { 0, 0, 0, 0, 0 }; //Additional Entropy

        public static string cc(this string text)
        {
            try
            {
                return Convert.ToBase64String(
                ProtectedData.Protect(Encoding.Unicode.GetBytes(text), z, DataProtectionScope.LocalMachine));
            }
            catch (CryptographicException e)
            {
                Debug.WriteLine("Data was not encrypted. An error occurred.");
                Debug.WriteLine(e.ToString());
                throw e;
                //return null;
            }
        }

        public static string dd(this string text)
        {
            try
            {
                return Encoding.Unicode.GetString(ProtectedData.Unprotect(Convert.FromBase64String(text), z, DataProtectionScope.LocalMachine));
            }
            catch (CryptographicException e)
            {
                Debug.WriteLine("Data was not decrypted. An error occurred.");
                Debug.WriteLine(e.ToString());
                throw e;
                //return null;
            }
        }
    }
}







