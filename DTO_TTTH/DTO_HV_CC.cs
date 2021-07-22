using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_HV_CC
    {
        public string ID_Student { get; set; }
        public string ID_Certi { get; set; }
        public string Result { get; set; }

        public DTO_HV_CC()
        {
            ID_Student = "";
            ID_Certi = "";
            Result = "";
        }
        public DTO_HV_CC(string id_Student, string id_Certi, string result)
        {
            ID_Student = id_Student;
            ID_Certi = id_Certi;
            Result = result;
        }
    }
}
