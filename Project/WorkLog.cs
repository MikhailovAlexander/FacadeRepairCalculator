using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class WorkLog:Base
    {
        public const string nameTableInDB = "work_log";

        public int IdWorkByElement { get; set; }
        public int IdUser { get; set; }
        public TypeOfLog TypeOfLog { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        private static Dictionary<TypeOfLog, string> TypeOfLogDictionary =
            new Dictionary<TypeOfLog, string>
            {
                { TypeOfLog.Complete, "Выполнение" },
                { TypeOfLog.Accept, "Принятие" },
                { TypeOfLog.Reject, "Отклонение" }
        };

        public WorkLog() : base()
        {
            IdWorkByElement = -1;
            IdUser = -1;
            TypeOfLog = TypeOfLog.Complete;
            Date = new DateTime(1970, 1, 1);
            Comment = "";
        }

        public WorkLog(int idWorkByElement, int idUser, TypeOfLog typeOfLog,
            DateTime date) : base()
        {
            IdWorkByElement = idWorkByElement;
            IdUser = idUser;
            TypeOfLog = typeOfLog;
            Date = date;
            Comment = "";
        }

        public WorkLog(int id, int idWorkByElement, int idUser, TypeOfLog typeOfLog,
           DateTime date) : base(id)
        {
            IdWorkByElement = idWorkByElement;
            IdUser = idUser;
            TypeOfLog = typeOfLog;
            Date = date;
            Comment = "";
        }

        public WorkLog(int idWorkByElement, int idUser, TypeOfLog typeOfLog,
           DateTime date, string comment) : base()
        {
            IdWorkByElement = idWorkByElement;
            IdUser = idUser;
            TypeOfLog = typeOfLog;
            Date = date;
            Comment = comment;
        }

        public WorkLog(int id, int idWorkByElement, int idUser, TypeOfLog typeOfLog,
           DateTime date, string comment) : base(id)
        {
            IdWorkByElement = idWorkByElement;
            IdUser = idUser;
            TypeOfLog = typeOfLog;
            Date = date;
            Comment = comment;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateWorkLog(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateWorkLog(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteWorkLog(id);
        }

        public string GetTypeString()
        {
            return TypeOfLogDictionary[TypeOfLog];
        }
    }
}
