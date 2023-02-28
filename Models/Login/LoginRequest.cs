using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models.Login
{
    public class LoginRequest
    {
        public string CompanyDB { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public string ServiceLayerUrl { get; set; }

        public LoginRequest(string CompanyDB, string Password, string UserName, string Url)
        {
            this.CompanyDB = CompanyDB;
            this.Password = Password;
            this.UserName = UserName;
            this.ServiceLayerUrl = Url;
        }
    }
}
