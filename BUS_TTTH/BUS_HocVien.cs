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
                return "Thêm Học Viên Thành Công!";
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
                return "Xoá Học Viên Thành Công!";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
