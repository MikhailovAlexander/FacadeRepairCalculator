﻿using System;
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
        readonly int id;
        string hashPassword;
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
            return output;
        }
    }
}
