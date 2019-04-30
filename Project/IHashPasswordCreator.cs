using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public interface IHashPasswordCreator
    {
        void EncodePasswordAndGenerteSalt(string passwordInput);
        string GetHashToString();
        string GetSaltToString();
        bool VeryfyHash(string password2Check, string correctHash, string saltString);
    }
}
