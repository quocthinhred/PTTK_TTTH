﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_TTTH;
using DAL_TTTH;

namespace BUS_TTTH
{
    public class BUS_Lop
    {
        public static List<DTO_LopCCMo> DSLopCCMo = DAL_LopCCMo.getDSLopCCMo();
        public static List<DTO_LopCDMo> DSLopCDMo = DAL_LopCDMo.getDSLopCDMo();
        public static List<DTO_LopKTVMo> DSLopKTVMo = DAL_LopKTVMo.getDSLopKTVMo();

        public static List<DTO_Lop> getAllClasses()
        {
            List<DTO_Lop> Classes = new List<DTO_Lop>();
            for (int i = 0; i < DSLopCCMo.Count; i++)
            {
                DTO_Lop Class = new DTO_Lop(DSLopCCMo[i].ID, DSLopCCMo[i].Name, DSLopCCMo[i].ID_Course, DSLopCCMo[i].Schedule, DSLopCCMo[i].ID_Teacher);
                Classes.Add(Class);
            }
            for (int i = 0; i < DSLopCDMo.Count; i++)
            {
                DTO_Lop Class = new DTO_Lop(DSLopCDMo[i].ID, DSLopCDMo[i].Name, DSLopCDMo[i].ID_Course, DSLopCDMo[i].Schedule, DSLopCDMo[i].ID_Teacher);
                Classes.Add(Class);
            }
            for (int i = 0; i < DSLopKTVMo.Count; i++)
            {
                DTO_Lop Class = new DTO_Lop(DSLopKTVMo[i].ID, DSLopKTVMo[i].Name, DSLopKTVMo[i].ID_Course, DSLopKTVMo[i].Schedule, DSLopKTVMo[i].ID_Teacher);
                Classes.Add(Class);
            }
            return Classes;

        }
        public static List<DTO_Lop> getScheduleTeacher(string id_teacher)
        {
            List<DTO_Lop> schedules = new List<DTO_Lop>();
            DTO_Khoa course = BUS_Khoa.getNewCourse();
            for (int i = 0; i < DSLopCCMo.Count; i++)
            {
                if (DSLopCCMo[i].ID_Teacher == id_teacher && DSLopCCMo[i].ID_Course == course.ID)
                {
                    DTO_Lop schedule = new DTO_Lop(DSLopCCMo[i].ID, DSLopCCMo[i].Name, DSLopCCMo[i].ID_Course, DSLopCCMo[i].Schedule, DSLopCCMo[i].ID_Teacher);
                    schedules.Add(schedule);
                }
            }
            for (int i = 0; i < DSLopCDMo.Count; i++)
            {
                if (DSLopCDMo[i].ID_Teacher == id_teacher && DSLopCDMo[i].ID_Course == course.ID)
                {
                    DTO_Lop schedule = new DTO_Lop(DSLopCDMo[i].ID, DSLopCDMo[i].Name, DSLopCDMo[i].ID_Course, DSLopCDMo[i].Schedule, DSLopCDMo[i].ID_Teacher);
                    schedules.Add(schedule);
                }
            }
            for (int i = 0; i < DSLopKTVMo.Count; i++)
            {
                if (DSLopKTVMo[i].ID_Teacher == id_teacher && DSLopKTVMo[i].ID_Course == course.ID)
                {
                    DTO_Lop schedule = new DTO_Lop(DSLopKTVMo[i].ID, DSLopKTVMo[i].Name, DSLopKTVMo[i].ID_Course, DSLopKTVMo[i].Schedule, DSLopKTVMo[i].ID_Teacher);
                    schedules.Add(schedule);
                }
            }
            return schedules;
        }
        public static List<DTO_Lop> getClassesTeacher(string id_teacher)
        {
            List<DTO_Lop> Classes = new List<DTO_Lop>();
            for (int i = 0; i < DSLopCCMo.Count; i++)
            {
                if (DSLopCCMo[i].ID_Teacher == id_teacher)
                {
                    DTO_Lop Class = new DTO_Lop(DSLopCCMo[i].ID, DSLopCCMo[i].Name, DSLopCCMo[i].ID_Course, DSLopCCMo[i].Schedule, DSLopCCMo[i].ID_Teacher);
                    Classes.Add(Class);
                }
            }
            for (int i = 0; i < DSLopCDMo.Count; i++)
            {
                if (DSLopCDMo[i].ID_Teacher == id_teacher)
                {
                    DTO_Lop Class = new DTO_Lop(DSLopCDMo[i].ID, DSLopCDMo[i].Name, DSLopCDMo[i].ID_Course, DSLopCDMo[i].Schedule, DSLopCDMo[i].ID_Teacher);
                    Classes.Add(Class);
                }
            }
            for (int i = 0; i < DSLopKTVMo.Count; i++)
            {
                if (DSLopKTVMo[i].ID_Teacher == id_teacher)
                {
                    DTO_Lop Class = new DTO_Lop(DSLopKTVMo[i].ID, DSLopKTVMo[i].Name, DSLopKTVMo[i].ID_Course, DSLopKTVMo[i].Schedule, DSLopKTVMo[i].ID_Teacher);
                    Classes.Add(Class);
                }
            }
            return Classes;
        }

        public static DTO_Lop getClass(string id_class, string id_course)
        {
            DTO_Lop Class = new DTO_Lop();
            List<DTO_Lop> Classes = getAllClasses();
            for (int i = 0; i < Classes.Count; i++)
            {
                if (Classes[i].ID_Class == id_class && Classes[i].ID_Course == id_course)
                    Class = Classes[i];
            }
            return Class;
        }

        public static List<DTO_Lop> getScheduleStudent(string id_student)
        {
            List<DTO_Lop> schedules = new List<DTO_Lop>();
            List<DTO_BangDiemHV> studentTable = BUS_BangDiemHV.getAll();
            DTO_Khoa course = BUS_Khoa.getNewCourse();
            for (int i = 0; i < studentTable.Count; i++)
            {
                if (studentTable[i].ID_Student == id_student && studentTable[i].ID_Course == course.ID && studentTable[i].ExamCount == "1")
                {
                    DTO_Lop schedule = getClass(studentTable[i].ID_Class, studentTable[i].ID_Course);
                    schedules.Add(schedule);
                }
            }  
            return schedules;
        }



    }
}
