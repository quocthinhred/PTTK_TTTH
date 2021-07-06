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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopCCMo", DBConnect.conn);
            DataTable dtAccount = new DataTable();
            da.Fill(dtAccount);
            foreach (DataRow row in dtAccount.Rows)
            {
                string id = row["ID"].ToString();
                string name = "Lop Chung chi";
                string id_Course = row["ID_Course"].ToString();
                string id_Teacher = row["ID_Teacher"].ToString();
                string schedule = row["Schedule"].ToString();
                DTO_LopCCMo lop = new DTO_LopCCMo(id, name, id_Course, id_Teacher, schedule);
                DSLopCCMo.Add(lop);
            }
            return DSLopCCMo;
        }
    }
}
