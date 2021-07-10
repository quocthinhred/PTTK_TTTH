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

        public static void insertStudent(DTO_HocVien student)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO HOCVIEN VALUES ('" + student.ID + "', '" + student.Name + "', '" + student.Birth + "', '" + student.Phone + "')", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public static void deleteStudent(DTO_HocVien student)
        {
            SqlDataAdapter da = new SqlDataAdapter("DELETE FROM HOCVIEN WHERE MaHV = '" + student.ID + "'", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public static void updateStudent(DTO_HocVien student)
        {
            SqlDataAdapter da = new SqlDataAdapter("UPDATE HOCVIEN SET HOTEN = '" + student.Name + "', NAMSINH = '" + student.Birth + "', SDT = '" + student.Phone + "' WHERE MAHV = '" + student.ID + "'", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

    }
}
