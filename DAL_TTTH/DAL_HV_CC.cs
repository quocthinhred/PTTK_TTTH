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
    public class DAL_HV_CC
    {
        public static List<DTO_HV_CC> getAchievements()
        {
            List<DTO_HV_CC> Achievements = new List<DTO_HV_CC>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HocVien_TotNghiep", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string id_Student = row["MaHV"].ToString();
                string id_Certi = row["MaCC"].ToString();
                string result = row["KetQua"].ToString();
                DTO_HV_CC achievement = new DTO_HV_CC(id_Student, id_Certi, result);
                Achievements.Add(achievement);
            }
            return Achievements;
        }
    }
}
