using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_NHPMo
    {
        public string ID { get; set;}
        public string Name { get; set; }
        public string ID_Course { get; set; }
        public string IsFull { get; set; }
        public DTO_NHPMo()
        {
            ID = "";
            Name = "";
            ID_Course = "";
            IsFull = "";
        }

        public DTO_NHPMo(string id, string name, string id_Course, string isFull)
        {
            ID = id;
            Name = name;
            ID_Course = id_Course;
            IsFull = isFull;
        }
    }
}
