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
    /// Interaction logic for HocPhi_KTV.xaml
    /// </summary>
    public partial class HocPhi_KTV : Window
    {
        public HocPhi_KTV()
        {
            InitializeComponent();
            BUS_Lop.reload();
            List<DTO_DangKyNHP> Lists = new List<DTO_DangKyNHP>();
            Lists = BUS_DangKyNHP.getDKNHP();
            for (int i = 0; i < Lists.Count; i++)
            {
                if (Lists[i].ID_Course != BUS_Khoa.getNewCourse().ID)
                {
                    Lists.RemoveAt(i);
                    i--;
                }
            }
            dtg_fee.ItemsSource = Lists;
        }

        private void dtg_fee_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_fee.FontSize = 20;
            dtg_fee.RowHeight = 35;
            dtg_fee.Columns[0].Width = 150;
            dtg_fee.Columns[1].Width = 200;
            dtg_fee.Columns[2].Width = 150;
            dtg_fee.Columns[3].Visibility = Visibility.Hidden;
            dtg_fee.Columns[4].Width = dtg_fee.Width - 510;
            dtg_fee.Columns[5].Visibility = Visibility.Hidden;
            dtg_fee.Columns[6].Visibility = Visibility.Hidden;


        }

        private void bt_ok_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_fee.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                DTO_DangKyNHP register = (DTO_DangKyNHP)dtg_fee.SelectedItem;
                string notifi = BUS_DangKyNHP.feePay(register);
                MessageBox.Show(notifi);
                List<DTO_DangKyNHP> Lists = new List<DTO_DangKyNHP>();
                Lists = BUS_DangKyNHP.getDKNHP();
                for (int i = 0; i < Lists.Count; i++)
                {
                    if (Lists[i].ID_Course != BUS_Khoa.getNewCourse().ID)
                    {
                        Lists.RemoveAt(i);
                        i--;
                    }
                }
                dtg_fee.ItemsSource = Lists;
                dtg_fee.FontSize = 20;
                dtg_fee.RowHeight = 35;
                dtg_fee.Columns[0].Width = 150;
                dtg_fee.Columns[1].Width = 200;
                dtg_fee.Columns[2].Width = 150;
                dtg_fee.Columns[3].Visibility = Visibility.Hidden;
                dtg_fee.Columns[4].Width = dtg_fee.Width - 510;
                dtg_fee.Columns[5].Visibility = Visibility.Hidden;
                dtg_fee.Columns[6].Visibility = Visibility.Hidden;
            } 
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
