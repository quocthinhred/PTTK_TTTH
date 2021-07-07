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
            List<DTO_HocVien> Students = new List<DTO_HocVien>();
        }
    }
}
