using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_HocVien
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Birth { get; set; }
        public string Phone { get; set; }
        public DTO_HocVien()
        {
            ID = "";
            Name = "";
            Birth = "";
            Phone = "";
        }

        public DTO_HocVien(string id, string name, string birth, string phone)
        {
            ID = id;
            Name = name;
            Birth = birth;
            Phone = phone;
        }

    }
}
