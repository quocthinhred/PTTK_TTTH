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
            DTO_Khoa course = new DTO_Khoa();
            course = Courses[0];
            for(int i = 1; i < Courses.Count; i++)
            {
                if (string.Compare(course.ID, Courses[i].ID) <= 0)
                {
                    course = Courses[i];
                }
            }
            return course;
        }

        
    }
}
