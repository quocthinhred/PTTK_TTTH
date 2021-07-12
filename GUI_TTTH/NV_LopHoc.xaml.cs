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
using Microsoft.VisualBasic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DTO_TTTH;
using BUS_TTTH;

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
            NV_LopCC chungchi = new NV_LopCC();
            this.Hide();
            chungchi.ShowDialog();
            this.ShowDialog();
        }

        private void bt_LopCD_Click(object sender, RoutedEventArgs e)
        {
            NV_LopCD chuyende = new NV_LopCD();
            this.Hide();
            chuyende.ShowDialog();
            this.ShowDialog();
        }

        private void bt_addCourse_Click(object sender, RoutedEventArgs e)
        {
            NV_AddCourse add = new NV_AddCourse();
            add.ShowDialog();
        }

        private void bt_fee_Click(object sender, RoutedEventArgs e)
        {
            NV_HocPhi fee = new NV_HocPhi();
            this.Hide();
            fee.ShowDialog();
            this.ShowDialog();
        }


    }
}
