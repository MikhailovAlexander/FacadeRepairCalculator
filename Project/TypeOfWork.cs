using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{

    public class TypeOfWork:BaseWithName
    {
        public static readonly Dictionary<Dimension, string> DimensionDictionary =
            new Dictionary<Dimension, string>
            {
                { Dimension.Square, "Площадь" },
                { Dimension.Height, "Высота" },
                { Dimension.Length, "Ширина" },
                { Dimension.Piece, "Количество" }
            };

        private static readonly Regex measureUnitRegex = new Regex(@"^[А-я\d\., ""\)\(]{1,100}$");

        public const string nameTableInDB = "type_of_work";

        public string MeasureUnit { get; set; }
        public Dimension Dim { get; set; }

        public TypeOfWork() : base()
        {
            Name = "Не определено";
            MeasureUnit = "Не определено";
            Dim = Dimension.Piece;
        }

        public TypeOfWork(string name, string measureUnit, Dimension dim) : base(name)
        {
            MeasureUnit = measureUnit;
            Dim = dim;
        }

        public TypeOfWork(int id, string name, string measureUnit, Dimension dim) : base(id, name)
        {
            MeasureUnit = measureUnit;
            Dim = dim;
        }

        public string DimensionToString()
        {
            return DimensionDictionary[Dim];
        }

        public static bool MeasureUnitIsMatch(string measureUnit2Check)
        {
            return measureUnitRegex.IsMatch(measureUnit2Check);
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateTypeOfWork(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateTypeOfWork(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteTypeOfWork(id);
        }
    }
}
