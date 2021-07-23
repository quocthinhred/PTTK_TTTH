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
    /// Interaction logic for GV_ChamDiemTN.xaml
    /// </summary>
    public partial class GV_ChamDiemTN : Window
    {
        string id2;
        public GV_ChamDiemTN()
        {
            InitializeComponent();
        }

        public GV_ChamDiemTN(string id)
        {
            id2 = id;
            InitializeComponent();
            BUS_ThanhTich.reload();
            List<DTO_HV_TN> hvtn = BUS_ThanhTich.achievements1;
            DTO_Khoa newCourse = BUS_Khoa.getNewCourse();
            for (int i = 0; i < hvtn.Count; i++ )
            {
                if (hvtn[i].ID_Course != newCourse.ID)
                {
                    hvtn.RemoveAt(i);
                    i--;
                }
            }
            dtg_HVTN.ItemsSource = hvtn;
        }
        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_update_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_HVTN.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng !!!");
            }
            else
            { 
                DTO_HV_TN student = (DTO_HV_TN)dtg_HVTN.SelectedItem;
                student.ID_Teacher = id2;
                MessageBox.Show(BUS_ThanhTich.updateGrade(student));
                BUS_ThanhTich.reload();
                List<DTO_HV_TN> hvtn = BUS_ThanhTich.achievements1;
                DTO_Khoa newCourse = BUS_Khoa.getNewCourse();
                for (int i = 0; i < hvtn.Count; i++)
                {
                    if (hvtn[i].ID_Course != newCourse.ID)
                    {
                        hvtn.RemoveAt(i);
                        i--;
                    }
                }
                dtg_HVTN.ItemsSource = hvtn;
                dtg_HVTN.Columns[0].Width = 150;
                dtg_HVTN.FontSize = 20;
                dtg_HVTN.RowHeight = 35;
                dtg_HVTN.Columns[1].Width = 100;
                dtg_HVTN.Columns[2].Width = 100;
                dtg_HVTN.Columns[3].Width = 150;
                dtg_HVTN.Columns[4].Width = 250;
                dtg_HVTN.Columns[5].Width = 150;
            }
            
        }

        private void dtg_HVTN_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_HVTN.Columns[0].Width = 150;
            dtg_HVTN.FontSize = 20;
            dtg_HVTN.RowHeight = 35;
            dtg_HVTN.Columns[1].Width = 100;
            dtg_HVTN.Columns[2].Width = 100;
            dtg_HVTN.Columns[3].Width = 150;
            dtg_HVTN.Columns[4].Width = 250;
            dtg_HVTN.Columns[5].Width = 150;
        }
    }
}
