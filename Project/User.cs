using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Project
{
    public class User
    {
        int id;
        string hashPassword;
        public string Name { get; set; }
        public string Passport { get; set; }
        public string Login { get; set; }
        public bool ManagerAccess { get; set; }
        byte[] salt;
        public string SaltString{ get; set; }
        public int Id { get { return id; } }
        public byte[] Salt { get { return salt; } }//REMOVE!!!
        public string HashPassword { get { return hashPassword; } }
        public User()
        {
            Name = "None";
            Passport = "None";
            Login = "None";
            ManagerAccess = false;
        }
        public User(string name, string passport, string login, bool acces)
        {
            Name = name;
            Passport = passport;
            Login = login;
            ManagerAccess = acces;
        }
        public User(int id, string name, string passport, string login, string hashPassword, bool acces, string saltString)
        {
            this.id = id;
            Name = name;
            Passport = passport;
            Login = login;
            this.hashPassword = hashPassword;
            ManagerAccess = acces;
            this.SaltString = saltString;
        }
        public User(string name, string passport, string login, string hashPassword, bool access, string saltString)
        {
            Name = name;
            Passport = passport;
            Login = login;
            this.hashPassword = hashPassword;
            ManagerAccess = access;
            this.SaltString = saltString;
        }
        public void SetHashPasword(string newPassword)
        {
            
            try
            {
                HashPasswordCreator creator = new HashPasswordCreator(newPassword);
                this.hashPassword=creator.GetHashToString();
                this.SaltString = creator.GetSaltToString();
                MessageBox.Show($"Для пользователя {this.Name} установлен новый пароль");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //static byte[] GetSalt(int length)
        //{
        //    RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();//Крипто-генератор случайных чисел
        //    byte[] salt = new byte[length];//Создание байтовой переменной
        //    rngCsp.GetBytes(salt);// Заполнение случайными значениями
        //    return salt;
        //}
        //static string GetHashPassword(string input, HashAlgorithm algorithm, byte[] salt)
        //{
        //    byte[] inputBytes = Encoding.UTF8.GetBytes(input);//Преобразование строки в массив байтов
        //    byte[] saltedInput = new byte[inputBytes.Length + salt.Length];//создание массива для соли с паролем
        //    salt.CopyTo(saltedInput, 0); //Добавление соли в массив
        //    inputBytes.CopyTo(saltedInput, salt.Length);//Добавление пароля в массив
        //    byte[] hashBytes = algorithm.ComputeHash(saltedInput);//Получение хэша соли с паролем
        //    StringBuilder strB = new StringBuilder(hashBytes.Length * 2);//Создание переменной для преобразования хэша в строку
        //    foreach (byte b in hashBytes)
        //        strB.AppendFormat("{0:X2}", b);
        //    return strB.ToString();
        //}
        //public void SetHashPaswordSHA256(string newPassword)
        //{
        //    if (string.IsNullOrWhiteSpace(newPassword))
        //        throw new Exception("Введенный пароль не содержит символов");
        //    byte[] salt = GetSalt(32);
        //    var deriveBytes = new SHA256CryptoServiceProvider();
        //    string newHashPassword = GetHashPassword(newPassword, deriveBytes, salt);
        //    this.hashPassword = newHashPassword;
        //    this.salt = salt;
        //}
        //public bool CheckPassword(string passwordToCheck)
        //{
        //    var deriveBytes = new SHA256CryptoServiceProvider();
        //    string HashPasswordToCheck = GetHashPassword(passwordToCheck, deriveBytes, this.salt);
        //    return HashPasswordToCheck.Equals(this.hashPassword);
        //}

        public void SaveTo(IDriverDB driver)
        {
            driver.SaveUser(this);
        }
        public void Update(IDriverDB driver)
        {
            driver.UpdateUser(this);
        }
        public static User ReadUser(string loginInput, IDriverDB driver)
        {
            return driver.ReadUser(loginInput);
        }

        public override string ToString()
        {
            string output = $"[{Id}] {Name} {Passport} {Login} {ManagerAccess}";
            if (hashPassword != null) output += hashPassword;
            if (SaltString != null) output += SaltString;
            return output;
        }
    }
}
