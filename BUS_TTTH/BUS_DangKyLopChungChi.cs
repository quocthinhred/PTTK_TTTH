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
        public static List<DTO_DangKyLopChungChi> getList()
        {
            List<DTO_DangKyLopChungChi> Lists = new List<DTO_DangKyLopChungChi>();
            Lists = DAL_DangKyLopChungChi.getRegisterCerti();
            return Lists;
        }
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

        public static string feePay(DTO_DangKyLopChungChi register)
        {
            try
            {
                DAL_DangKyLopChungChi.payFee(register.ID_Student, register.ID_Class, register.ID_Course);
                return "Cập nhật thành công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
