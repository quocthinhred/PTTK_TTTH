using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_ThanhTich
    {
        
        public static List<DTO_HV_TN> achievements1 = DAL_HV_TN.getAchievements();
        public static List<DTO_HV_CC> achievements2 = DAL_HV_CC.getAchievements();

        public static void reload()
        {
            achievements1.Clear();
            achievements1 = DAL_HV_TN.getAchievements();
        }

        public static void reload2()
        {
            achievements2.Clear();
            achievements2 = DAL_HV_CC.getAchievements();

        }
        
        public static List<DTO_HV_TN> getHV_TN(string id)
        {
            reload();
            DTO_HV_TN achievement = new DTO_HV_TN();
            List<DTO_HV_TN> temp = new List<DTO_HV_TN>();
            for (int i = 0; i < achievements1.Count; i++)
            {
                if (achievements1[i].ID_Student == id)
                {
                    achievement = achievements1[i];
                    temp.Add(achievement);
                }
            }
            return temp;
        }

        public static int checkPassed(string id)
        {
            List<DTO_HV_TN> achievements = getHV_TN(id);
              
            if (achievements.Count > 0)
            {
                for (int i = 0; i < achievements.Count; i++)
                {
                    if (achievements[i].Point == "") return 1;
                    int temp;
                    temp = Int32.Parse(achievements[i].Point);
                    if (temp >= 5) return 1;
                    if (achievements[i].Point == "") return 1;
                }
                return 0;
            }
            else return 1;
        }

        public static string insertHV_TN(DTO_HV_TN student)
        {
            try
            {
                DAL_HV_TN.insertHV_TN(student);
                return "Thêm thành công !!!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static List<DTO_HV_CC> getHV_CC(string id)
        {
            reload2();
            DTO_HV_CC achievement = new DTO_HV_CC();
            List<DTO_HV_CC> temp = new List<DTO_HV_CC>();
            for (int i = 0; i < achievements2.Count; i++)
            {
                if (achievements2[i].ID_Student == id)
                {
                    achievement = achievements2[i];
                    temp.Add(achievement);
                }
            }
            return temp;
        }
    }
}
