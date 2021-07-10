using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_GiangVien
    {
        public static List<DTO_GiangVien> AllTeachers = DAL_GiangVien.getTeachers();
        public static DTO_GiangVien getStudent(string id)
        {
            DTO_GiangVien teacher = new DTO_GiangVien();
            for (int i = 0; i < AllTeachers.Count; i++)
            {
                if (AllTeachers[i].ID == id)
                {
                    teacher = AllTeachers[i];
                }
            }
            return teacher;
        }

        public static string insertTeacher(DTO_GiangVien teacher)
        {
            try
            {
                DAL_GiangVien.insertTeacher(teacher);
                return "Thêm Thành Công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }


        public static string deleteTeacher(DTO_GiangVien teacher)
        {
            try
            {
                DAL_GiangVien.deleteTeacher(teacher);
                return "Xoá Thành Công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public static string updateTeacher(DTO_GiangVien teacher)
        {
            try
            {
                DAL_GiangVien.updateTeacher(teacher);
                return "Cập Nhật Thành Công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
