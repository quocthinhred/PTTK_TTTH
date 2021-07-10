using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_Account
    {
        public static DTO_Account checkLogin(string username, string password)
        {
            username = username.ToUpper();
            List<DTO_Account> Accounts = new List<DTO_Account>();
            Accounts = DAL_Account.getAccounts();
            if (Accounts.Count > 0)
            {
                for (int i = 0; i < Accounts.Count; i++)
                {
                    if (Accounts[i].Username == username)
                    {
                        if (Accounts[i].Password == password)
                        {
                            DTO_Account user = new DTO_Account(username, password, Accounts[i].Type);
                            return user;
                        }
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
