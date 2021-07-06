using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_LichHoc
    {
        public string ID_Class { get; set; }
        public string Name { get; set; }
        public string Schedule { get; set; }
        public DTO_LichHoc()
        {
            ID_Class = "";
            Name = "";
            Schedule = "";
        }
        public DTO_LichHoc(string id, string name, string schedule)
        {
            ID_Class = id;
            Name = name;
            Schedule = schedule;
        }
    }
}
