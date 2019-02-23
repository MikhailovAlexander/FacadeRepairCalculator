using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum ProjectState
    {
        Planned = 1,
        Actual,
        Completed,
        Cancelled
    }

    public class Project
    {
        int id;
        public int Id { get { return id; } }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Client { get; set; }
        public ProjectState State { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfComplete
        {
            get { return DateOfComplete; }
            set
            {
                if (DateOfComplete < DateOfStart) throw new Exception(
                    "Дата завершения проекта не может быть ранее даты начала");
                DateOfComplete = value;
            }
        }

        public Project()
        {
            id = -1;
            Name = "None";
            Address = "None";
            Client = "None";
            State = ProjectState.Planned;
            DateOfStart = DateTime.MinValue;
            DateOfComplete = DateTime.MinValue;
        }

        public Project(string name, string address, string client, ProjectState state, 
            DateTime dateOfStart, DateTime dateOfComplete)
        {
            id = -1;
            Name = name;
            Address = address;
            Client = client;
            State = state;
            DateOfStart = dateOfStart;
            DateOfComplete = dateOfComplete;
        }

        public Project(int id, string name, string address, string client, ProjectState state,
            DateTime dateOfStart, DateTime dateOfComplete)
        {
            this.id = id;
            Name = name;
            Address = address;
            Client = client;
            State = state;
            DateOfStart = dateOfStart;
            DateOfComplete = dateOfComplete;
        }

        public void CreateProject(IDriverDB driver)
        {
            driver.CreateProject(this);
        }

        public void UpdateProject(IDriverDB driver)
        {
            driver.UpdateProject(this);
        }

        public static Project ReadProject(IDriverDB driver, int idForSearch)
        {
            return driver.ReadProject(idForSearch);
        }

        public static Project[] ReadAllProject(IDriverDB driver)
        {
            return driver.ReadAllProject();
        }

        public static Project[] ReadAllProjectByState(IDriverDB driver, ProjectState stateToSearch)
        {
            return driver.ReadAllProjectByState(stateToSearch);
        }

        public void Delete(IDriverDB driver)
        {
            driver.DeleteProject(this.Id);
        }

        public void AddUser(IDriverDB driver, int idUser)
        {
            driver.AddUserToProject(idUser, this.Id);
        }

        public void RemoveUser(IDriverDB driver, int idUser)
        {
            driver.RemoveUserFromProject(idUser, this.Id);
        }

        public User[] ReadUsersByProject(IDriverDB driver)
        {
            return driver.ReadUsersByProject(this.Id);
        }
    }
}
