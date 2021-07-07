using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_LopKTVMo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ID_Course { get; set; }
        public string ID_Teacher { get; set; }
        public string Schedule { get; set; }

        public DTO_LopKTVMo()
        {
            ID = "";
            Name = "";
            ID_Course = "";
            ID_Teacher = "";
            Schedule = "";
        }
        public DTO_LopKTVMo(string id, string name, string id_Course, string id_Teacher, string schedule)
        {
            ID = id;
            Name = name;
            ID_Course = id_Course;
            ID_Teacher = id_Teacher;
            Schedule = schedule;
        }
    }
}
