using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TTTH
{
    public class DTO_Khoa
    {
        public string ID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public DTO_Khoa (string id, string startDate, string endDate)
        {
            ID = id;
            StartDate = startDate;
            EndDate = endDate;
        }

        public DTO_Khoa()
        {
            ID = "";
            StartDate = "";
            EndDate = "";
        }
    }
}
