using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class AcceptedWork:Base
    {
        public const string nameTableInDB = "accepted_work";

        public int IdWorkByElement { get; set; }
        public int IdManager { get; set; }
        public DateTime DateOfAccept { get; set; }

        public AcceptedWork() : base()
        {
            IdWorkByElement = -1;
            IdManager = -1;
            DateOfAccept = new DateTime(1970, 1, 1);
        }

        public AcceptedWork(int idWorkByElement, int idManager, DateTime date) : base()
        {
            IdWorkByElement = idWorkByElement;
            IdManager = idManager;
            DateOfAccept = date;
        }

        public AcceptedWork(int id, int idWorkByElement, int idManager, DateTime date) : base(id)
        {
            IdWorkByElement = idWorkByElement;
            IdManager = idManager;
            DateOfAccept = date;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateAcceptedWork(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateAcceptedWork(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteAcceptedWork(id);
        }
    }
}
