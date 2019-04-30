using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public class WorkInProject:Base
    {

        public const string nameTableInDB = "work_in_project";

        private  double price;
        private double multiplicity;
        public int IdProject { get; set; }
        public int IdTypeOfWork { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0) throw new Exception("Цена не может быть отрицательной");
                else price = value;
            }
        }
        public double Multiplicity
        {
            get { return multiplicity; }
            set
            {
                if (value <= 0) throw new Exception(
                    "Кратность не может быть нулевой или отрицательной");
                else multiplicity = value;
            }
        }

        public WorkInProject() : base()
        {
            IdProject = -1;
            IdTypeOfWork = -1;
            Price = 0;
            Multiplicity = 1;
        }

        public WorkInProject(int idProject, int idTypeOfWork, double price) : base()
        {
            IdProject = idProject;
            IdTypeOfWork = idTypeOfWork;
            Price = price;
            Multiplicity = 1;
        }

        public WorkInProject(int id, int idProject, int idTypeOfWork, double price) : base(id)
        {
            IdProject = idProject;
            IdTypeOfWork = idTypeOfWork;
            Price = price;
            Multiplicity = 1;
        }

        public WorkInProject(int idProject, int idTypeOfWork, double price, double multiplicity) : base()
        {
            IdProject = idProject;
            IdTypeOfWork = idTypeOfWork;
            Price = price;
            Multiplicity = multiplicity;
        }

        public WorkInProject(int id, int idProject, int idTypeOfWork, double price, double multiplicity) : base(id)
        {
            IdProject = idProject;
            IdTypeOfWork = idTypeOfWork;
            Price = price;
            Multiplicity = multiplicity;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateWorkInProject(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateWorkInProject(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteWorkInProject(id);
        }

    }
}
