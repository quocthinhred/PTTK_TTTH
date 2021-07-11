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
    public class DAL_NHPMo
    {
        public static List<DTO_NHPMo> getListNHPM()
        {
            List<DTO_NHPMo> L_NHPM = new List<DTO_NHPMo>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhomHocPhanMo NHPM,NhomHocPhan NHP where NHP.MaNHP = NHPM.MaNHP", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                string id = row["MaNHP"].ToString();
                string id_Course = row["MaKhoa"].ToString();
                string name = row["TenNHP"].ToString();
                string isFull = row["isFull"].ToString();
                DTO_NHPMo NHPM = new DTO_NHPMo(id, name, id_Course, isFull);    
                L_NHPM.Add(NHPM);
            }
            return L_NHPM;
        }
    }
}
