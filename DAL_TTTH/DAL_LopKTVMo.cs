using System;
using System.Data;
using System.Data.SqlClient;
using DTO_TTTH;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TTTH
{
    public class DAL_LopKTVMo
    {
        public static List<DTO_LopKTVMo> getDSLopKTVMo()
        {
            List<DTO_LopKTVMo> DSLopKTVMo = new List<DTO_LopKTVMo>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Mon M, LopKTVMo LKTVM WHERE M.MaMon = LKTVM.MaMon", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string id = row["MaMon"].ToString();
                string name = row["TenMon"].ToString();
                string id_Course = row["MaKhoa"].ToString();
                string id_Teacher = row["MaGV"].ToString();
                string schedule = row["LichHoc"].ToString();
                DTO_LopKTVMo lop = new DTO_LopKTVMo(id, name, id_Course, id_Teacher, schedule);
                DSLopKTVMo.Add(lop);
            }
            return DSLopKTVMo;
        }
    }
}
