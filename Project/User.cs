using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public class User: BaseWithName
    {
        string hashPassword;

        private static Regex userNameRegex = new Regex(@"^([А-Я][а-я]+ ){1,4}[А-Я][а-я]+$");
        private static Regex passportRegex = new Regex(
            @"^(\d{4} \d{6} \d{1,2}\.\d{1,2}\.\d{4}( \w+\.*)+)$");
        private static Regex loginRegex = new Regex(@"^(\w+@[A-z_]+?\.[A-z]{2,6})$");
        private static Regex passwordRegex = new Regex(
            @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z\d_]{8,15}$");

        public const string nameTableInDB = "application_user";

        public string Passport { get; set; }
        public string Login { get; set; }
        public bool ManagerAccess { get; set; }
        public string SaltString { get; set; }
        public string HashPassword { get { return hashPassword; } }

        public User(): base()
        {
            Passport = "Не установлено";
            Login = "Не установлено";
            ManagerAccess = false;
        }

        public User(string name, string passport, string login, bool acces):base(name)
        {
            Passport = passport;
            Login = login;
            ManagerAccess = acces;
        }

        public User(int id, string name, string passport, string login, string hashPassword, 
            bool acces, string saltString):base(id, name)
        {
            Passport = passport;
            Login = login;
            this.hashPassword = hashPassword;
            ManagerAccess = acces;
            this.SaltString = saltString;
        }

        public User(string name, string passport, string login, string hashPassword, bool access, 
            string saltString) : base(name)
        {
            Passport = passport;
            Login = login;
            this.hashPassword = hashPassword;
            ManagerAccess = access;
            SaltString = saltString;
        }


        public void ChangePassword(string newPassword, IHashPasswordCreator hashPasswordCreator)
        {
            hashPasswordCreator.EncodePasswordAndGenerteSalt(newPassword);
            hashPassword = hashPasswordCreator.GetHashToString();
            SaltString = hashPasswordCreator.GetSaltToString();
        }

        public bool CheckPassword(string password2Check, IHashPasswordCreator hashPasswordCreator)
        {
            return hashPasswordCreator.VeryfyHash(password2Check, HashPassword, SaltString);
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateUser(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateUser(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteUser(id);
        }

        public override string ToString()
        {
            string output = $"[{Id}] {Name} {Passport} {Login} {ManagerAccess}";
            return output;
        }

        public new static bool NameIsMatch(string string2Check)
        {
            return userNameRegex.IsMatch(string2Check);
        }

        public static bool PassportIsMatch(string string2Check)
        {
            return passportRegex.IsMatch(string2Check);
        }

        public static bool LoginIsMatch(string string2Check)
        {
            return loginRegex.IsMatch(string2Check);
        }

        public static bool PasswordIsMatch(string string2Check)
        {
            return passwordRegex.IsMatch(string2Check);
        }

        public Project[] GetProjects(IDriverDB driver)
        {
            return driver.ReadAllProjectByUser(id);
        }

        public Payment[] GetPaymentsByProject(int idProject, IDriverDB driver)
        {
            return driver.ReadPaymentsByUserAndProject(id, idProject);
        }

        public decimal GetAmountCompletedWorkByProject(int idProject, IDriverDB driver)
        {
            return driver.GetAmountCompletedWorkByProjectAndUser(idProject, id);
        }

        public decimal GetAmountAcceptedWorkByProject(int idProject, IDriverDB driver)
        {
            return driver.GetAmountAcceptedWorkByProjectAndUser(idProject, id);
        }

        public decimal GetAmountRejectedWorkByProject(int idProject, IDriverDB driver)
        {
            return driver.GetAmountRejectedWorkByProjectAndUser(idProject, id);
        }
    }
}
