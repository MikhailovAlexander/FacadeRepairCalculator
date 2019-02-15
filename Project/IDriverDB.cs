using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public interface IDriverDB
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        User ReadUser(string loginInput);
        User[] ReadAllUsers();
    }
}
