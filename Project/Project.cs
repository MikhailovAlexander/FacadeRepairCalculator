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
        private static Dictionary<ProjectState, string> projectStateDictionary =
            new Dictionary<ProjectState, string>
            {
                { ProjectState.Planned, "Планируемый" },
                { ProjectState.Actual, "Текущий" },
                { ProjectState.Completed, "Завершенный" },
                { ProjectState.Canceled, "Отмененный" }
        };

        public static Regex clientRegex = new Regex(@"^(Id\[)(\d+)\],.+");

        public const string nameTableInDB = "project";
        public const string nameTableInDBUserInProject = "user_in_project";
        public const string nameTableInDBTypeOfElementInProject = "type_of_element_in_project";
        
        public string Address { get; set; }
        public int IdClient { get; set; }
        private ProjectState state;
        public ProjectState State { get { return state; } }
        public string StateString
        {
            get { return projectStateDictionary[State]; }
        }
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
            state = ProjectState.Planned;
            DateOfStart = new DateTime(1970, 1, 1);
            DateOfComplete = new DateTime(1970, 1, 1);
            PlannedDateOfComplete = new DateTime(1970, 1, 1);
        }

        public Project(string name, string address, int idClient):base(name)
        {
            Address = address;
            this.IdClient = idClient;
            state = ProjectState.Planned;
            DateOfStart = new DateTime(1970, 1, 1);
            DateOfComplete = new DateTime(1970, 1, 1);
            PlannedDateOfComplete = new DateTime(1970, 1, 1);
        }

        public Project(int id, string name, string address, int idClient):base(id, name)
        {
            Address = address;
            this.IdClient = idClient;
            state = ProjectState.Planned;
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
            this.state = state;
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
            this.state = state;
            DateOfStart = dateOfStart;
            DateOfComplete = dateOfComplete;
            PlannedDateOfComplete = plannedDateOfComplete;
        }

        public override string ToString()
        {
            return $"Id{Id} {Name}";
        }

        public bool DateOfPaymentIsChecked(DateTime date)
        {
            return date >= DateOfStart;
        }

        public bool DateOfCompleteWorkIsChecked(DateTime date)
        {
            return date >= DateOfStart;
        }

        public bool DatesOfStartAndPlanIsChecked(DateTime dateOfStart, 
            DateTime plannedDateOfComplete)
        {
            if (state != ProjectState.Planned || Id == -1)
                return false;
            return plannedDateOfComplete.Date > dateOfStart.Date;
        }

        public bool DateOfCompleteCheck(DateTime dateOfComplete, IDriverDB driver)
        {
            return dateOfComplete.Date >= driver.GetPaymenstByProjectMaxDate(id) &&
                dateOfComplete.Date >= driver.GetWorkLogByProjectMaxDate(id);
        }

        public bool AllWorksAccepted(IDriverDB driver)
        {
            return driver.AllWorksByProjectAccepted(id);
        }

        public bool UserWorksIsPaid(int idUser, IDriverDB driver)
        {
            decimal acceptedWorksByUser = driver.GetAmountAcceptedWorkByProjectAndUser(id, idUser);
            if (acceptedWorksByUser == 0) return true;
            decimal paymentsByUser = driver.GetAmountPaymentsByUserAndProject(id, idUser);
            return paymentsByUser >= acceptedWorksByUser;
        }

        public bool CompleteCheck(DateTime dateOfComplete, IDriverDB driver)
        {
            if (state != ProjectState.Actual || !DateOfCompleteCheck(dateOfComplete, driver) ||
                !AllWorksAccepted(driver))
                return false;
            var usersInProject = ReadUsersByProject(driver);
            foreach(User user in usersInProject)
            {
                if (!UserWorksIsPaid(user.Id, driver)) return false;
            }
            return true;
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

        public void Start (DateTime dateOfStart, DateTime plannedDateOfComplete, 
            IDriverDB driver)
        {
            if(!DatesOfStartAndPlanIsChecked(dateOfStart, plannedDateOfComplete))
                throw new Exception("Дата окончания должна быть позднее даты начала");
            if (state != ProjectState.Planned)
                throw new Exception("Старт возможен только для планируемого проекта");
            state = ProjectState.Actual;
            PlannedDateOfComplete = plannedDateOfComplete;
            DateOfStart = dateOfStart;
            Update(driver);
        }

        public void Complete(DateTime dateOfComplete, IDriverDB driver)
        {
            if (CompleteCheck(dateOfComplete, driver))
            {
                state = ProjectState.Completed;
                DateOfComplete = dateOfComplete;
                Update(driver);
            }
            else throw new Exception("Завершение проекта невозможно");
        }

        public void Cancel(IDriverDB driver)
        {
            state = ProjectState.Canceled;
            Update(driver);
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

        public decimal GetTotalAmountPlannedWork(IDriverDB driver)
        {
            return driver.GetAmountPlannedWorkByProject(id);
        }

        public decimal GetTotalAmountCompletedWork(IDriverDB driver)
        {
            return driver.GetAmountCompletedWorkByProject(id);
        }

        public decimal GetTotalAmountAcceptedWork(IDriverDB driver)
        {
            return driver.GetAmountAcceptedWorkByProject(id);
        }

        public decimal GetTotalAmountRejectedWork(IDriverDB driver)
        {
            return driver.GetAmountRejectedWorkByProject(id);
        }

        public decimal GetAmountCompletedWorkByUser(int idUser, IDriverDB driver)
        {
            return driver.GetAmountCompletedWorkByProjectAndUser(id, idUser);
        }

        public decimal GetAmountAcceptedWorkByUser(int idUser, IDriverDB driver)
        {
            return driver.GetAmountAcceptedWorkByProjectAndUser(id, idUser);
        }

        public decimal GetAmountRejectedWorkByUser(int idUser, IDriverDB driver)
        {
            return driver.GetAmountRejectedWorkByProjectAndUser(id, idUser);
        }
    }
}
