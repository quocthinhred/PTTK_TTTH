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
    /// Interaction logic for NV_HocPhi.xaml
    /// </summary>
    public partial class NV_HocPhi : Window
    {
        public NV_HocPhi()
        {
            InitializeComponent();

        }

        private void dtb_fee_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HocPhi_KTV ktv = new HocPhi_KTV();
            this.Hide();
            ktv.ShowDialog();
            this.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HocPhi_LCC lcc = new HocPhi_LCC();
            this.Hide();
            lcc.ShowDialog();
            this.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HocPhi_LCD lcd = new HocPhi_LCD();
            this.Hide();
            lcd.ShowDialog();
            this.ShowDialog();
        }
    }
}
