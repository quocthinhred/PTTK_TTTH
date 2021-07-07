using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_HocVien
    {
        public static List<DTO_HocVien> Students = DAL_HocVien.getStudents();
        public static List<DTO_HocVien> GV_LopHoc(string id)
        {
            

            return Students;
        }
    }
}
