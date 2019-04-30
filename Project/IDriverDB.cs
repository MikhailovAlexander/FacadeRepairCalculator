﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Project
{
    public interface IDriverDB
    {
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
        void DeleteProject(int idProject);
        decimal GetTotalSquare(int idProject);
        decimal GetAmountByWorksFromProject(int idProject);
        decimal GetAmountPaymentsByProject(int idProject);

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

        void CreateTypeOfElement(TypeOfElement typeOfElement);
        TypeOfElement ReadTypeOfElement(int idForSearch);
        void UpdateTypeOfElement(TypeOfElement typeOfElement);
        void DeleteTypeOfElement(int idTypeOfElement);
        TypeOfElement[] ReadAllTypesOfElement();
        void AddTypeOfElementInProject(int idTypeOfElement, int idProject);
        void DeleteTypeOfElementFromProject(int TypeOfElement, int idProject);
        TypeOfElement[] ReadTypesOfElementInProject(int idProject);

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
        decimal GetAmountByWorksFromSectionOfBuilding(SectionOfBuilding sectionOfBuilding);

        void CreateWorkByElement(WorkByElement workByElement);
        void CreateWorkByElements(List<WorkByElement> workByElements);
        WorkByElement ReadWorkByElement(int idForSearch);
        void UpdateWorkByElement(WorkByElement workByElement);
        void DeleteWorkByElement(int idWork);
        void DeleteWorkByElements(List<WorkByElement> workByElements2Delete);
        void ChangeStateWorkByElementWithTransaction(int idWorkByElement, WorkState state,
            NpgsqlTransaction transaction);
        bool HasWorkByElement(int idWork, int IdElement);

        void CreateCompletedWork(CompletedWork completedWork);
        CompletedWork ReadCompletedWork(int idForSearch);
        void UpdateCompletedWork(CompletedWork completedWork);
        void DeleteCompletedWork(int idCompletedWork);

        void CreateAcceptedWork(AcceptedWork acceptedWork);
        AcceptedWork ReadAcceptedWork(int idForSearch);
        void UpdateAcceptedWork(AcceptedWork acceptedWork);
        void DeleteAcceptedWork(int idAcceptedWork);

        void CreateRejectedWork(RejectedWork rejectedWork);
        RejectedWork ReadRejectedWork(int idForSearch);
        void UpdateRejectedWork(RejectedWork rejectedWork);
        void DeleteRejectedWork(int idRejectedWork);
    }
}
