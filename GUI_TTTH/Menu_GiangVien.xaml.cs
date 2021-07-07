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

namespace GUI_TTTH
{
    /// <summary>
    /// Interaction logic for Menu_GiangVien.xaml
    /// </summary>
    public partial class Menu_GiangVien : Window
    {
        string id2;
        public Menu_GiangVien()
        {
            InitializeComponent();
        }

        public Menu_GiangVien(string id)
        {
            InitializeComponent();
            id2 = id;
        }

        private void bt_schedule_Click(object sender, RoutedEventArgs e)
        {
            LichDay lichDay = new LichDay(id2);
            this.Hide();
            lichDay.ShowDialog();
            this.ShowDialog();
        }

        private void bt_class_Click(object sender, RoutedEventArgs e)
        {
            GV_LopHoc lop = new GV_LopHoc(id2);
            this.Hide();
            lop.ShowDialog();
            this.ShowDialog();
        }
    }
}
