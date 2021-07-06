using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_GiangVien
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Birth { get; set; }
        public string Phone { get; set; }
        public DTO_GiangVien()
        {
            ID = "";
            Name = "";
            Birth = "";
            Phone = "";
        }
        public DTO_GiangVien(string id, string name, string birth, string phone)
        {
            ID = id;
            Name = name;
            Birth = birth;
            Phone = phone;
        }
    }
}
