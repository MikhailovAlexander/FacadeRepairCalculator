using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//Переписать с учетом регулярных выражений

namespace Project
{
    public class User
    {
        readonly int id;
        string hashPassword;

        public static Regex nameRegex = new Regex(@"^([А-Я][а-я]+ ){1,4}[А-Я][а-я]+$");
        public static Regex passportRegex = new Regex(@"^(\d{4} \d{6} \d{1,2}\.\d{1,2}\.\d{4}( \w+\.*)+)$");
        public static Regex loginRegex = new Regex(@"^(\w+@[A-z_]+?\.[A-z]{2,6})$");
        public static Regex passwordRegex = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z\d_]{8,15}$");

        public string Name { get; set; }
        public string Passport { get; set; }
        public string Login { get; set; }
        public bool ManagerAccess { get; set; }
        public string SaltString{ get; set; }
        public int Id { get { return id; } }
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
        public void SaveTo(IDriverDB driver)
        {
            driver.CreateUser(this);
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
            return output;
        }
    }
}
