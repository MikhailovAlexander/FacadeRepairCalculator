using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public abstract class BaseWithName:Base
    {
        protected static readonly Regex nameRegex = new Regex(@"^[А-я\d\., ""\)\(]{3,100}$");

        public string Name { get; set; }

        public BaseWithName(): base()
        {
            Name = "Не установлено";
        }

        public BaseWithName(string name) : base()
        {
            Name = name;
        }

        public BaseWithName(int id, string name): base(id)
        {
            Name = name;
        }

        public static bool NameIsMatch(string string2Check)
        {
            return nameRegex.IsMatch(string2Check);
        }
    }
}
