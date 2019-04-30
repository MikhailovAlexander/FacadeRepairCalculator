using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public class Element:Base
    {
        public const string nameTableInDB = "element";

        public int IdSectionOfBuilding { get; set; }
        public int IdTypeOfElement { get; set; }
        public int OrdinalNubmerByHeight { get; set; }
        public int OrdinalNubmerByWidth { get; set; }

        public Element() :base()
        {
            IdSectionOfBuilding = -1;
            IdTypeOfElement = -1;
            OrdinalNubmerByHeight = -1;
            OrdinalNubmerByWidth = -1;
        }

        public Element(int idSectionOfBuilding, int ordinalNubmerByHeight,
            int ordinalNubmerByWidth) : base()
        {
            IdTypeOfElement = -1;
            IdSectionOfBuilding = idSectionOfBuilding;
            OrdinalNubmerByHeight = ordinalNubmerByHeight;
            OrdinalNubmerByWidth = ordinalNubmerByWidth;
        }

        public Element(int idSectionOfBuilding, int idTypeOfElement, int ordinalNubmerByHeight, 
            int ordinalNubmerByWidth) : base()
        {
            IdSectionOfBuilding = idSectionOfBuilding;
            IdTypeOfElement = idTypeOfElement;
            OrdinalNubmerByHeight = ordinalNubmerByHeight;
            OrdinalNubmerByWidth = ordinalNubmerByWidth;
        }

        public Element(int id, int idSectionOfBuilding, int idTypeOfElement, int ordinalNubmerByHeight,
            int ordinalNubmerByWidth) : base(id)
        {
            IdSectionOfBuilding = idSectionOfBuilding;
            IdTypeOfElement = idTypeOfElement;
            OrdinalNubmerByHeight = ordinalNubmerByHeight;
            OrdinalNubmerByWidth = ordinalNubmerByWidth;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateElement(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateElement(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteElement(this.Id);
        }

        public TypeOfElement GetTypeOfElement(IDriverDB driver)
        {
            return driver.ReadTypeOfElement(this.IdTypeOfElement);
        }

        public SectionOfBuilding GetSectionOfBuilding(IDriverDB driver)
        {
            return driver.ReadSectionOfBuilding(this.IdSectionOfBuilding);
        }

        public bool IsChecked()
        {
            //TODO
            return true;
        }

        public bool HasWorkByElement(int idWorkInProject, IDriverDB driver)
        {
            return driver.HasWorkByElement(idWorkInProject, id);
        }
    }
}
