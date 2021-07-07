using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_DangKyLopChuyenDe
    {
        public string ID_Student { get; set; }
        public string ID_Class { get; set; }
        public string ID_Course { get; set; }
        public string Fee { get; set; }
        public DTO_DangKyLopChuyenDe()
        {
            ID_Student = "";
            ID_Class = "";
            ID_Course = "";
            Fee = "";
        }

        public DTO_DangKyLopChuyenDe(string id_Student, string id_Class, string id_Course, string fee)
        {
            ID_Student = id_Student;
            ID_Class = id_Class;
            ID_Course = id_Course;
            Fee = fee;
        }
    }
}
