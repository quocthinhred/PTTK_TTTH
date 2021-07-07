using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_Lop
    {
        public string ID_Class { get; set; }
        public string Name { get; set; }
        public string ID_Course { get; set; }
        public string Schedule { get; set; }
        public string ID_Teacher { get; set; }
        public DTO_Lop()
        {
            ID_Class = "";
            Name = "";
            Schedule = "";
            ID_Course = "";
            ID_Teacher = ""; 
        }
        public DTO_Lop(string id, string name, string id_Course, string schedule, string id_Teacher)
        {
            ID_Class = id;
            Name = name;
            Schedule = schedule;
            ID_Course = id_Course;
            ID_Teacher = id_Teacher;
        }

    }
}
