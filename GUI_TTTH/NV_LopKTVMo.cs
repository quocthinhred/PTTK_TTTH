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
    public partial class NV_LopKTVMo : Form
    {
        public NV_LopKTVMo()
        {
            InitializeComponent();
        }

        public NV_LopKTVMo(DTO_Lop Class)
        {
            InitializeComponent();
            
            tb_id.Text = Class.ID_Class;
            tb_name.Text = Class.Name;
            tb_course.Text = Class.ID_Course;
            List<DTO_GiangVien> Teachers = BUS_GiangVien.AllTeachers;
            for (int i =0; i < Teachers.Count; i++)
            {
                cbb_teacher.Items.Add(Teachers[i].ID);
            }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (tb_schedule.Text == "" || cbb_teacher.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                DTO_LopKTVMo KTVM = new DTO_LopKTVMo(tb_id.Text, tb_name.Text, tb_course.Text, cbb_teacher.Text, tb_schedule.Text);
                MessageBox.Show(BUS_Lop.updateClassKTV(KTVM));
                this.Close();
            }
        }
    }
}
