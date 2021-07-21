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

        public static List<DTO_NHPMo> getNHPM_Available()
        {
            List<DTO_NHPMo> L_NHPM = DAL_NHPMo.getListNHPM();
            List<DTO_NHPMo> temp = new List<DTO_NHPMo>();
            for (int i = 0; i < L_NHPM.Count; i++)
            {
                if (L_NHPM[i].IsFull == "0") temp.Add(L_NHPM[i]);
            }
            return temp;
        }

        public static string addNHPM(string name_NHP)
        {
            DTO_NhomHocPhan NHP = BUS_NhomHocPhan.getNHPbyName(name_NHP);
            DTO_Khoa Course = BUS_Khoa.getNewCourse();
            List<DTO_NHPMo> L_NHPM = BUS_NHPMo.getNHPM();
            for (int i = 0; i < L_NHPM.Count; i++)
            {
                if (L_NHPM[i].ID == NHP.ID && L_NHPM[i].ID_Course == Course.ID)
                {
                    return "Khoá này đã tồn tại NHP này!";
                }
                else
                {
                    try
                    {
                        DAL_NHPMo.addNHPM(NHP, Course);
                        return "Thêm thành công!";
                    }
                    catch (Exception exc)
                    {
                        return exc.Message;
                    }
                }
            }
            return "";
        }

        public static string updateIsFull(DTO_NHPMo NHPM)
        {
            try
            {
                DAL_NHPMo.updateIsFull(NHPM);
                return "Cập nhật thành công!";
            }
            catch(Exception exc)
            {
                return exc.Message;
            }
        }



    }
    
}
