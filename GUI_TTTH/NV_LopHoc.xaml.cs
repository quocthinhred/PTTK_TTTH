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
    /// Interaction logic for NV_LopHoc.xaml
    /// </summary>
    public partial class NV_LopHoc : Window
    {
        public NV_LopHoc()
        {
            InitializeComponent();
        }

        private void bt_LopKTV_Click(object sender, RoutedEventArgs e)
        {
            NV_LopKTV ktv = new NV_LopKTV();
            this.Hide();
            ktv.ShowDialog();
            this.ShowDialog();   
        }

        private void bt_LopCC_Click(object sender, RoutedEventArgs e)
        {
            NV_LopKTV chungchi = new NV_LopKTV();
            this.Hide();
            chungchi.ShowDialog();
            this.ShowDialog();
        }

        private void bt_LopCD_Click(object sender, RoutedEventArgs e)
        {
            NV_LopKTV chuyende = new NV_LopKTV();
            this.Hide();
            chuyende.ShowDialog();
            this.ShowDialog();
        }
    }
}
