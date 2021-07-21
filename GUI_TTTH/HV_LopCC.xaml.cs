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
    /// Interaction logic for HV_LopCC.xaml
    /// </summary>
    public partial class HV_LopCC : Window
    {
        string id2;
        public HV_LopCC()
        {
            InitializeComponent();
        }

        public HV_LopCC(string id)
        {
            id2 = id;
            InitializeComponent();
            List<DTO_LopCCMo> lopCC = new List<DTO_LopCCMo>();
            lopCC = BUS_Lop.getLopCCMo_Available();
            dtg_CC.ItemsSource = lopCC;
        }

        private void bt_register_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_CC.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_LopCCMo LCCM = (DTO_LopCCMo)dtg_CC.SelectedItem;
                    string notifi = BUS_DangKyLopChungChi.addStudent(id2, LCCM);
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

        private void dtg_CC_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_CC.Columns[0].Width = 100;
            dtg_CC.FontSize = 20;
            dtg_CC.RowHeight = 35;
            dtg_CC.Columns[1].Width = 250;
            dtg_CC.Columns[2].Width = 100;
            dtg_CC.Columns[3].Width = dtg_CC.Width - 675;
            dtg_CC.Columns[4].Width = 100;
            dtg_CC.Columns[5].Width = 100;
        }
    }
}
