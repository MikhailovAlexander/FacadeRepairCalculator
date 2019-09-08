using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Project
{
    public interface IDriverDB
    {
        void StartPostgresServer();
        void StopPostgresServer();

        void CreateUser(User user);
        void UpdateUser(User user);
        User ReadUser(string loginInput);
        User ReadUser(int idForSearch);
        void DeleteUser(int idUser);
        User[] ReadAllUsers();
        void AddUserToProject(int idUser, int idProject);
        void DeleteUserFromProject(int idUser, int idProject);
        User[] ReadUsersInProject(int idProject);
        int GetIdUserInProject(int idUser, int idProject);
        Project GetProjectFromUserInProject(int idUserInProject);
        User GetUserFromUserInProject(int idUserInProject);

        void CreateClient(Client client);
        void UpdateClient(Client client);
        Client ReadClient(int idForSearch);
        Client[] ReadAllClients();
        void DeleteClient(int idClient);

        int CreateProject(Project project);
        void UpdateProject(Project project);
        Project ReadProject(int idForSearch);
        Project[] ReadAllProject();
        Project[] ReadAllProjectByState(ProjectState stateToSearch);
        Project[] ReadAllProjectByUser(int idUser);
        void DeleteProject(int idProject);
        decimal GetTotalSquare(int idProject);
        decimal GetAmountByWorksFromProject(int idProject);
        decimal GetAmountPaymentsByProject(int idProject);
        decimal GetAmountPlannedWorkByProject(int idProject);
        decimal GetAmountCompletedWorkByProject(int idProject);
        decimal GetAmountAcceptedWorkByProject(int idProject);
        decimal GetAmountRejectedWorkByProject(int idProject);
        decimal GetAmountCompletedWorkByProjectAndUser(int idProject, int idUser);
        decimal GetAmountAcceptedWorkByProjectAndUser(int idProject, int idUser);
        decimal GetAmountRejectedWorkByProjectAndUser(int idProject, int idUser);
        bool AllWorksByProjectAccepted(int idProject);

        void CreateTypeOfWork(TypeOfWork typeOfWork);
        TypeOfWork ReadTypeOfWork(int idForSearch);
        void UpdateTypeOfWork(TypeOfWork typeOfWork);
        void DeleteTypeOfWork(int idTypeOfWork);
        TypeOfWork[] ReadAllTypesOfWork();

        void CreateWorkInProject(WorkInProject workInProject);
        WorkInProject ReadWorkInProject(int idForSearch);
        void UpdateWorkInProject(WorkInProject workInProject);
        void DeleteWorkInProject(int idWorkInProject);
        WorkInProject[] ReadWorksByProject(int idProject);

        void CreatePayment(Payment payment);
        Payment ReadPayment(int idForSearch);
        void UpdatePayment(Payment payment);
        void DeletePayment(int idPayment);
        Payment[] ReadAllPayments();
        Payment[] ReadPaymentsByProject(int idProject);
        Payment[] ReadPaymentsByUser(int idProject);
        Payment[] ReadPaymentsByUserAndProject(int idProject, int idUser);
        decimal GetAmountPaymentsByUserAndProject(int idProject, int idUser);
        DateTime GetPaymenstByProjectMaxDate(int idProject);

        void CreateTypeOfElement(TypeOfElement typeOfElement);
        TypeOfElement ReadTypeOfElement(int idForSearch);
        TypeOfElement GetTypeOfElement(int idElement);
        void UpdateTypeOfElement(TypeOfElement typeOfElement);
        void DeleteTypeOfElement(int idTypeOfElement);
        TypeOfElement[] ReadAllTypesOfElement();
        void AddTypeOfElementInProject(int idTypeOfElement, int idProject);
        void DeleteTypeOfElementFromProject(int TypeOfElement, int idProject);
        TypeOfElement[] ReadTypesOfElementInProject(int idProject);
        bool IsTypeOfElementInElements(int idTypeOfElement);

        void CreateElement(Element element);
        Element ReadElement(int idForSearch);
        void UpdateElement(Element element);
        void UpdateVoidElementsSetIdTypeOfElement(Element[][] elements);
        void DeleteElement(int idElement);
        Element[] ReadAllElementsFromSectionOfBuilding(int idSectionOfBuilding);
        Element[] ReadAllElementsFromSectionOfBuildingByFloor(int idSectionOfBuilding, 
            int numberOfFloor);

        void CreateElementPicture(ElementPicture elementPicture);
        ElementPicture ReadElementPicture(int idForSearch);
        void UpdateElementPicture(ElementPicture elementPicture);
        void DeleteElementPicture(int idElement);
        ElementPicture[] ReadAllElementPictures();
        ElementPicture GetElementPictureByTypeOfElement(int idTypeOfElement);

        int CreateSectionOfBuilding(SectionOfBuilding sectionOfBuilding);
        void CreateSectionOfBuildingWithElements(SectionOfBuilding sectionOfBuilding);
        SectionOfBuilding ReadSectionOfBuilding(int idForSearch);
        void UpdateSectionOfBuilding(SectionOfBuilding sectionOfBuilding);
        void DeleteSectionOfBuilding(int idSectionOfBuilding);
        void DeleteSectionOfBuildingWithElements(int idSectionOfBuilding);
        SectionOfBuilding[] ReadAllSectionsOfBuilding();
        SectionOfBuilding[] ReadAllSectionsOfBuildingByProject(int idProject);
        decimal GetSquareOfSectionOfBuilding(int idSectionOfBuilding);
        decimal GetValueByWorkFromSectionOfBuilding(WorkInProject workInProject,
            int idSecionOfBuilding);
        decimal GetValueByStateWorkFromSectionOfBuilding(WorkInProject workInProject,
           int idSecionOfBuilding, WorkState state);
        decimal GetValueWorkByElement(WorkByElement workByElement);
        decimal GetAmountByWorksFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding);
        decimal GetAmountWorksByStateFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding,
            WorkState state);
        bool HasWorkBySectionOfBuilding(int idSectionOfBuilding);

        void CreateWorkByElement(WorkByElement workByElement);
        void CreateWorkByElements(List<WorkByElement> workByElements);
        WorkByElement GetWorkByElement(int idElement, int idWorkInProject);
        WorkByElement ReadWorkByElement(int idForSearch);
        void UpdateWorkByElement(WorkByElement workByElement);
        void DeleteWorkByElement(int idWork);
        void DeleteWorkByElements(List<WorkByElement> workByElements2Delete);
        void ChangeStateWorkByElementWithTransaction(int idWorkByElement, WorkState state,
            NpgsqlTransaction transaction);
        bool HasWorkByElement(int idWork, int IdElement);

        void CreateWorkLog(WorkLog workLog);
        void CreateWorkLogsComplete(List<WorkByElement> workByElements, int idUser, DateTime date);
        void CreateWorkLogsAccept(List<WorkByElement> workByElements, int idUser,
            DateTime dateOfAccept);
        void CreateWorkLogsReject(List<WorkByElement> workByElements, int idUser,
            DateTime dateOfReject, string comment);
        WorkLog ReadWorkLog(int idForSearch);
        void UpdateWorkLogTypeIsImmutable(WorkLog workLog);
        void DeleteWorkLog(WorkLog workLog);
        void DeleteWorkLogsComplete(List<WorkLog> completeWorkLogs);
        void DeleteWorkLogsAccept(List<WorkLog> acceptWorkLogs);
        void DeleteWorkLogsReject(List<WorkLog> rejectWorkLogs);
        bool HasWorkLogs(int idWorkByElement);
        bool CheckDateOfComplete(DateTime dateOfComplete, int idWorkByElement);
        bool CheckDateOfAccept(DateTime dateOfAccept, int idWorkByElement);
        bool CheckDateOfReject(DateTime dateOfReject, int idWorkByElement);
        WorkLog[] ReadWorkLogs(int idWorkByElement);
        WorkLog GetLastCompleteLog(int idWorkByElement);
        WorkLog GetAcceptLog(int idWorkByElement);
        int GetCountRejectWorkLogs(int idWorkByElement);
        WorkLog GetLastRejectLog(int idWorkByElement);
        DateTime GetWorkLogByProjectMaxDate(int idProject);
    }
}
