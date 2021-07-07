using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
namespace DAL_TTTH
{
    public class DAL_LopCDMo
    {
        public static List<DTO_LopCDMo> getDSLopCDMo()
        {
            List<DTO_LopCDMo> DSLopCDMo = new List<DTO_LopCDMo>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopChuyenDe LCD, LopChuyenDeMo LCDM WHERE LCD.MaLCD = LCDM.MaLCD", DBConnect.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string id = row["MaLCD"].ToString();
                string name = row["TenCD"].ToString();
                string id_Course = row["MaKhoa"].ToString();
                string id_Teacher = row["MaGV"].ToString();
                string schedule = row["LichHoc"].ToString();
                DTO_LopCDMo lop = new DTO_LopCDMo(id, name, id_Course, id_Teacher, schedule);
                DSLopCDMo.Add(lop);
            }
            return DSLopCDMo;
        }
    }
}
