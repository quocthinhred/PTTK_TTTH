using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_TTTH;
using DTO_TTTH;

namespace BUS_TTTH
{
    public class BUS_DangKyLopChuyenDe
    {
        public static string addStudent(string id_student, DTO_LopCDMo LCDM)
        {
            try
            {
                DAL_DangKyLopChuyenDe.addStudent(id_student, LCDM);
                return "Thêm thành công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
