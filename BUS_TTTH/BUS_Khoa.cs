using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_Khoa
    {
        public static List<DTO_Khoa> Courses = DAL_Khoa.getCourses();
        public static DTO_Khoa getNewCourse()
        {
            List<DTO_Khoa> AllCourses = DAL_Khoa.getCourses();
            DTO_Khoa course = new DTO_Khoa();
            course = AllCourses[0];
            int intCourse;
            for(int i = 1; i < AllCourses.Count; i++)
            {
                intCourse = Int32.Parse(course.ID.Substring(1));
                string temp = AllCourses[i].ID.Substring(1);
                int intTemp = Int32.Parse(temp);
                if (intTemp >= intCourse)
                {
                    course = AllCourses[i];
                }
            }
            return course;
        }


        public static List<DTO_Khoa> addCourse(DTO_Khoa newCourse)
        {
            List<DTO_Khoa> Courses = DAL_Khoa.addCourse(newCourse);
            return Courses;
        }
        
    }
}
