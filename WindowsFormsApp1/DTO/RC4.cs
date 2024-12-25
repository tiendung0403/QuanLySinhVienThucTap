using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.DTO
{
    public class RC4
    {
        private const int MOD = 256; // Hằng số MOD cho RC4, mảng S sẽ có độ dài 256 phần tử

        // Hàm hoán đổi giá trị của 2 phần tử trong mảng S tại vị trí i và j
        public static void Swap(int[] s, int i, int j)
        {
            int temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }

        // Khởi tạo mảng S dựa trên thuật toán KSA với khóa đầu vào
        public static int[] KSA(string key)
        {
            int[] S = new int[MOD]; // Mảng S có độ dài 256
            int keyLength = key.Length; // Độ dài của khóa

            // Khởi tạo mảng S với các giá trị từ 0 đến 255
            for (int i = 0; i < MOD; i++)
            {
                S[i] = i;
            }

            int j = 0;
            // Hoán đổi các phần tử trong S dựa trên khóa
            for (int i = 0; i < MOD; i++)
            {
                j = (j + S[i] + key[i % keyLength]) % MOD; // Tính j
                Swap(S, i, j); // Hoán đổi
            }
            return S; // Trả về mảng S 
        }

        // Sinh chuỗi khóa (keystream) dùng thuật toán PRGA dựa trên mảng S đã được tạo từ KSA
        public static List<int> PRGA(int[] S, int textLength)
        {
            List<int> keystream = new List<int>(); // Tạo Danh sách chứa keystream
            int i = 0, j = 0;

            // Sinh keystream với độ dài bằng độ dài của văn bản
            for (int k = 0; k < textLength; k++)
            {
                i = (i + 1) % MOD; // Tăng i theo mod 256
                j = (j + S[i]) % MOD; // Tăng j theo mod 256

                Swap(S, i, j); // Hoán đổi giá trị trong S 

                int K = S[(S[i] + S[j]) % MOD]; // Lấy giá trị keystream K từ mảng S
                keystream.Add(K); // Thêm K vào keystream
            }
            return keystream;
        }
        
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

        // Hàm Mã hóa văn bản bằng RC4
        public static string Encrypt(string key, string plaintext)
        {
            int[] S = KSA(key); // Tạo mảng S bằng KSA với khóa đầu vào
            List<int> keystream = PRGA(S, plaintext.Length); // Sinh keystream có độ dài bằng plaintext

            StringBuilder ciphertext = new StringBuilder(); // Chuỗi chứa mã hóa

            // XOR từng ký tự của plaintext với ký tự tương ứng trong keystream
            for (int i = 0; i < plaintext.Length; i++)
            {
                int plaintextChar = plaintext[i]; // Ký tự tại vị trí i trong plaintext
                int keystreamChar = keystream[i]; // Giá trị keystream tương ứng

                int cipherChar = plaintextChar ^ keystreamChar; // XOR giữa ký tự plaintext và keystream
                ciphertext.Append(cipherChar.ToString("X2")); // Định dạng thành hex và thêm vào ciphertext
            }
            return ciphertext.ToString(); // Trả về chuỗi mã hóa
        }

        // Giải mã văn bản bằng RC4
        public static string Decrypt(string key, string ciphertext)
        {
            int[] S = KSA(key); // Tạo mảng S bằng KSA với khóa đầu vào
            List<int> keystream = PRGA(S, ciphertext.Length / 2); // Sinh keystream cho ciphertext

            byte[] decodedBytes = new byte[ciphertext.Length / 2]; // Mảng byte để lưu giá trị sau giải mã
            for (int i = 0; i < decodedBytes.Length; i++)
            {
                int cipherChar = Convert.ToInt32(ciphertext.Substring(i * 2, 2), 16); // Lấy từng cặp hex
                int keystreamChar = keystream[i]; // Giá trị keystream tương ứng
                decodedBytes[i] = (byte)(cipherChar ^ keystreamChar); // XOR giữa cipherChar và keystream
            }
            return Encoding.UTF8.GetString(decodedBytes); // Chuyển mảng byte thành chuỗi UTF-8 và trả về
        }

        // public static void Main(string[] args)
        // {
        //     string key = "Tấn công lúc bình minh"; // Khóa dùng để mã hóa và giải mã
        //     string plaintext = "attack tomorow"; // Chuỗi gốc cần mã hóa

        //     // Mã hóa
        //     string ciphertext = Encrypt(key, plaintext);
        //     Console.WriteLine("Plaintext: " + plaintext);
        //     Console.WriteLine("Ciphertext: " + ciphertext);

        //     // Giải mã
        //     string decryptedText = Decrypt(key, ciphertext);
        //     Console.WriteLine("Decrypted text: " + decryptedText);
        // }
    }
}

