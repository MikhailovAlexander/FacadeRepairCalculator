using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class RejectedWork:Base
    {
        public const string nameTableInDB = "rejected_work";

        public int IdWorkByElement { get; set; }
        public int IdManager { get; set; }
        public DateTime DateOfReject { get; set; }
        public string Comment { get; set; }
        public bool Rectify { get; set; }

        public RejectedWork() : base()
        {
            IdWorkByElement = -1;
            IdManager = -1;
            DateOfReject = new DateTime(1970, 1, 1);
            Comment = "не определено";
            Rectify = false;
        }

        public RejectedWork( int idWorkByElement, int idManager, DateTime date, string comment, 
            bool rectify) : base()
        {
            IdWorkByElement = idWorkByElement;
            IdManager = idManager;
            DateOfReject = date;
            Comment = comment;
            Rectify = rectify;
        }

        public RejectedWork( int id, int idWorkByElement, int idManager, DateTime date, 
            string comment, bool rectify) : base(id)
        {
            IdWorkByElement = idWorkByElement;
            IdManager = idManager;
            DateOfReject = date;
            Comment = comment;
            Rectify = rectify;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateRejectedWork(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateRejectedWork(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteRejectedWork(id);
        }
    }
}
