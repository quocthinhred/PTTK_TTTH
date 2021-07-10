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
        public static List<DTO_BangDiemHV> GV_LopHoc(DTO_Lop Class)
        {
            List<DTO_BangDiemHV> Students = new List<DTO_BangDiemHV>();

            List<DTO_BangDiemHV> listBDHV = BUS_BangDiemHV.getAll();
            for (int i = 0; i < listBDHV.Count; i++)
            {
                if (listBDHV[i].ID_Class == Class.ID_Class && listBDHV[i].ID_Course == Class.ID_Course)
                {
                    DTO_BangDiemHV student = BUS_BangDiemHV.getOne(listBDHV[i].ID_Student, listBDHV[i].ID_Class);
                    Students.Add(student);
                }
            }
            for (int i = 0; i < Students.Count - 1; i++)
            {
                if (Students[i].ID_Student == Students[i+1].ID_Student)
                {
                    Students.RemoveAt(i);
                }
            }
            
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
    }
}
