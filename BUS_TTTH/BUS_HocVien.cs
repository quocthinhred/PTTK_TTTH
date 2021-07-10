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
        public static List<DTO_HocVien> GV_LopHoc(DTO_Lop Class)
        {
            List<DTO_HocVien> Students = new List<DTO_HocVien>();
            List<DTO_BangDiem> Tables = DAL_BangDiem.getPointTable();
            List<DTO_DangKyLopChungChi> Registers1 = DAL_DangKyLopChungChi.getRegisterCerti();
            List<DTO_DangKyLopChuyenDe> Registers2 = DAL_DangKyLopChuyenDe.getRegisterTheme();
            for (int i = 0; i < Tables.Count; i++)
            {
                if (Tables[i].ID_Subject == Class.ID_Class && Tables[i].ID_Course == Class.ID_Course)
                {
                    DTO_HocVien student = getStudent(Tables[i].ID_Student);
                    int temp = 0;
                    for (int j = 0; j < Students.Count; j++)
                    {
                        if (student.ID != Students[j].ID)
                        {
                            temp++;
                        }
                    }
                    if (temp == Students.Count)
                        Students.Add(student);
                }
            }
            for (int i = 0; i < Registers1.Count; i++)
            {
                if (Registers1[i].ID_Class == Class.ID_Class && Registers1[i].ID_Course == Class.ID_Course)
                {
                    DTO_HocVien student = getStudent(Registers1[i].ID_Student);
                    Students.Add(student);
                }
            }
            for (int i = 0; i < Registers2.Count; i++)
            {
                if (Registers2[i].ID_Class == Class.ID_Class && Registers2[i].ID_Course == Class.ID_Course)
                {
                    DTO_HocVien student = getStudent(Registers2[i].ID_Student);
                    Students.Add(student);
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
