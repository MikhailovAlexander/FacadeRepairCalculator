using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class WorkByElement : Base
    {
        public const string nameTableInDB = "work_by_element";

        private decimal multiplicity;
        public int IdElement { get; set; }
        public int IdWorkInProject { get; set; }
        public WorkState State { get; set; }
        public decimal Multiplicity
        {
            get { return multiplicity; }
            set
            {
                if (value <= 0) throw new Exception(
                    "Кратность не может быть нулевой или отрицательной");
                else multiplicity = value;
            }
        }

        private static Dictionary<WorkState, Color> WorkStateColorDictionary =
            new Dictionary<WorkState, Color>
            {
                { WorkState.Planned, Color.DimGray },
                { WorkState.Completed, Color.Yellow },
                { WorkState.Accepted, Color.Green },
                { WorkState.Rejected, Color.Red }
        };

        public WorkByElement():base()
        {
            IdElement = -1;
            IdWorkInProject = -1;
            State = WorkState.Planned;
            multiplicity = 0;
        }

        public WorkByElement(int idElement, int idWorkInProject, WorkState state, 
            decimal multiplicity) : base()
        {
            IdElement = idElement;
            IdWorkInProject = idWorkInProject;
            State = state;
            Multiplicity = multiplicity;
        }

        public WorkByElement(int idElement, int idWorkInProject, decimal multiplicity) : base()
        {
            IdElement = idElement;
            IdWorkInProject = idWorkInProject;
            State = WorkState.Planned;
            Multiplicity = multiplicity;
        }

        public WorkByElement(int idElement, int idWorkInProject) : base()
        {
            IdElement = idElement;
            IdWorkInProject = idWorkInProject;
            State = WorkState.Planned;
            Multiplicity = 1;
        }

        public WorkByElement(int id, int idElement, int idWorkInProject, WorkState state,
            decimal multiplicity) : base(id)
        {
            IdElement = idElement;
            IdWorkInProject = idWorkInProject;
            State = state;
            Multiplicity = multiplicity;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateWorkByElement(this);
        }

        public static void CreateWorkByElements(List<WorkByElement> workByElements, IDriverDB driver)
        {
            driver.CreateWorkByElements(workByElements);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateWorkByElement(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteWorkByElement(id);
        }

        public static void DeleteWorkByElements(List<WorkByElement> workByElements2Delete, 
            IDriverDB driver)
        {
            driver.DeleteWorkByElements(workByElements2Delete);
        }

        public Color GetColorByState()
        {
            return WorkStateColorDictionary[State];
        }

        public decimal GetValue(IDriverDB driver)
        {
            return driver.GetValueWorkByElement(this);
        }

        public bool CompleteCheck(DateTime dateOfComplete, IDriverDB driver)
        {
            if(State != WorkState.Planned && State != WorkState.Rejected) return false;
            return driver.CheckDateOfComplete(dateOfComplete, id);
        }

        public bool AcceptCheck(DateTime dateOfAccept, IDriverDB driver)
        {
            if (State != WorkState.Completed) return false;
            return driver.CheckDateOfAccept(dateOfAccept, id);
        }

        public bool RejectCheck(DateTime dateOfReject, IDriverDB driver)
        {
            if (State != WorkState.Completed) return false;
            return driver.CheckDateOfReject(dateOfReject, id);
        }

        public WorkLog GetCompleteLog2Delete(int idActualUser, IDriverDB driver)
        {
            if (State != WorkState.Completed) return new WorkLog();
            WorkLog lastCompleteLog = driver.GetLastCompleteLog(id);
            if (idActualUser == lastCompleteLog.IdUser) return lastCompleteLog;
            return new WorkLog();
        }

        public WorkLog GetAcceptLog2Delete(int idActualUser, IDriverDB driver)
        {
            if (State != WorkState.Accepted) return new WorkLog();
            WorkLog acceptLog2Delete = driver.GetAcceptLog(id);
            if (idActualUser == acceptLog2Delete.IdUser) return acceptLog2Delete;
            return new WorkLog();
        }

        public WorkLog GetRejectLog2Delete(int idActualUser, IDriverDB driver)
        {
            if (State != WorkState.Rejected) return new WorkLog();
            WorkLog rejectLog2Delete = driver.GetLastRejectLog(id);
            if (idActualUser == rejectLog2Delete.IdUser) return rejectLog2Delete;
            return new WorkLog();
        }

        public WorkState GetPalannedOrCompleteState(IDriverDB driver)
        {
            if (driver.GetCountRejectWorkLogs(id) > 0) return WorkState.Rejected;
            return WorkState.Planned;
        }

        public static WorkState GetPalannedOrCompleteState(int idWorkByElement, IDriverDB driver)
        {
            if (driver.GetCountRejectWorkLogs(idWorkByElement) > 0) return WorkState.Rejected;
            return WorkState.Planned;
        }

        public static void CreateWorkLogsComplete(List<WorkByElement> workByElements, int idUser,
            DateTime date, IDriverDB driver)
        {
            driver.CreateWorkLogsComplete(workByElements, idUser, date);
        }

        public static void DeleteWorkLogsComplete(List<WorkLog> completeWorkLogs, IDriverDB driver)
        {
            driver.DeleteWorkLogsComplete(completeWorkLogs);
        }

        public static void CreateWorkLogsAccept(List<WorkByElement> workByElements, int idUser,
            DateTime dateOfAccept, IDriverDB driver)
        {
            driver.CreateWorkLogsAccept(workByElements, idUser, dateOfAccept);
        }

        public static void DeleteWorkLogsAccept(List<WorkLog> acceptWorkLogs, IDriverDB driver)
        {
            driver.DeleteWorkLogsAccept(acceptWorkLogs);
        }

        public static void CreateWorkLogsReject(List<WorkByElement> workByElements, int idUser,
            DateTime dateOfReject, string comment, IDriverDB driver)
        {
            driver.CreateWorkLogsReject(workByElements, idUser, dateOfReject, comment);
        }

        public static void DeleteWorkLogsReject(List<WorkLog> rejectWorkLogs, IDriverDB driver)
        {
            driver.DeleteWorkLogsReject(rejectWorkLogs);
        }
    }
}
