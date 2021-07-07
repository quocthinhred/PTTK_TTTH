using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using System.Data.SqlClient;
using System.Data;

namespace DAL_TTTH
{
    public class DAL_HocVien
    {
        public List<DTO_HocVien> getStudents()
        {
            List<DTO_HocVien> Students = new List<DTO_HocVien>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HocVien", DBConnect.conn);
            DataTable dtAccount = new DataTable();
            da.Fill(dtAccount);
            foreach (DataRow row in dtAccount.Rows)
            {
                string id = row["MaHV"].ToString();
                string name = row["HoTen"].ToString();
                string birth = row["NamSinh"].ToString();
                string phone = row["SDT"].ToString();
                DTO_HocVien student = new DTO_HocVien(id, name, birth, phone);
                Students.Add(student);
            }
            return Students;
        }
    }
}
