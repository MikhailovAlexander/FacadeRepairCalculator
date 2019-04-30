using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Project
{
    class HashPasswordCreator: IHashPasswordCreator
    {
        const int saltSise=4;
        private byte[] saltBytes;
        private byte[] passwordBytes;

        public HashPasswordCreator()
        {
            saltBytes = new byte[0];
            passwordBytes = new byte[0];
        }

        public void EncodePasswordAndGenerteSalt(string passwordInput)
        {
            if(string.IsNullOrWhiteSpace(passwordInput))
                throw new Exception("Введенный пароль не содержит символов");
            passwordBytes = Encoding.UTF8.GetBytes(passwordInput);
            saltBytes = GetRandomSalt(saltSise);
        }

        private byte[] GetRandomSalt(int length)
        {
            //Крипто-генератор случайных чисел
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] salt = new byte[length];//Создание байтовой переменной
            rngCsp.GetBytes(salt);// Заполнение случайными значениями
            return salt;
        }

        public string GetHashToString()
        {
            if (passwordBytes.Length == 0 || saltBytes.Length == 0)
                throw new Exception("Ошибка проверки пароля");
            else
            {
                //создание массива для соли с паролем
                byte[] saltedPassword = new byte[passwordBytes.Length + saltBytes.Length];
                //Добавление соли в массив
                saltBytes.CopyTo(saltedPassword, 0);
                //Добавление пароля в массив
                passwordBytes.CopyTo(saltedPassword, saltBytes.Length);
                var deriveBytes = new SHA256CryptoServiceProvider();
                //Получение хэша соли с паролем
                byte[] hashBytes = deriveBytes.ComputeHash(saltedPassword);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public string GetSaltToString()
        {
            if (passwordBytes.Length == 0 || saltBytes.Length == 0)
                throw new Exception("Ошибка проверки пароля");
            else
            {
                return Convert.ToBase64String(this.saltBytes);
            }
        }

        public bool VeryfyHash(string password2Check, string correctHash, string saltString)
        {
            //TODO
            saltBytes = ConvertSalt(saltString);
            passwordBytes = Encoding.UTF8.GetBytes(password2Check);
            string passwordHash2Check = GetHashToString();
            return String.Equals(passwordHash2Check, correctHash);
        }

        private byte[] ConvertSalt(string saltString)
        {
            if (string.IsNullOrWhiteSpace(saltString))
                throw new Exception("Ошибка преобразований при проверке пароля 'Salt==null'");

            byte[] salt=new byte[saltSise];
            salt = Convert.FromBase64String(saltString);
            return salt;
        }
    }
}
