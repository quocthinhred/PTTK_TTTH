using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_LichHoc
    {
        public static List<DTO_LopCCMo> DSLopCCMo = DAL_LopCCMo.getDSLopCCMo();
        public static List<DTO_LopCDMo> DSLopCDMo = DAL_LopCDMo.getDSLopCDMo();
        public static List<DTO_LopKTVMo> DSLopKTVMo = DAL_LopKTVMo.getDSLopKTVMo();
        public static List<DTO_LichHoc> getScheduleTeacher(string id)
        {
            List<DTO_LichHoc> schedules = new List<DTO_LichHoc>();
            for (int i = 0; i < DSLopCCMo.Count; i++)
            {
                if (DSLopCCMo[i].ID_Teacher == id)
                {
                    DTO_LichHoc schedule = new DTO_LichHoc(DSLopCCMo[i].ID, DSLopCCMo[i].Name, DSLopCCMo[i].Schedule);
                    schedules.Add(schedule);
                }
            }
            for (int i = 0; i < DSLopCDMo.Count; i++)
            {
                if (DSLopCDMo[i].ID_Teacher == id)
                {
                    DTO_LichHoc schedule = new DTO_LichHoc(DSLopCDMo[i].ID, DSLopCDMo[i].Name, DSLopCDMo[i].Schedule);
                    schedules.Add(schedule);
                }
            }
            for (int i = 0; i < DSLopKTVMo.Count; i++)
            {
                if (DSLopKTVMo[i].ID_Teacher == id)
                {
                    DTO_LichHoc schedule = new DTO_LichHoc(DSLopKTVMo[i].ID, DSLopKTVMo[i].Name, DSLopKTVMo[i].Schedule);
                    schedules.Add(schedule);
                }
            }
            return schedules;
        }
    }
}
