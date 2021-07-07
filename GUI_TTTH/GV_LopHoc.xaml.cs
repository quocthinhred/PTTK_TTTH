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
    /// Interaction logic for GV_LopHoc.xaml
    /// </summary>
    public partial class GV_LopHoc : Window
    {
        public GV_LopHoc()
        {
            InitializeComponent();
        }

        public GV_LopHoc(string id)
        {
            InitializeComponent();
            List<DTO_Lop> Classes = new List<DTO_Lop>();
            Classes = BUS_Lop.getClassesTeacher(id);
            dtg_class.ItemsSource = Classes;
        }

        private void dtg_class_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_class.Columns[0].Width = 100;
            dtg_class.FontSize = 20;
            dtg_class.Columns[1].Width = 200;
            dtg_class.Columns[2].Width = 150;
            dtg_class.Columns[3].Width = dtg_class.Width - 460;
            dtg_class.Columns[4].Visibility = Visibility.Hidden;
            dtg_class.RowHeight = 35;
            
        }
    }
}
