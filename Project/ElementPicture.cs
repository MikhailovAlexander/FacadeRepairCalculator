using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Project
{
    public class ElementPicture:BaseWithName
    {
        public const string nameTableInDB = "element_picture";

        public Image Picture { get; set; }

        public ElementPicture() : base()
        {
            Picture = null;
        }

        public ElementPicture(Image image) : base()
        {
            Picture = image;
        }

        public ElementPicture(string name, Image image) : base(name)
        {
            Picture = image;
        }

        public ElementPicture(string name, string filename) : base(name)
        {
            Picture = Image.FromFile(filename);
        }

        public ElementPicture(int id, string name, Image image) : base(id, name)
        {
            Picture = image;
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateElementPicture(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateElementPicture(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteElementPicture(this.Id);
        }

        public Image ResizePicture(int width, int height)
        {
            return new Bitmap(Picture, new Size(width, height));
        }
    }

}
