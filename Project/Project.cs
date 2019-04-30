using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public class Project:BaseWithName
    {
        public static Dictionary<ProjectState, string> ProjectStateDictionary =
            new Dictionary<ProjectState, string>
            {
                { ProjectState.Planned, "Планируемый" },
                { ProjectState.Actual, "Текущий" },
                { ProjectState.Completed, "Завершенный" },
                { ProjectState.Cancelled, "Отмененный" }
        };

        public static Regex clientRegex = new Regex(@"^(Id\[)(\d+)\],.+");

        public const string nameTableInDB = "project";
        public const string nameTableInDBUserInProject = "user_in_project";
        public const string nameTableInDBTypeOfElementInProject = "type_of_element_in_project";

        public string Address { get; set; }
        public int IdClient { get; set; }
        public ProjectState State { get; set; }
        public DateTime DateOfStart { get; set; }
        DateTime dateOfComplete;
        public DateTime DateOfComplete
        {
            get { return dateOfComplete; }
            set
            {
                if (value != new DateTime(1970, 1, 1) && value < DateOfStart) throw new Exception(
                    "Дата завершения проекта не может быть ранее даты начала");
                dateOfComplete = value;
            }
        }
        DateTime plannedDateOfComplete;
        public DateTime PlannedDateOfComplete
        {
            get { return plannedDateOfComplete; }
            set
            {
                if (value < DateOfStart) throw new Exception(
                    "Дата завершения проекта не может быть ранее даты начала");
                plannedDateOfComplete = value;
            }
        }

        public Project(): base()
        {
            Address = "Не определено";
            IdClient = -1;
            State = ProjectState.Planned;
            DateOfStart = new DateTime(1970, 1, 1);
            DateOfComplete = new DateTime(1970, 1, 1);
            PlannedDateOfComplete = new DateTime(1970, 1, 1);
        }

        public Project(string name, string address, int idClient):base(name)
        {
            Address = address;
            this.IdClient = idClient;
            State = ProjectState.Planned;
            DateOfStart = new DateTime(1970, 1, 1);
            DateOfComplete = new DateTime(1970, 1, 1);
            PlannedDateOfComplete = new DateTime(1970, 1, 1);
        }

        public Project(int id, string name, string address, int idClient):base(id, name)
        {
            Address = address;
            this.IdClient = idClient;
            State = ProjectState.Planned;
            DateOfStart = new DateTime(1970, 1, 1);
            DateOfComplete = new DateTime(1970, 1, 1);
            PlannedDateOfComplete = new DateTime(1970, 1, 1);
        }

        public Project(string name, string address, int idClient, ProjectState state, 
            DateTime dateOfStart, DateTime dateOfComplete, 
            DateTime plannedDateOfComplete) : base(name)
        {
            Address = address;
            this.IdClient = idClient;
            State = state;
            DateOfStart = dateOfStart;
            DateOfComplete = dateOfComplete;
            PlannedDateOfComplete = plannedDateOfComplete;
        }

        public Project(int id, string name, string address,int idClient, ProjectState state,
            DateTime dateOfStart, DateTime dateOfComplete, 
            DateTime plannedDateOfComplete) : base(id, name)
        {
            Address = address;
            this.IdClient = idClient;
            State = state;
            DateOfStart = dateOfStart;
            DateOfComplete = dateOfComplete;
            PlannedDateOfComplete = plannedDateOfComplete;
        }

        public override string ToString()
        {
            return $"Id{Id} {Name}";
        }

        public override bool Equals(object obj)
        {
            Project project = (Project)obj;
            return Id == project.Id && Name == project.Name && Address == project.Address &&
                DateOfStart == project.DateOfStart && DateOfComplete == project.DateOfComplete &&
                PlannedDateOfComplete == project.PlannedDateOfComplete;
        }

        public bool DateOfPaymentIsChecked(DateTime date)
        {
            if (State != ProjectState.Actual || Id == -1)
                return false;
            return date >= DateOfStart;
        }

        public static bool AddressIsMatch(string string2Check)
        {
            return NameIsMatch(string2Check);
        }

        public static bool ClientIsMatch(string string2Check)
        {
            return clientRegex.IsMatch(string2Check);
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateProject(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateProject(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteProject(this.Id);
        }

        public void AddUser(IDriverDB driver, int idUser)
        {
            driver.AddUserToProject(idUser, this.Id);
        }

        public void DeleteUser(IDriverDB driver, int idUser)
        {
            driver.DeleteUserFromProject(idUser, this.Id);
        }

        public User[] ReadUsersByProject(IDriverDB driver)
        {
            return driver.ReadUsersInProject(this.Id);
        }

        public void AddTypeOfElement(IDriverDB driver, int idTypeOfElement)
        {
            driver.AddTypeOfElementInProject(idTypeOfElement, this.Id);
        }

        public void DeleteTypeOfElement(IDriverDB driver, int idTypeOfElement)
        {
            driver.DeleteTypeOfElementFromProject(idTypeOfElement, this.Id);
        }

        public TypeOfElement[] ReadTypesOfElementByProject(IDriverDB driver)
        {
            return driver.ReadTypesOfElementInProject(this.Id);
        }

        public decimal GetTotalSquare(IDriverDB driver)
        {
            return driver.GetTotalSquare(id);
        }

        public decimal GetTotalAmount(IDriverDB driver)
        {
            return driver.GetAmountByWorksFromProject(id);
        }

        public decimal GetAmountPayments(IDriverDB driver)
        {
            return driver.GetAmountPaymentsByProject(id);
        }
    }
}
