using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public class SectionOfBuilding:BaseWithName
    {
        public const string nameTableInDB = "section_of_building";

        public int IdProject { get; set; }
        private int quantityByHeight;
        private int quantityByWidth;
        public int QuantityByHeight
        {
            get { return quantityByHeight; }
            set
            {
                if (value < 0)
                    throw new Exception("Количество не может быть отрицательным");
                else quantityByHeight = value;
            }
        }
        public int QuantityByWidth
        {
            get { return quantityByWidth; }
            set
            {
                if (value < 0)
                    throw new Exception("Количество не может быть отрицательным");
                else quantityByWidth = value;
            }
        }

        public SectionOfBuilding(): base()
        {
            IdProject = -1;
            QuantityByHeight = 0;
            QuantityByWidth = 0;
        }

        public SectionOfBuilding(string name, int idProject, int quantityByHeigth, 
            int quantityByWidth) : base(name)
        {
            IdProject = idProject;
            QuantityByHeight = quantityByHeigth;
            QuantityByWidth = quantityByWidth;
        }

        public SectionOfBuilding(int id, string name, int idProject, int quantityByHeigth,
            int quantityByWidth) : base(id, name)
        {
            IdProject = idProject;
            QuantityByHeight = quantityByHeigth;
            QuantityByWidth = quantityByWidth;
        }

        public override void Create(IDriverDB driver)
        {
            id = driver.CreateSectionOfBuilding(this);
        }

        public void CreateWithElements(IDriverDB driver)
        {
            driver.CreateSectionOfBuildingWithElements(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateSectionOfBuilding(this);
        }

        public void UpdateAllElementsSetTypeOfElement(Element[][] elements, IDriverDB driver)
        {
            if (!IsChecked(elements))
                throw new Exception("Набор элементов не соответствует модели");
            driver.UpdateVoidElementsSetIdTypeOfElement(elements);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteSectionOfBuilding(this.Id);
        }

        public void DeleteWithElements(IDriverDB driver)
        {
            driver.DeleteSectionOfBuildingWithElements(id);
        }

        public Project GetProject(IDriverDB driver)
        {
            return driver.ReadProject(this.IdProject);
        }

        public Element[] GetElements(IDriverDB driver)
        {
            return driver.ReadAllElementsFromSectionOfBuilding(id);
        }

        public Element[] GetElementsByFloor(int numberOfFloor, IDriverDB driver)
        {
            if (numberOfFloor > quantityByHeight)
                throw new Exception("Запрошенный этаж превышает этажность здания");
            else if (numberOfFloor < 0)
                throw new Exception("Номер этажа не может быть отрицательным");
            int idSec = this.id;
            return driver.ReadAllElementsFromSectionOfBuildingByFloor(id, numberOfFloor);
        }

        public Element[][] GetFloors(IDriverDB driver)
        {
            Element[][] floors = new Element[quantityByHeight][];
            for(int i = 0; i < quantityByHeight; i++)
            {
                floors[i] = GetElementsByFloor(i, driver);
            }
            return floors;
        }

     
        public bool HasElements(IDriverDB driver)
        {
            if (GetElements(driver).Length == 0) return false;
            return true;
        }

        public bool HasWork(IDriverDB driver)
        {
            return driver.HasWorkBySectionOfBuilding(id);
        }

        public bool IsChecked(Element[][] elements)
        {
            if (elements.GetLength(0) != quantityByHeight) return false;
            foreach (Element[] elementsByFloor in elements)
            {
                if (elementsByFloor.Length != quantityByWidth) return false;
                foreach (Element element in elementsByFloor)
                {
                    if (element.IdSectionOfBuilding != id) return false;
                }
            }
            return true;
        }

        public decimal GetSquare(IDriverDB driver)
        {
            return driver.GetSquareOfSectionOfBuilding(id);
        }

        public decimal GetValueByWork(WorkInProject workInProject, IDriverDB driver)
        {
            return driver.GetValueByWorkFromSectionOfBuilding(workInProject, id);
        }

        public decimal GetValueByCompletedWork(WorkInProject workInProject, IDriverDB driver)
        {
            return driver.GetValueByStateWorkFromSectionOfBuilding(workInProject, id, 
                WorkState.Completed);
        }

        public decimal GetValueByAcceptedWork(WorkInProject workInProject, IDriverDB driver)
        {
            return driver.GetValueByStateWorkFromSectionOfBuilding(workInProject, id,
                WorkState.Accepted);
        }

        public decimal GetValueByRejectedWork(WorkInProject workInProject, IDriverDB driver)
        {
            return driver.GetValueByStateWorkFromSectionOfBuilding(workInProject, id,
                WorkState.Rejected);
        }

        public decimal GetAmountByWorks(IDriverDB driver)
        {
            return driver.GetAmountByWorksFromSectionOfBuilding(this);
        }

        public decimal GetAmountByCompletedWork(IDriverDB driver)
        {
            return driver.GetAmountWorksByStateFromSectionOfBuilding(this, WorkState.Completed);
        }

        public decimal GetAmountByAcceptedWork(IDriverDB driver)
        {
            return driver.GetAmountWorksByStateFromSectionOfBuilding(this, WorkState.Accepted);
        }

        public decimal GetAmountByRejectedWork(IDriverDB driver)
        {
            return driver.GetAmountWorksByStateFromSectionOfBuilding(this, WorkState.Rejected);
        }
    }
}
