using System.Security.Cryptography;
using System.Text;

namespace PasswordManager.Services;

public class EncryptionService
{
    private readonly string _key;

    public EncryptionService(IConfiguration configuration)
    {
        // Ideally from environment variable or secure config. For this local app, a fixed but hard to guess string is accepted if not configured, or we generate one.
        _key = configuration["EncryptionKey"] ?? "MinhaSuperChaveSecretaMuitoSegura123!";
    }

    public string Encrypt(string plainText)
    {
        if (string.IsNullOrEmpty(plainText)) return plainText;

        byte[] iv = new byte[16];
        byte[] array;

        using (Aes aes = Aes.Create())
        {
            // Pad right to ensure it has 32 bytes for SHA256 key
            var keyBytes = SHA256.HashData(Encoding.UTF8.GetBytes(_key));
            aes.Key = keyBytes;
            aes.IV = iv;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                    {
                        streamWriter.Write(plainText);
                    }

                    array = memoryStream.ToArray();
                }
            }
        }

        return Convert.ToBase64String(array);
    }

    public string Decrypt(string cipherText)
    {
        if (string.IsNullOrEmpty(cipherText)) return cipherText;

        byte[] iv = new byte[16];
        byte[] buffer = Convert.FromBase64String(cipherText);

        using (Aes aes = Aes.Create())
        {
            var keyBytes = SHA256.HashData(Encoding.UTF8.GetBytes(_key));
            aes.Key = keyBytes;
            aes.IV = iv;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream memoryStream = new MemoryStream(buffer))
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
}
