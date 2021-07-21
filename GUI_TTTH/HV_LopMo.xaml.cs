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
    /// Interaction logic for HV_LopMo.xaml
    /// </summary>
    public partial class HV_LopMo : Window
    {
        string id2;
        public HV_LopMo()
        {
            InitializeComponent();
        }

        public HV_LopMo(string id)
        {
            id2 = id;
            InitializeComponent();
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_classKTV_Click(object sender, RoutedEventArgs e)
        {
            HV_LopKTV lopKTV = new HV_LopKTV(id2);
            this.Hide();
            lopKTV.ShowDialog();
            this.ShowDialog();
        }

        private void bt_classLCC_Click(object sender, RoutedEventArgs e)
        {
            HV_LopCC lopCC = new HV_LopCC(id2);
            this.Hide();
            lopCC.ShowDialog();
            this.ShowDialog();
        }

        private void bt_classLCD_Click(object sender, RoutedEventArgs e)
        {
            HV_LopCD lopCD = new HV_LopCD(id2);
            this.Hide();
            lopCD.ShowDialog();
            this.ShowDialog();
        }
    }
}
