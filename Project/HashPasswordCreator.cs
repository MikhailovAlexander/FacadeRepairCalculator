using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Project
{
    class HashPasswordCreator
    {
        const int saltSise=4;
        byte[] saltBytes;
        byte[] passwordBytes;

        public HashPasswordCreator(string passwordInput)
        {
            if(string.IsNullOrWhiteSpace(passwordInput))
                throw new Exception("Введенный пароль не содержит символов");
            passwordBytes = Encoding.UTF8.GetBytes(passwordInput);
            saltBytes = GetSalt(saltSise);
        }
        static byte[] GetSalt(int length)
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();//Крипто-генератор случайных чисел
            byte[] salt = new byte[length];//Создание байтовой переменной
            rngCsp.GetBytes(salt);// Заполнение случайными значениями
            return salt;
        }
        public string GetHashToString()
        {
            byte[] saltedPassword = new byte[passwordBytes.Length + saltBytes.Length];//создание массива для соли с паролем
            saltBytes.CopyTo(saltedPassword, 0); //Добавление соли в массив
            passwordBytes.CopyTo(saltedPassword, saltBytes.Length);//Добавление пароля в массив
            var deriveBytes = new SHA256CryptoServiceProvider();
            byte[] hashBytes = deriveBytes.ComputeHash(saltedPassword);//Получение хэша соли с паролем
            StringBuilder strB = new StringBuilder(hashBytes.Length * 2);//Создание переменной для преобразования хэша в строку
            foreach (byte b in hashBytes)
                strB.AppendFormat("{0:X2}", b);
            return strB.ToString();
        }
        public string GetSaltToString()
        {
            StringBuilder strB = new StringBuilder(saltBytes.Length * 2);//Создание переменной для преобразования соли в строку
            foreach (byte b in saltBytes)
                strB.AppendFormat("{0:X2}", b);
            return strB.ToString();
        }
        public bool VeryfyHash(string correctHash, string saltString)
        {
            MessageBox.Show(saltString + "  " + GetSaltToString());
            try
            {
                ConvertSalt(saltString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(saltString + "  " + GetSaltToString());
            string checkPasswordHash = GetHashToString();
            return String.Equals(checkPasswordHash, correctHash);
        }
        void ConvertSalt(string saltString)
        {
            if (string.IsNullOrWhiteSpace(saltString) || saltString.Length / 2 != saltSise)
                throw new Exception("Ошибка преобразований при проверке пароля 'Salt==null'");

            byte[] salt=new byte[saltSise];
            int n = 0;
            try
            {
                for (int i = 0; i < saltString.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        char first = saltString[i - 1];
                        char second = saltString[i];
                        char[] arr = { first, second };
                        string actualByteStr = new string(arr);
                        int convInt = Convert. (actualByte);
                        byte actualByte = Convert.ToByte(actualByteStr);
                        salt[n++] = actualByte;
                    }
                }
                this.saltBytes = salt;
            }
            catch
            {
                throw new Exception("Ошибка проверки пароля. Не удалось преобразовать 'Salt'");
            }
        }
    }
}
