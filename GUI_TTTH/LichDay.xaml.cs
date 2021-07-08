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
using BUS_TTTH;
using DTO_TTTH;

namespace GUI_TTTH
{
    /// <summary>
    /// Interaction logic for LichDay.xaml
    /// </summary>
    public partial class LichDay : Window
    {
        public LichDay()
        {
            InitializeComponent();
        }

        public LichDay(string id)
        {
            InitializeComponent();
            List<DTO_Lop> schedules = new List<DTO_Lop>();
            schedules = BUS_Lop.getScheduleTeacher(id);
            if (schedules.Count > 0)
            {
                dtg_schedule.ItemsSource = schedules;
            }
            DTO_Khoa course = new DTO_Khoa();
            course = BUS_Khoa.getNewCourse();
            tb_course.Text = tb_course.Text + course.ID;
            tb_time.Text = tb_time.Text + course.StartDate.Substring(0, course.StartDate.IndexOf(" ")) + " - " + course.EndDate.Substring(0, course.EndDate.IndexOf(" "));
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
