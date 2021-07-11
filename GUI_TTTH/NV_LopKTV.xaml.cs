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
    /// Interaction logic for NV_LopKTV.xaml
    /// </summary>
    public partial class NV_LopKTV : Window
    {
        int status = 0;
        public NV_LopKTV()
        {
            InitializeComponent();
            List<DTO_NHPMo> L_NHPM = BUS_NHPMo.getNHPM();
            dtg_NHP.ItemsSource = L_NHPM;
        }

        private void dtg_NHP_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_NHP.Columns[0].Width = 200;
            dtg_NHP.FontSize = 20;
            dtg_NHP.RowHeight = 35;
            dtg_NHP.Columns[1].Width = 500;
            dtg_NHP.Columns[2].Width = dtg_NHP.Width - 720;
            dtg_NHP.Columns[3].Visibility = Visibility.Hidden;
        }

        private void dtg_NHP_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            status = 1;
            DTO_NHPMo Class = (DTO_NHPMo)dtg_NHP.SelectedItem;
            dtg_NHP.ItemsSource = BUS_Lop.getLopKTV(Class);
            dtg_NHP.Columns[0].Width = 100;
            dtg_NHP.FontSize = 20;
            dtg_NHP.Columns[1].Width = 200;
            dtg_NHP.Columns[2].Width = 150;
            dtg_NHP.Columns[3].Width = dtg_NHP.Width - 460;
            //dtg_NHP.Columns[4].Visibility = Visibility.Hidden;
            dtg_NHP.RowHeight = 35;
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            if  (status == 1)
            {
                status = 0;
                List<DTO_NHPMo> L_NHPM = BUS_NHPMo.getNHPM();
                dtg_NHP.ItemsSource = L_NHPM;
                dtg_NHP.Columns[0].Width = 200;
                dtg_NHP.FontSize = 20;
                dtg_NHP.RowHeight = 35;
                dtg_NHP.Columns[1].Width = 500;
                dtg_NHP.Columns[2].Width = dtg_NHP.Width - 720;
                dtg_NHP.Columns[3].Visibility = Visibility.Hidden;
            }
            else
            {
                this.Close();
            }
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
