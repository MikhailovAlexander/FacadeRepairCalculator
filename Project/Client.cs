using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public class Client:BaseWithName
    {
        public string Address { get; set; }
        public string Inn { get; set; }

        private static Regex innRegex = new Regex(@"^\d{10}|\d{12}$");

        public const string nameTableInDB = "client";

        public Client():base()
        {
            Address = "Не определен";
            Inn = "Не определен";
        }

        public Client(string name, string address, string inn) : base(name)
        {
            Address = address;
            Inn = inn;
        }

        public Client(int id, string name, string address, string inn) : base(id, name)
        {
            Address = address;
            Inn = inn;
        }

        public override string ToString()
        {
            return $"Id[{Id}], {Name}, ИНН {Inn}";
        }

        public override void Create(IDriverDB driver)
        {
            driver.CreateClient(this);
        }

        public override void Update(IDriverDB driver)
        {
            driver.UpdateClient(this);
        }

        public override void Delete(IDriverDB driver)
        {
            driver.DeleteClient(id);
        }

        public static bool AddressIsMatch(string string2Check)
        {
            return NameIsMatch(string2Check);
        }

        public static bool InnIsMatch(string string2Check)
        {
            return innRegex.IsMatch(string2Check);
        }
    }
}
