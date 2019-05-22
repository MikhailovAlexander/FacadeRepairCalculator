using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Project
{
    public class TypeOfElement:BaseWithName
    {
        public const string nameTableInDB = "type_of_element";

        private decimal square;
        private decimal height;
        private decimal length;
        public int IdElementPicture { get; set; }
        public decimal Square
        {
            get { return square; }
            set
            {
                {
                    if (value < 0) throw new Exception("Площадь не может быть отрицательной");
                    else square = value;

                }
            }
        }
        public decimal Height
        {
            get { return height; }
            set
            {
                {
                    if (value < 0) throw new Exception("Высота не может быть отрицательной");
                    else height = value;

                }
            }
        }
        public decimal Length
        {
            get { return length; }
            set
            {
                {
                    if (value < 0) throw new Exception("Длина не может быть отрицательной");
                    else length = value;

                }
            }
        }

        public TypeOfElement() : base()
        {
            IdElementPicture = -1;
            Square = 0;
            Height = 0;
            Length = 0;
        }

        public TypeOfElement(string name, int idElementPicture, decimal square, decimal height, 
            decimal length) : base(name)
        {
            IdElementPicture = idElementPicture;
            Square = square;
            Height = height;
            Length = length;
        }

        public TypeOfElement(int id, string name, int idElementPicture, decimal square, 
            decimal height, decimal length) : base(id, name)
        {
            IdElementPicture = idElementPicture;
            Square = square;
            Height = height;
            Length = length;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateTypeOfElement(this);
        }

        public override void Update(IDriverDB driver)
        {
            if (IsInElements(driver)) throw new Exception(
                "Изменение невозможно. Элемент включен в проект.");
            driver.UpdateTypeOfElement(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteTypeOfElement(this.Id);
        }

        public Image GetPicture(IDriverDB driver)
        {
            return driver.ReadElementPicture(this.IdElementPicture).Picture;
        }

        private bool IsInElements(IDriverDB driver)
        {
            return driver.IsTypeOfElementInElements(id);
        }
    }
}
