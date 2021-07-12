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
        public static List<DTO_DangKyLopChuyenDe> getList()
        {
            List<DTO_DangKyLopChuyenDe> Lists = new List<DTO_DangKyLopChuyenDe>();
            Lists = DAL_DangKyLopChuyenDe.getRegisterTheme();
            return Lists;
        }
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

        public static string feePay(DTO_DangKyLopChuyenDe register)
        {
            try
            {
                DAL_DangKyLopChuyenDe.payFee(register.ID_Student, register.ID_Class, register.ID_Course);
                return "Cập nhật thành công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
