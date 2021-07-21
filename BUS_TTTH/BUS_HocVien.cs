using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;
namespace BUS_TTTH
{
    public class BUS_HocVien
    {
        public static List<DTO_HocVien> AllStudents = DAL_HocVien.getStudents();

        public static List<DTO_HocVien> getAllStudents()
        {
            List<DTO_HocVien> Students = DAL_HocVien.getStudents();
            return Students;
        }
        public static DTO_HocVien getStudent(string id)
        {
            DTO_HocVien student = new DTO_HocVien();
            for (int i = 0; i < AllStudents.Count; i++)
            {
                if (AllStudents[i].ID == id)
                {
                    student = AllStudents[i];
                }
            }
            return student;
        }

        public static string insertStudent(DTO_HocVien student)
        {
            try
            {
                DAL_HocVien.insertStudent(student);
                return "Thêm Thành Công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }


        public static string deleteStudent(DTO_HocVien student)
        {
            try
            {
                DAL_HocVien.deleteStudent(student);
                return "Xoá Thành Công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public static string updateStudent(DTO_HocVien student)
        {
            try
            {
                DAL_HocVien.updateStudent(student);
                return "Cập Nhật Thành Công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
