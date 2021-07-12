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
        public string Fee { get; set; }
        public DTO_NhomHocPhan()
        {
            ID = "";
            Name = "";
            Fee = "";
        }

        public DTO_NhomHocPhan(string id, string name, string fee)
        {
            ID = id;
            Name = name;
            Fee = fee;
        }
    }
}
