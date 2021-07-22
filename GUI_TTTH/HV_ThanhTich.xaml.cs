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
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void dtg_lopKTV_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void dtg_lopCC_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void dtg_lopCD_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void bt_register_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
