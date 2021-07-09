using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_BangDiemHV
    {
        
        public static List<DTO_BangDiemHV> getAll()
        {
            List<DTO_BangDiem> Tables = DAL_BangDiem.getPointTable();
            List<DTO_DangKyLopChungChi> Registers1 = DAL_DangKyLopChungChi.getRegisterCerti();
            List<DTO_DangKyLopChuyenDe> Registers2 = DAL_DangKyLopChuyenDe.getRegisterTheme();

            List<DTO_BangDiemHV> StudentTables = new List<DTO_BangDiemHV>();
            for (int i = 0; i < Tables.Count; i++)
            {
                DTO_HocVien student = BUS_HocVien.getStudent(Tables[i].ID_Student);
                DTO_Lop Class = BUS_Lop.getClass(Tables[i].ID_Subject, Tables[i].ID_Course);
                DTO_BangDiemHV table = new DTO_BangDiemHV(student.ID, student.Name, Class.ID_Class, Class.Name, Tables[i].ID_Course, Tables[i].Point, Tables[i].ExamCount, Tables[i].ExamDate);
                StudentTables.Add(table);
            }
            for (int i = 0; i < Registers1.Count; i++)
            {
                DTO_HocVien student = BUS_HocVien.getStudent(Registers1[i].ID_Student);
                DTO_Lop Class = BUS_Lop.getClass(Registers1[i].ID_Class, Registers1[i].ID_Course);
                DTO_BangDiemHV table = new DTO_BangDiemHV(student.ID, student.Name, Class.ID_Class, Class.Name, Registers1[i].ID_Course, Registers1[i].Point, "1", Registers1[i].ExamDate);
                StudentTables.Add(table);
            }
            for (int i = 0; i < Registers2.Count; i++)
            {
                DTO_HocVien student = BUS_HocVien.getStudent(Registers2[i].ID_Student);
                DTO_Lop Class = BUS_Lop.getClass(Registers2[i].ID_Class, Registers2[i].ID_Course);
                DTO_BangDiemHV table = new DTO_BangDiemHV(student.ID, student.Name, Class.ID_Class, Class.Name, Registers2[i].ID_Course, "NONE", "1", "NONE");
                StudentTables.Add(table);
            }
            return StudentTables;
        }

        public static DTO_BangDiemHV getOne(string id_student, string id_class)
        {
            DTO_BangDiemHV student = new DTO_BangDiemHV();
            List<DTO_BangDiemHV> StudentTables = getAll();
            
            for (int i = 0; i < StudentTables.Count; i++)
            {
                if (id_student == StudentTables[i].ID_Student && id_class == StudentTables[i].ID_Class)
                {
                    if (String.Compare(StudentTables[i].ExamCount,student.ExamCount) >= 0)
                    {
                        student = StudentTables[i];
                    }
                }
            }
            return student;
        }
    }
}
