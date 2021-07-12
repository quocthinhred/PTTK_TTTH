using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_TTTH;
using DTO_TTTH;

namespace BUS_TTTH
{
    public class BUS_NhomHocPhan
    {
        public static List<DTO_NhomHocPhan> AllNHP = DAL_NhomHocPhan.getAllNHP();

        public static DTO_NhomHocPhan getNHPbyName(string name_NHP)
        {
            for (int i = 0; i < AllNHP.Count; i++)
            {
                if (AllNHP[i].Name == name_NHP)
                {
                    return AllNHP[i];
                }
            }
            return null;
        }
        
    }
}
