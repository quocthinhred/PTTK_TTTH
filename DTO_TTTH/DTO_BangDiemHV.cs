using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_BangDiemHV
    {
        public string ID_Student { get; set; }
        public string Name_Student { get; set; }
        public string ID_Class { get; set; }
        public string Name_Class { get; set; }
        public string ID_Course { get; set; }
        public string Point { get; set; }
        public string ExamCount { get; set; }
        public string ExamDate { get; set; }
        public DTO_BangDiemHV()
        {
            ID_Student = "";
            Name_Class = "";
            Name_Student = "";
            ID_Class = "";
            ID_Course = "";
            Point = "";
            ExamCount = "1";
            ExamDate = "";
        }

        public DTO_BangDiemHV(string id_Student, string name_Student, string id_Class, string name_Class, string id_Course, string point, string examCount, string examDate)
        {
            ID_Student = id_Student;
            Name_Class = name_Class;
            Name_Student = name_Student;
            ID_Class = id_Class;
            ID_Course = id_Course;
            Point = point;
            ExamCount = examCount;
            ExamDate = examDate;
        }
    }
}
