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
    }
}
