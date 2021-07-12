using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_DangKyNHP
    {
        public string ID_Student { get; set; }
        public string ID_NHP { get; set; }
        public string ID_Course { get; set; }
        public string Point { get; set; }
        public string Fee { get; set; }
        public string ExamCount { get; set; }
        public string Result { get; set; }
        public DTO_DangKyNHP()
        {
            ID_Student = "";
            ID_NHP = "";
            ID_Course = "";
            Point = "";
            Fee = "";
            ExamCount = "";
            Result = "";
        }

        public DTO_DangKyNHP(string id_Student, string id_NHP, string id_Course, string point, string fee, string examCount, string result)
        {
            ID_Student = id_Student;
            ID_NHP = id_NHP;
            ID_Course = id_Course;
            Point = point;
            Fee = fee;
            ExamCount = examCount;
            Result = result;
        }
    }
}
