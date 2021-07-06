using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public DTO_Account()
        {
            Username = "";
            Password = "";
            Type = "";
        }

        public DTO_Account(string username, string password, string type)
        {
            Username = username;
            Password = password;
            Type = type;
        }
    }
}
