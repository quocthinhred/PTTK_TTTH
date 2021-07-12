using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_NhomHocPhan
    {
        public string ID { get; set; }
        public string Name { get; set;}
        public DTO_NhomHocPhan()
        {
            ID = "";
            Name = "";
        }

        public DTO_NhomHocPhan(string id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
