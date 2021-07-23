using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_DangKyNHP
    {
        public static List<DTO_DangKyNHP> getDKNHP()
        {
            List<DTO_DangKyNHP> Lists = DAL_DangKyNHP.getList();
            return Lists;
        }
        public static string addDKNHP(string id_student, DTO_NHPMo NHPM)
        {
            try
            {
                DAL_DangKyNHP.addDKNHP(id_student, NHPM);
                return "Thêm thành công!";
            }
            catch(Exception exc)
            {
                return exc.Message;
            }
        }

        public static string feePay(DTO_DangKyNHP register)
        {
            try
            {
                DAL_DangKyNHP.payFee(register.ID_Student, register.ID_NHP, register.ID_Course);
                return "Cập nhật thành công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public static int checkDone2Courses(string id)
        {
            List<DTO_DangKyNHP> list = DAL_DangKyNHP.getList();
            List<DTO_DangKyNHP> temp = new List<DTO_DangKyNHP>();
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ID_Student == id && list[i].Result == "1") count++;

            }
            if (count == 2) return 1;
            else return 0;
        }

        public static List<DTO_DangKyNHP> getNHPOf1Student(string id)
        {
            List<DTO_DangKyNHP> list = DAL_DangKyNHP.getList();
            List<DTO_DangKyNHP> temp = new List<DTO_DangKyNHP>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ID_Student == id ) temp.Add(list[i]);
            }
            return temp;
        }
    }
}
