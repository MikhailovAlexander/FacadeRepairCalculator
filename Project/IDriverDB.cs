using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public interface IDriverDB
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        User ReadUser(string loginInput);
        User ReadUser(int idForSearch);
        void DeleteUser(int id);
        User[] ReadAllUsers();

        void CreateClient(string clientName);
        void UpdateClient(int idClient, string newClientName);
        string[] ReadAllClients();

        void CreateProject(Project project);
        void UpdateProject(Project project);
        Project ReadProject(int idForSearch);
        Project[] ReadAllProject();
        Project[] ReadAllProjectByState(ProjectState stateToSearch);
        void DeleteProject(int id);
        void AddUserToProject(int idUser, int idProject);
        void RemoveUserFromProject(int idUser, int idProject);
        User[] ReadUsersByProject(int idForSearch);

    }
}
