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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopCDMo", DBConnect.conn);
            DataTable dtAccount = new DataTable();
            da.Fill(dtAccount);
            foreach (DataRow row in dtAccount.Rows)
            {
                string id = row["ID"].ToString();
                string name = "Lop Chuyen de";
                string id_Course = row["ID_Course"].ToString();
                string id_Teacher = row["ID_Teacher"].ToString();
                string schedule = row["Schedule"].ToString();
                DTO_LopCDMo lop = new DTO_LopCDMo(id, name, id_Course, id_Teacher, schedule);
                DSLopCDMo.Add(lop);
            }
            return DSLopCDMo;
        }
    }
}
