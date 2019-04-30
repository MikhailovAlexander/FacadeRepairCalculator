using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class CompletedWork:Base
    {
        public const string nameTableInDB = "completed_work";

        public int IdWorkByElement { get; set; }
        public int IdWorker { get; set; }
        public DateTime DateOfComplete { get; set; }
        public bool Reject { get; set; }

        public CompletedWork():base()
        {
            IdWorkByElement = -1;
            IdWorker = -1;
            DateOfComplete = new DateTime(1970, 1, 1);
            Reject = false;
        }

        public CompletedWork(
            int idWorkByElement, int idWorker, DateTime date, bool reject) : base()
        {
            IdWorkByElement = idWorkByElement;
            IdWorker = idWorker;
            DateOfComplete = date;
            Reject = reject;
        }

        public CompletedWork(
            int id, int idWorkByElement, int idWorker, DateTime date, bool reject) : base(id)
        {
            IdWorkByElement = idWorkByElement;
            IdWorker = idWorker;
            DateOfComplete = date;
            Reject = reject;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateCompletedWork(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateCompletedWork(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteCompletedWork(id);
        }
    }
}
