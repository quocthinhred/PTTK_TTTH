using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_TTTH;
using BUS_TTTH;

namespace GUI_TTTH
{
    public partial class GV_BangDiem : Form
    {
        public GV_BangDiem()
        {
            InitializeComponent();

        }

        public GV_BangDiem(string id_student, string id_class)
        {
            InitializeComponent();
            DTO_BangDiemHV table = BUS_BangDiemHV.getOne(id_student, id_class);
            tb_idstudent.Text = table.ID_Student;
            tb_idstudent.Enabled = false;
            tb_namestudent.Text = table.Name_Student;
            tb_namestudent.Enabled = false;
            tb_idclass.Text = table.ID_Class;
            tb_idclass.Enabled = false;
            tb_nameclass.Text = table.Name_Class;
            tb_nameclass.Enabled = false;
            tb_idcourse.Text = table.ID_Course;
            tb_idcourse.Enabled = false;
            tb_point.Text = table.Point;
            tb_point.Enabled = false;
            if (table.Point == "")
            {
                tb_point.Enabled = true;
            }
            tb_examcount.Text = table.ExamCount;
            tb_examcount.Enabled = false;
            tb_examdate.Text = table.ExamDate;
            tb_examdate.Enabled = false;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
