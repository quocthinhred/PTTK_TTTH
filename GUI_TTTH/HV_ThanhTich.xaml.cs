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
using BUS_TTTH;
using DTO_TTTH;

namespace GUI_TTTH
{
    /// <summary>
    /// Interaction logic for HV_ThanhTich.xaml
    /// </summary>
    public partial class HV_ThanhTich : Window
    {
        string id2;
        public HV_ThanhTich()
        {
            InitializeComponent();
        }

        public HV_ThanhTich(string id)
        {
            id2 = id;
            InitializeComponent();
            List<DTO_HV_TN> lopKTV = new List<DTO_HV_TN>();
            List<DTO_HV_CC> lopCC = new List<DTO_HV_CC>();
            List<DTO_DangKyLopChuyenDe> lopCD = new List<DTO_DangKyLopChuyenDe>();
            lopKTV = BUS_ThanhTich.getHV_TN(id);
            dtg_lopKTV.ItemsSource = lopKTV;
            lopCC = BUS_ThanhTich.getHV_CC(id);
            dtg_lopCC.ItemsSource = lopCC;
            lopCD = BUS_DangKyLopChuyenDe.getClassesOfAStudent(id);
            dtg_lopCD.ItemsSource = lopCD;
            int check = BUS_ThanhTich.checkPassed(id);
            if (check == 1) bt_register.Visibility = Visibility.Hidden;
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void dtg_lopKTV_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_lopKTV.Columns[0].Width = 150;
            dtg_lopKTV.FontSize = 20;
            dtg_lopKTV.RowHeight = 35;
            dtg_lopKTV.Columns[1].Width = 100;
            dtg_lopKTV.Columns[2].Width = 100;
            dtg_lopKTV.Columns[3].Width = 150;
            dtg_lopKTV.Columns[4].Width = 250;
            dtg_lopKTV.Columns[5].Width = 145;
        }

        private void dtg_lopCC_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_lopCC.Columns[0].Width = 295;
            dtg_lopCC.FontSize = 20;
            dtg_lopCC.RowHeight = 35;
            dtg_lopCC.Columns[1].Width = 300;
            dtg_lopCC.Columns[2].Width = 300;
        }

        private void dtg_lopCD_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_lopCD.Columns[0].Width = 215;
            dtg_lopCD.FontSize = 20;
            dtg_lopCD.RowHeight = 35;
            dtg_lopCD.Columns[1].Width = 225;
            dtg_lopCD.Columns[2].Width = 225;
            dtg_lopCD.Columns[3].Width = 225;
        }

        private void bt_register_Click(object sender, RoutedEventArgs e)
        {
            DTO_HV_TN student = new DTO_HV_TN(id2, BUS_Khoa.getNewCourse().ID, "null","100000","","null");
            MessageBox.Show(BUS_ThanhTich.insertHV_TN(student));
            BUS_ThanhTich.reload();
            List<DTO_HV_TN> lopKTV = new List<DTO_HV_TN>();
            lopKTV = BUS_ThanhTich.getHV_TN(id2);
            dtg_lopKTV.ItemsSource = lopKTV;
            int check = BUS_ThanhTich.checkPassed(id2);
            if (check == 1) bt_register.Visibility = Visibility.Hidden;
            dtg_lopKTV.Columns[0].Width = 150;
            dtg_lopKTV.FontSize = 20;
            dtg_lopKTV.RowHeight = 35;
            dtg_lopKTV.Columns[1].Width = 100;
            dtg_lopKTV.Columns[2].Width = 100;
            dtg_lopKTV.Columns[3].Width = 150;
            dtg_lopKTV.Columns[4].Width = 250;
            dtg_lopKTV.Columns[5].Width = 145;

        }


    }
}
