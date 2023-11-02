using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace encryption_function
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Prompt the user for the input type (file or string)
                Console.WriteLine("What type would you like to encrypt?");
                string inputType = Console.ReadLine();

                // Define paths for the encrypted and decrypted files
                string encryptedPath = "encryptedPath.jpg";
                string decryptedPath = "decrypted.jpg";

                // Generate random encryption key and initialization vector (IV)
                string randomKey = GenerateRandomKey();
                string randomIV = GenerateRandomIV();

                Console.WriteLine($"Random Key: {randomKey}");
                Console.WriteLine($"Random IV: {randomIV}");

                // Encryption and decryption paths for files are fixed, and a message is displayed
                // to use the "input.jpg" file for testing (you can further adapt it to accept any file path)

                if (inputType == "file")
                {
                    Console.WriteLine("Please provide the path to the file you want to encrypt:");
                    string inputPath = Console.ReadLine();
                    EncryptImage(inputPath, encryptedPath, randomKey, randomIV);
                    Console.WriteLine("Encryption complete.");
                    DecryptImage(encryptedPath, decryptedPath, randomKey, randomIV);
                }
                else if (inputType == "string")
                {
                    Console.WriteLine("Please write the text you'd like to encrypt:");
                    string inputData = Console.ReadLine();

                    // Encrypt the provided string and print the result
                    byte[] encryptedData = EncryptString(inputData, randomKey, randomIV);
                    PrintEncryptedData(encryptedData);

                    // Save the encrypted data to a file and decrypt it
                    File.WriteAllBytes(encryptedPath, encryptedData);
                    Console.WriteLine("Encryption complete.");
                    Console.WriteLine(DecryptString(encryptedData, randomKey, randomIV));
                }
                else
                {
                    Console.WriteLine("Invalid input type. Use 'file' or 'string'.");
                    
                }
            }
        }

        static void PrintEncryptedData(byte[] data)
        {
            if (data != null)
            {
                Console.WriteLine("Encrypted Data:");
                Console.WriteLine(Convert.ToBase64String(data));
            }
        }

        static byte[] EncryptString(string input, string key, string iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = Convert.FromBase64String(iv);

                using (MemoryStream memoryStream = new MemoryStream())
                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                    cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    return memoryStream.ToArray();
                }
            }
        }

        static string DecryptString(byte[] input, string key, string iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = Convert.FromBase64String(iv);

                using (MemoryStream memoryStream = new MemoryStream(input))
                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    string decryptedText = new StreamReader(cryptoStream).ReadToEnd();
                    return decryptedText;
                }
            }
        }

        static string GenerateRandomKey()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                return Convert.ToBase64String(aesAlg.Key);
            }
        }

        static string GenerateRandomIV()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateIV();
                return Convert.ToBase64String(aesAlg.IV);
            }
        }

        static void EncryptImage(string inputPath, string outputPath, string key, string iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = Convert.FromBase64String(iv);

                using (FileStream inputFileStream = new FileStream(inputPath, FileMode.Open))
                using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create))
                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, encryptor, CryptoStreamMode.Write))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;

                    while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        cryptoStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }

        static void DecryptImage(string inputPath, string outputPath, string key, string iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = Convert.FromBase64String(iv);

                using (FileStream inputFileStream = new FileStream(inputPath, FileMode.Open))
                using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create))
                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, decryptor, CryptoStreamMode.Read))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;

                    while ((bytesRead = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputFileStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
