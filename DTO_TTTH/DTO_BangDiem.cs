using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_BangDiem
    {
        public string ID_Student { get; set; }
        public string ID_Subject { get; set; }
        public string ID_Course { get; set; }
        public string ExamCount { get; set; }
        public string Point { get; set; }
        public string ExamDate { get; set; }
        public DTO_BangDiem()
        {
            ID_Student = "";
            ID_Subject = "";
            ID_Course = "";
            ExamCount = "";
            Point = "";
            ExamDate = "";
        }

        public DTO_BangDiem(string id_Student, string id_Subject, string id_Course, string examCount, string point, string examDate)
        {
            ID_Student = id_Student;
            ID_Subject = id_Subject;
            ID_Course = id_Course;
            ExamCount = examCount;
            Point = point;
            ExamDate = examDate;
        }
    }
}
