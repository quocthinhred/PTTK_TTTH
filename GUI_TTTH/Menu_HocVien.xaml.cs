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
    /// Interaction logic for Menu_HocVien.xaml
    /// </summary>

    public partial class Menu_HocVien : Window
    {
        string id2;
        public Menu_HocVien()
        {
            InitializeComponent();
        }

        public Menu_HocVien(string id)
        {
            InitializeComponent();
            id2 = id;
        }

        private void bt_schedule2_Click(object sender, RoutedEventArgs e)
        {
            LichHoc lichHoc = new LichHoc(id2);
            this.Hide();
            lichHoc.ShowDialog();
            this.ShowDialog();
        }

        private void bt_myclass_Click(object sender, RoutedEventArgs e)
        {
            LichDay lichDay = new LichDay(id2);
            this.Hide();
            lichDay.ShowDialog();
            this.ShowDialog();
        }

        private void bt_openclass_Click(object sender, RoutedEventArgs e)
        {
            LichDay lichDay = new LichDay(id2);
            this.Hide();
            lichDay.ShowDialog();
            this.ShowDialog();
        }
    }
}
