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
        public static List<DTO_Khoa> getCourses()
        {
            List<DTO_Khoa> Courses = new List<DTO_Khoa>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khoa", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                string id = row["MaKhoa"].ToString();
                string startDate = row["NgayBD"].ToString();
                startDate.Substring(0, startDate.IndexOf(" "));
                string endDate = row["NgayKT"].ToString();
                startDate = startDate.Substring(0, startDate.IndexOf(" "));
                endDate = endDate.Substring(0, endDate.IndexOf(" "));
                DTO_Khoa course = new DTO_Khoa(id, startDate, endDate);
                Courses.Add(course);
            }
            return Courses;
        }

        public static List<DTO_Khoa> addCourse(DTO_Khoa newCourse)
        {
            List<DTO_Khoa> Courses = new List<DTO_Khoa>();
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO KHOA VALUES('" + newCourse.ID + "', '" + newCourse.StartDate + "', '" + newCourse.EndDate + "')", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM KHOA", DBConnect.conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            foreach(DataRow row in dt2.Rows)
            {
                string id = row["MaKhoa"].ToString();
                string startDate = row["NgayBD"].ToString();
                startDate = startDate.Substring(0, startDate.IndexOf(" "));
                string endDate = row["NgayKT"].ToString();
                endDate = endDate.Substring(0, endDate.IndexOf(" "));
                DTO_Khoa course = new DTO_Khoa(id, startDate, endDate);
                Courses.Add(course);
            }
            return Courses;
        }
        
    }
}
