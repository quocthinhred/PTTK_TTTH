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
    /// Interaction logic for Menu_NhanVien.xaml
    /// </summary>
    public partial class Menu_NhanVien : Window
    {
        public Menu_NhanVien()
        {
            InitializeComponent();
        }

        private void bt_student_Click(object sender, RoutedEventArgs e)
        {
            NV_HocVien student = new NV_HocVien();
            this.Hide();
            student.ShowDialog();
            this.ShowDialog();
        }

        private void bt_teacher_Click(object sender, RoutedEventArgs e)
        {
            NV_GiangVien teacher = new NV_GiangVien();
            this.Hide();
            teacher.ShowDialog();
            this.ShowDialog();
        }

        private void bt_class_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
