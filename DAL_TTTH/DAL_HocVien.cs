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
        public static List<DTO_HocVien> getStudents()
        {
            List<DTO_HocVien> Students = new List<DTO_HocVien>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HocVien", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
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
