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
    /// Interaction logic for HocPhi_LCD.xaml
    /// </summary>
    public partial class HocPhi_LCD : Window
    {
        public HocPhi_LCD()
        {
            InitializeComponent();
            List<DTO_DangKyLopChuyenDe> Lists = BUS_DangKyLopChuyenDe.getList();
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

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_ok_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_fee.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                DTO_DangKyLopChuyenDe register = (DTO_DangKyLopChuyenDe)dtg_fee.SelectedItem;
                string notifi = BUS_DangKyLopChuyenDe.feePay(register);
                MessageBox.Show(notifi);
                List<DTO_DangKyLopChuyenDe> Lists = BUS_DangKyLopChuyenDe.getList();
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
                dtg_fee.Columns[3].Width = dtg_fee.Width - 510;
            }
        }

        private void dtg_fee_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_fee.FontSize = 20;
            dtg_fee.RowHeight = 35;
            dtg_fee.Columns[0].Width = 150;
            dtg_fee.Columns[1].Width = 200;
            dtg_fee.Columns[2].Width = 150;
            dtg_fee.Columns[3].Width = dtg_fee.Width - 510;

        }
    }
}
