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
        string id_student2;
        string id_class2;
        DTO_BangDiemHV table = new DTO_BangDiemHV();
        public GV_BangDiem()
        {
            InitializeComponent();
        }

        public GV_BangDiem(string id_student, string id_class)
        {
            id_student2 = id_student;
            id_class2 = id_class;
            InitializeComponent();
            table = BUS_BangDiemHV.getOne(id_student, id_class, "0");
            tb_idstudent.Text = table.ID_Student;
            tb_idstudent.Enabled = false;
            tb_idstudent.BackColor = System.Drawing.Color.White;
            tb_namestudent.Text = table.Name_Student;
            tb_namestudent.Enabled = false;
            tb_namestudent.BackColor = System.Drawing.Color.White;
            tb_idclass.Text = table.ID_Class;
            tb_idclass.Enabled = false;
            tb_idclass.BackColor = System.Drawing.Color.White;
            tb_nameclass.Text = table.Name_Class;
            tb_nameclass.Enabled = false;
            tb_nameclass.BackColor = System.Drawing.Color.White;
            tb_idcourse.Text = table.ID_Course;
            tb_idcourse.Enabled = false;
            tb_idcourse.BackColor = System.Drawing.Color.White;
            tb_point.Text = table.Point;
            tb_point.Enabled = false;
            if (table.Point == "")
            {
                tb_point.Enabled = true;
            }
            tb_point.BackColor = System.Drawing.Color.White;
            tb_examcount.Text = table.ExamCount;
            if (table.ExamCount != "1")
            {
                tb_examcount.Size = new System.Drawing.Size(435, 35);
                bt_previous.Visible = true;
            }
            tb_examcount.Enabled = false;
            tb_examcount.BackColor = System.Drawing.Color.White;
            tb_examdate.Text = table.ExamDate;
            tb_examdate.Enabled = false;
            tb_examdate.BackColor = System.Drawing.Color.White;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_point.Text == "")
            {
                this.Close();
            }
            int point = Int32.Parse(tb_point.Text);
            if (point > 10)
            {
                MessageBox.Show("Vui lòng nhập điểm chính xác!");
            }
            else
            {
                table.Point = tb_point.Text;
                if (tb_point.Enabled == true)
                {
                    string notifi = BUS_BangDiemHV.updatePoint(table);
                    MessageBox.Show(notifi);
                    GV_BangDiem gv_bangdiem = new GV_BangDiem(table.ID_Student, table.ID_Class);
                    this.Hide();
                    gv_bangdiem.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            string examCount = "";
            if (tb_examcount.Text == "4")
            {
                examCount = "3";
                bt_previous.Text = "Lần Trước";
            }
            else if (tb_examcount.Text == "3")
            {
                examCount = "2";
                bt_previous.Text = "Lần Trước";
            }
            else if (tb_examcount.Text == "2")
            {
                examCount = "1";
                bt_previous.Text = "Gần Nhất";
            }
            else if (tb_examcount.Text == "1")
            {
                examCount = "0";
                bt_previous.Text = "Lần Trước";
            }    
            DTO_BangDiemHV table = BUS_BangDiemHV.getOne(id_student2, id_class2, examCount);
            tb_examcount.Text = table.ExamCount;
            tb_point.Text = table.Point;
            tb_examdate.Text = table.ExamDate;
        }

        private void tb_point_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
