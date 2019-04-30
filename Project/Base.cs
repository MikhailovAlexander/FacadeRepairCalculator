using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public abstract class Base
    {
        protected static readonly Regex intRegex = new Regex(@"^\d{1,9}$");
        private static readonly Regex decimalRegex = new Regex(@"^\d{1,6}(,\d{1,2})?$");


        protected int id;

        public int Id { get { return id; } }

        public Base()
        {
            id = -1;
        }

        public Base (int id)
        {
            this.id = id;
        }

        public static bool IntIsMatch(string string2check)
        {
            return intRegex.IsMatch(string2check);
        }

        public static bool DecimalIsMatch(string string2check)
        {
            return decimalRegex.IsMatch(string2check);
        }

        public abstract void Create(IDriverDB driver);
        public abstract void Update(IDriverDB driver);
        public abstract void Delete(IDriverDB driver);
    }
}
