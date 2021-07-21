using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DTO_TTTH;
using BUS_TTTH;

namespace GUI_TTTH
{
    /// <summary>
    /// Interaction logic for HV_LopCD.xaml
    /// </summary>
    public partial class HV_LopCD : Window
    {
        string id2;
        public HV_LopCD()
        {
            InitializeComponent();
        }

        public HV_LopCD(string id)
        {
            id2 = id;
            InitializeComponent();
            List<DTO_LopCDMo> lopCD = new List<DTO_LopCDMo>();
            lopCD = BUS_Lop.getLopCDMo_Available();
            dtg_CD.ItemsSource = lopCD;
        }

        private void bt_register_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_CD.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_LopCDMo LCDM = (DTO_LopCDMo)dtg_CD.SelectedItem;
                    string notifi = BUS_DangKyLopChuyenDe.addStudent(id2, LCDM);
                    MessageBox.Show(notifi);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dtg_CD_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_CD.Columns[0].Width = 100;
            dtg_CD.FontSize = 20;
            dtg_CD.RowHeight = 35;
            dtg_CD.Columns[1].Width = 250;
            dtg_CD.Columns[2].Width = 100;
            dtg_CD.Columns[3].Width = dtg_CD.Width - 675;
            dtg_CD.Columns[4].Width = 100;
            dtg_CD.Columns[5].Width = 100;
        }
    }
}
