using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public class Payment:Base
    {
        public const string nameTableInDB = "payment";

        private double amount;
        public int IdUser { get; set; }
        public int IdProject { get; set; }
        public DateTime DateOfPayment { get; set; }
        public double Amount
        {
            get { return amount; }
            set
            {
                if (value < 0) throw new Exception("Сумма не может быть отрицательной");
                else amount = value;
            }
        }

        public Payment():base()
        {
            IdUser = -1;
            IdProject = -1;
            DateOfPayment = new DateTime(1970, 1, 1);
            Amount = 0;
        }

        public Payment(int idUser, int idProject, DateTime dateOfPayment, double amount) : base()
        {
            IdUser = idUser;
            IdProject = idProject;
            DateOfPayment = dateOfPayment;
            Amount = amount;
        }

        public Payment(int id, int idUser, int idProject, DateTime dateOfPayment, double amount) : 
            base(id)
        {
            IdUser = idUser;
            IdProject = idProject;
            DateOfPayment = dateOfPayment;
            Amount = amount;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreatePayment(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdatePayment(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeletePayment(this.Id);
        }

        public Project GetProject(IDriverDB driver)
        {
            return driver.ReadProject(IdProject);
        }

        public User GetUser(IDriverDB driver)
        {
            return driver.ReadUser(IdUser);
        }

        public bool CheckUserInProject(IDriverDB driver)
        {
            int idUserInProject = -1;
            try
            {
                idUserInProject = driver.GetIdUserInProject(IdUser, IdProject);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (idUserInProject == -1) return false;
            else return true;
        }
    }
}
