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
    /// Interaction logic for LichHoc.xaml
    /// </summary>
    public partial class LichHoc : Window
    {
        public LichHoc()
        {
            InitializeComponent();
        }

        public LichHoc(string id)
        {
            InitializeComponent();
            List<DTO_Lop> schedules = new List<DTO_Lop>();
            schedules = BUS_Lop.getScheduleStudent(id);

            dtg_schedule.ItemsSource = schedules;

            DTO_Khoa course = new DTO_Khoa();
            course = BUS_Khoa.getNewCourse();
            tb_course.Text = tb_course.Text + course.ID;
            tb_time.Text = tb_time.Text + course.StartDate + " - " + course.EndDate;
        }

        private void dtg_schedule_Loaded(object sender, RoutedEventArgs e)
        {

            dtg_schedule.Columns[0].Width = 100;
            dtg_schedule.FontSize = 20;
            dtg_schedule.RowHeight = 35;
            dtg_schedule.Columns[1].Width = 200;
            dtg_schedule.Columns[3].Width = dtg_schedule.Width - 310;
            dtg_schedule.Columns[2].Visibility = Visibility.Hidden;
            dtg_schedule.Columns[4].Visibility = Visibility.Hidden;

        }
    }
}
