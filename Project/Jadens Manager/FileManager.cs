using System.Security.Cryptography;
using System.IO;

namespace Jadens_Manager
{
    
    public class JDAT
    {
        public List<DATA> datas;
        public JDAT(List<DATA> datas)
        {
            this.datas = datas;
        }
    }
    public class DATA
    {
        public string user;
        public string password;
        public DATA(string user, string password)
        {
            this.user = user;
            this.password = password;
        }
    }
    public class JDATK
    {
        public byte[] key;
        public byte[] iv;
        public JDATK(byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
        }
    }
    
    public static class FileManager
    {

        public static string EncryptJson(string jsonData, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(jsonData);
                    swEncrypt.Flush();
                    csEncrypt.FlushFinalBlock();
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        public static string DecryptJson(string encryptedData, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedData)))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
        public static JDATK GenerateKeyAndIV()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();
                return new JDATK(aesAlg.Key, aesAlg.IV);
            }
        }
    }
}
