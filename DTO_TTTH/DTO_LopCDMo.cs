using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_LopCDMo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ID_Course { get; set; }
        public string Schedule { get; set; }
        public string ID_Teacher { get; set; }
        public string IsFull { get; set; }
        public DTO_LopCDMo()
        {
            ID = "";
            Name = "";
            ID_Course = "";
            Schedule = "";
            ID_Teacher = "";
            IsFull = "";
        }
        public DTO_LopCDMo(string id, string name, string id_Course, string id_Teacher, string schedule, string isFull)
        {
            ID = id;
            Name = name;
            ID_Course = id_Course;
            Schedule = schedule;
            ID_Teacher = id_Teacher;
            IsFull = isFull;
        }
    }
}
