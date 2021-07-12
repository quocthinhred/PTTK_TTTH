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
    /// Interaction logic for Course.xaml
    /// </summary>
    public partial class Course : Window
    {
        public Course()
        {
            InitializeComponent();
        }

        public Course(List<DTO_Khoa> Courses)
        {
            InitializeComponent();
            dtg_course.ItemsSource = Courses;
        }

        private void dtg_course_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_course.Columns[0].Width = 200;
            dtg_course.Columns[1].Width = (dtg_course.Width - 210) / 2; 
            dtg_course.Columns[2].Width = (dtg_course.Width - 210) / 2;
            dtg_course.RowHeight = 35;
            dtg_course.FontSize = 20;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
