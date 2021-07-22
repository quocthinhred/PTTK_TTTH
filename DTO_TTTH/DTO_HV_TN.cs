using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_HV_TN
    {
        public string ID_Student { get; set; }
        public string ID_Course { get; set; }
        public string Point { get; set; }
        public string Fee { get; set; }
        public string ExamDate { get; set; }
        public string ID_Teacher { get; set; }

        public DTO_HV_TN()
        {
            ID_Student = "";
            ID_Course = "";
            Point = "";
            Fee = "";
            ExamDate = "";
            ID_Teacher = "";
        }

        public DTO_HV_TN(string id_Student, string id_Course, string point, string fee, string examDate, string id_Teacher)
        {
            ID_Student = id_Student;
            ID_Course = id_Course;
            Point = point;
            Fee = fee;
            ExamDate = examDate;
            ID_Teacher = id_Teacher;
        }
    }
}
