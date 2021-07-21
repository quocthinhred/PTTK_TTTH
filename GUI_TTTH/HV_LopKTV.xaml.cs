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
    /// Interaction logic for HV_LopKTV.xaml
    /// </summary>
    public partial class HV_LopKTV : Window
    {
        string id2;
        public HV_LopKTV()
        {
            InitializeComponent();
        }

        public HV_LopKTV(string id)
        {
            id2 = id;
            InitializeComponent();
            List<DTO_NHPMo> lopKTV = new List<DTO_NHPMo>();
            lopKTV = BUS_NHPMo.getNHPM_Available();
            dtg_NHP.ItemsSource = lopKTV;
        }

        private void bt_register_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_NHP.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_NHPMo NHPM = (DTO_NHPMo)dtg_NHP.SelectedItem;
                    string notifi = BUS_DangKyNHP.addDKNHP(id2, NHPM);
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

        private void dtg_NHP_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_NHP.Columns[0].Width = 200;
            dtg_NHP.FontSize = 20;
            dtg_NHP.RowHeight = 35;
            dtg_NHP.Columns[1].Width = 400;
            dtg_NHP.Columns[2].Width = dtg_NHP.Width - 720;
            dtg_NHP.Columns[3].Width = 100;
        }
    }
}
