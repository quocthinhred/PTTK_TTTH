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
    public partial class NV_AddLCC : Form
    {
        public NV_AddLCC()
        {
            InitializeComponent();
            List<DTO_LopCCMo> L_LCCM = BUS_Lop.getLopCCMo();
            for (int i = 0; i < L_LCCM.Count; i++)
            {
                int temp = 0;
                for (int j = 0; j < i; j++)
                {
                    if (L_LCCM[i].ID == L_LCCM[j].ID)
                        temp++;
                }
                if (temp == 0)
                    cbb_id.Items.Add(L_LCCM[i].ID);
            }

            List<DTO_GiangVien> Teachers = BUS_GiangVien.getAllTeachers();
            for (int i = 0; i < Teachers.Count; i++)
            {
                cbb_teacher.Items.Add(Teachers[i].ID);
            }

            tb_course.Text = BUS_Khoa.getNewCourse().ID;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO_LopCCMo> L_LCCM = BUS_Lop.getLopCCMo();
            for (int i = 0; i < L_LCCM.Count; i++)
            {
                if (L_LCCM[i].ID == cbb_id.Text)
                {
                    tb_name.Text = L_LCCM[i].Name;
                }
            }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            DTO_LopCCMo LCCM = new DTO_LopCCMo(cbb_id.Text, tb_name.Text, tb_course.Text, cbb_teacher.Text, tb_schedule.Text, "1");
            string notifi = BUS_Lop.LCC_addLCCM(LCCM);
            MessageBox.Show(notifi);
            this.Close();
        }
    }
}
