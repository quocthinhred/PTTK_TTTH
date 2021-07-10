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
    /// Interaction logic for HV_BangDiem.xaml
    /// </summary>
    public partial class HV_BangDiem : Window
    {
        string id2;
        public HV_BangDiem()
        {
            InitializeComponent();
        }

        public HV_BangDiem(string id)
        {
            id2 = id;
            InitializeComponent();
            List<DTO_BangDiemHV> Classes = new List<DTO_BangDiemHV>();
            Classes = BUS_BangDiemHV.getListGradeTable(id);
            dtg_class.ItemsSource = Classes;
        }

        private void dtg_class_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_class.Columns[0].Visibility = Visibility.Hidden;
            dtg_class.Columns[1].Visibility = Visibility.Hidden;
            dtg_class.Columns[2].Width = 100;
            dtg_class.Columns[3].Width = 200;
            dtg_class.Columns[4].Width = 150;
            dtg_class.Columns[5].Width = 150;
            dtg_class.Columns[6].Width = 150;
            dtg_class.Columns[7].Width = dtg_class.Width - 770;
            dtg_class.FontSize = 20;
            dtg_class.RowHeight = 35;
        }



        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
