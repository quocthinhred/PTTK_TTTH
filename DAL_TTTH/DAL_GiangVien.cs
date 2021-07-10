using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_TTTH;
using System.Data.SqlClient;

namespace DAL_TTTH
{
    public class DAL_GiangVien
    {
        public static List<DTO_GiangVien> getTeachers()
        {
            List<DTO_GiangVien> Teachers = new List<DTO_GiangVien>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GIANGVIEN", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                string id = row["MaGV"].ToString();
                string name = row["HoTen"].ToString();
                string birth = row["NamSinh"].ToString();
                string phone = row["SDT"].ToString();
                DTO_GiangVien teacher = new DTO_GiangVien(id, name, birth, phone);
                Teachers.Add(teacher);
            }
            return Teachers;
        }

        public static void insertTeacher(DTO_GiangVien Teacher)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO GIANGVIEN VALUES ('" + Teacher.ID + "', '" + Teacher.Name + "', '" + Teacher.Birth + "', '" + Teacher.Phone + "')", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public static void deleteTeacher(DTO_GiangVien Teacher)
        {
            SqlDataAdapter da = new SqlDataAdapter("DELETE FROM GIANGVIEN WHERE MaGV = '" + Teacher.ID + "'", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public static void updateTeacher(DTO_GiangVien Teacher)
        {
            SqlDataAdapter da = new SqlDataAdapter("UPDATE GIANGVIEN SET HOTEN = '" + Teacher.Name + "', NAMSINH = '" + Teacher.Birth + "', SDT = '" + Teacher.Phone + "' WHERE MAGV = '" + Teacher.ID + "'", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
    }
}
