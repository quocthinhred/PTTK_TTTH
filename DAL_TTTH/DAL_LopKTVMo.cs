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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopKTVMo", DBConnect.conn);
            DataTable dtAccount = new DataTable();
            da.Fill(dtAccount);
            foreach (DataRow row in dtAccount.Rows)
            {
                string id = row["ID"].ToString();
                string name = "Lop KTV";
                string id_Course = row["ID_Course"].ToString();
                string id_Teacher = row["ID_Teacher"].ToString();
                string id_Subject = row["ID_Subject"].ToString();
                string schedule = row["Schedule"].ToString();
                DTO_LopKTVMo lop = new DTO_LopKTVMo(id, name, id_Course, id_Subject, id_Teacher, schedule);
                DSLopKTVMo.Add(lop);
            }
            return DSLopKTVMo;
        }
    }
}
