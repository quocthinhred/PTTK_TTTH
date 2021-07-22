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
    public class DAL_HV_TN
    {
        public static List<DTO_HV_TN> getAchievements()
        {
            List<DTO_HV_TN> Achievements = new List<DTO_HV_TN>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HocVien_TotNghiep", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string id_Student = row["MaHV"].ToString();
                string id_Course = row["MaKhoa"].ToString();
                string point = row["Diem"].ToString();
                string fee = row["PhiDuThi"].ToString();
                string examDate = row["NgayThi"].ToString();
                examDate = examDate.Substring(0, examDate.IndexOf(" "));
                string id_Teacher = row["MaGV"].ToString();
                DTO_HV_TN achievement = new DTO_HV_TN(id_Student, id_Course, point, fee, examDate, id_Teacher);
                Achievements.Add(achievement);
            }
            return Achievements;
        }

        public static void insertHV_TN(DTO_HV_TN student)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO HocVien_TotNghiep values ('"+student.ID_Student+ "','" + student.ID_Course + "',null,100000,'" + student.ExamDate + "',null)", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

    }
}
