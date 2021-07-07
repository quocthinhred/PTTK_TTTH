using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using System.Data.SqlClient;

namespace DAL_TTTH
{
    public class DAL_LopCCMo
    {
        public static List<DTO_LopCCMo> getDSLopCCMo()
        {
            List<DTO_LopCCMo> DSLopCCMo = new List<DTO_LopCCMo>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopChungChi LCC, LopChungChiMo LCCM WHERE LCC.MaLCC = LCCM.MaLCC", DBConnect.conn);
            DataTable dtAccount = new DataTable();
            da.Fill(dtAccount);
            foreach (DataRow row in dtAccount.Rows)
            {
                string id = row["MaLCC"].ToString();
                string name = row["TenLCC"].ToString() ;
                string id_Course = row["MaKhoa"].ToString();
                string id_Teacher = row["MaGV"].ToString();
                string schedule = row["LichHoc"].ToString();
                DTO_LopCCMo lop = new DTO_LopCCMo(id, name, id_Course, id_Teacher, schedule);
                DSLopCCMo.Add(lop);
            }
            return DSLopCCMo;
        }
    }
}
