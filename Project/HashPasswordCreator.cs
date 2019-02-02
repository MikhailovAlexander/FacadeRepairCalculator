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
            return Convert.ToBase64String(hashBytes);
        }
        public string GetSaltToString()
        {
            return Convert.ToBase64String(this.saltBytes);
        }
        public bool VeryfyHash(string correctHash, string saltString)
        {
            try
            {
                ConvertSalt(saltString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string checkPasswordHash = GetHashToString();
            return String.Equals(checkPasswordHash, correctHash);
        }
        void ConvertSalt(string saltString)
        {
            if (string.IsNullOrWhiteSpace(saltString))
                throw new Exception("Ошибка преобразований при проверке пароля 'Salt==null'");

            byte[] salt=new byte[saltSise];
            try
            {
                salt = Convert.FromBase64String(saltString);
                this.saltBytes = salt;
            }
            catch
            {
                throw new Exception("Ошибка проверки пароля. Не удалось преобразовать 'Salt'");
            }
        }
    }
}
