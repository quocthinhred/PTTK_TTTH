using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using System.Data;
using System.Data.SqlClient;

namespace DAL_TTTH
{
    public class DAL_Khoa
    {
        public List<DTO_Khoa> getCourses()
        {
            List<DTO_Khoa> Courses = new List<DTO_Khoa>();
            SqlDataAdapter da = new SqlDataAdapter("", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                string id = row["MaKhoa"].ToString();
                string startDate = row["NgayBD"].ToString();
                string endDate = row["NgayKT"].ToString();
                DTO_Khoa course = new DTO_Khoa();
                Courses.Add(course);
            }
            return Courses;
        }
    }
}
