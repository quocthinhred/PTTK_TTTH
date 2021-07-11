using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_NHPMo
    {
        public static List<DTO_NHPMo> getNHPM()
        {
            List<DTO_NHPMo> L_NHPM = DAL_NHPMo.getListNHPM();
            return L_NHPM;
        }
    }
}
