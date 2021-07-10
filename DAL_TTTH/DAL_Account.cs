using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using System.Data.SqlClient;

namespace DAL_TTTH
{
    public class DAL_Account
    {
        public static List<DTO_Account> getAccounts()
        {
            List<DTO_Account> Accounts = new List<DTO_Account>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ACCOUNT", DBConnect.conn);
            DataTable dtAccount = new DataTable();
            da.Fill(dtAccount);
            foreach (DataRow row in dtAccount.Rows)
            {
                string username = row["username"].ToString();
                username = username.ToUpper();
                string password = row["password"].ToString();
                string type = row["type"].ToString();
                DTO_Account account = new DTO_Account(username, password, type);
                Accounts.Add(account);
            }
            return Accounts;
        }
    }
}
