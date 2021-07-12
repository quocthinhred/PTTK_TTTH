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
    public partial class NV_ThemNHP : Form
    {
        public NV_ThemNHP()
        {
            InitializeComponent();
            List<DTO_NhomHocPhan> AllNHP = BUS_NhomHocPhan.AllNHP;
            for (int i = 0; i < AllNHP.Count; i++)
            {
                cbb_nhp.Items.Add(AllNHP[i].Name);
            }
            
        }


        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (cbb_nhp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn NHP!");
            }
            else
            {
                try
                {
                    string notifi = BUS_NHPMo.addNHPM(cbb_nhp.Text);
                    MessageBox.Show(notifi);
                    DTO_NhomHocPhan NHP = BUS_NhomHocPhan.getNHPbyName(cbb_nhp.Text);
                    List<DTO_NHPMo> L_NHPM = BUS_NHPMo.getNHPM();
                    DTO_Khoa Cousre = BUS_Khoa.getNewCourse();
                    DTO_NHPMo NHPM = new DTO_NHPMo();
                    for (int i = 0; i < L_NHPM.Count; i++)
                    {
                        if (L_NHPM[i].ID == NHP.ID && L_NHPM[i].ID_Course == Cousre.ID)
                        {
                            NHPM = L_NHPM[i];
                        }
                    }
                    List<DTO_Lop> Classes = BUS_Lop.getLopKTV(NHPM);
                    for (int i = 0; i < Classes.Count; i++)
                    {
                        NV_LopKTVMo ktv = new NV_LopKTVMo(Classes[i]);
                        this.Close();
                        ktv.ShowDialog();
                    }
                    MessageBox.Show("Thêm Nhóm học phần thành công!");
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
