using System;
using System.Collections.Generic;
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

        public static void DeleteWorkByElements(List<WorkByElement> workByElements2Delete, IDriverDB driver)
        {
            driver.DeleteWorkByElements(workByElements2Delete);
        }

        public void Complete(int idWorker, DateTime dateOfComplete, IDriverDB driver)
        {
            if (State == WorkState.Completed) throw new Exception("Работа уже выполнена");
            if (State == WorkState.Accepted) throw new Exception("Работа уже принята");
            var completedWork = new CompletedWork(id, idWorker, dateOfComplete, false);
            completedWork.Create(driver);
            State = WorkState.Completed;

            
        }

        public void Accept(IDriverDB driver)
        {

        }

        public void Reject(IDriverDB driver)
        {

        }
    }
}
