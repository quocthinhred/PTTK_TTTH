using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;


namespace BUS_TTTH
{
    public class BUS_DangKyLopChungChi
    {
        public static string addStudent(string id_student, DTO_LopCCMo LCCM)
        {
            try
            {
                DAL_DangKyLopChungChi.addStudent(id_student, LCCM);
                return "Thêm thành công!";
            }
            catch(Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
