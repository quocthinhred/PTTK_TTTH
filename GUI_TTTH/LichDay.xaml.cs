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
            List<DTO_LichHoc> schedules = new List<DTO_LichHoc>();
            schedules = BUS_LichHoc.getScheduleTeacher(id);
            if (schedules.Count > 0)
            {
                dtg_schedule.ItemsSource = schedules;
            }
        }

        private void dtg_schedule_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            

        }

        private void dtg_schedule_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_schedule.Columns[0].Width = 100;
            dtg_schedule.FontSize = 18;
            dtg_schedule.Columns[1].Width = 200;
            dtg_schedule.Columns[2].Width = dtg_schedule.Width - 310;
        }
    }
}
