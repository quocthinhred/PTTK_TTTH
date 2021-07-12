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
    /// Interaction logic for NV_LopKTV.xaml
    /// </summary>
    public partial class NV_LopKTV : Window
    {
        DTO_NHPMo ClassNHP = new DTO_NHPMo();
        int status = 0;
        public NV_LopKTV()
        {
            InitializeComponent();
            List<DTO_NHPMo> L_NHPM = BUS_NHPMo.getNHPM();
            dtg_NHP.ItemsSource = L_NHPM;
            List<DTO_HocVien> Students = BUS_HocVien.getAllStudents();
            for (int i = 0; i < Students.Count; i++)
            {
                string item = Students[i].ID + " - " + Students[i].Name;
                cbb_student.Items.Add(item);
            }
        }

        private void dtg_NHP_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_NHP.Columns[0].Width = 200;
            dtg_NHP.FontSize = 20;
            dtg_NHP.RowHeight = 35;
            dtg_NHP.Columns[1].Width = 400;
            dtg_NHP.Columns[2].Width = dtg_NHP.Width - 720;
            dtg_NHP.Columns[3].Width = 100;
        }

        private void dtg_NHP_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            if (status == 0)
            {
                cbb_student.Visibility = Visibility.Visible;
                bt_off.Visibility = Visibility.Hidden;
                bt_add.Content = "THÊM HỌC VIÊN";
                lb_title.Content = "DANH SÁCH LỚP";
                status = 1;
                ClassNHP = (DTO_NHPMo)dtg_NHP.SelectedItem;
                if (ClassNHP.IsFull == "1")
                {
                    cbb_student.Visibility = Visibility.Hidden;
                    bt_add.Visibility = Visibility.Hidden;
                }
                dtg_NHP.ItemsSource = BUS_Lop.getLopKTV(ClassNHP);
                dtg_NHP.Columns[0].Width = 100;
                dtg_NHP.FontSize = 20;
                dtg_NHP.Columns[1].Width = 200;
                dtg_NHP.Columns[2].Width = 150;
                dtg_NHP.Columns[3].Width = dtg_NHP.Width - 610;
                dtg_NHP.Columns[4].Width = 150;
                dtg_NHP.RowHeight = 35;
            }
            else if (status == 1)
            {
                cbb_student.Visibility = Visibility.Hidden;
                bt_add.Visibility = Visibility.Hidden;
                bt_off.Visibility = Visibility.Hidden;
                lb_title.Content = "DANH SÁCH HỌC VIÊN";
                status = 2;
                DTO_Lop Class = (DTO_Lop)dtg_NHP.SelectedItem;
                List<DTO_BangDiemHV> Students = BUS_BangDiemHV.GV_LopHoc(Class);
                dtg_NHP.ItemsSource = Students;
                dtg_NHP.Columns[0].Width = 150;
                dtg_NHP.Columns[1].Width = 300;
                dtg_NHP.Columns[2].Visibility = Visibility.Hidden;
                dtg_NHP.Columns[3].Visibility = Visibility.Hidden;
                dtg_NHP.Columns[4].Visibility = Visibility.Hidden;
                dtg_NHP.Columns[5].Width = 200;
                dtg_NHP.Columns[6].Width = dtg_NHP.Width - 660;
                dtg_NHP.Columns[7].Visibility = Visibility.Hidden;
            }
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            if  (status == 1)
            {
                cbb_student.Visibility = Visibility.Hidden;
                bt_add.Visibility = Visibility.Visible;
                bt_off.Visibility = Visibility.Visible;
                bt_add.Content = "THÊM NHPM";
                lb_title.Content = "DANH SÁCH NHÓM HỌC PHẦN MỞ";
                status = 0;
                List<DTO_NHPMo> L_NHPM = BUS_NHPMo.getNHPM();
                dtg_NHP.ItemsSource = L_NHPM;
                dtg_NHP.Columns[0].Width = 200;
                dtg_NHP.FontSize = 20;
                dtg_NHP.RowHeight = 35;
                dtg_NHP.Columns[1].Width = 400;
                dtg_NHP.Columns[2].Width = dtg_NHP.Width - 720;
                dtg_NHP.Columns[3].Width = 100;
            }
            else if (status == 2)
            {
                cbb_student.Visibility = Visibility.Visible;
                bt_add.Visibility = Visibility.Visible;
                lb_title.Content = "DANH SÁCH LỚP";
                status = 1;
                dtg_NHP.ItemsSource = BUS_Lop.getLopKTV(ClassNHP);
                dtg_NHP.Columns[0].Width = 100;
                dtg_NHP.FontSize = 20;
                dtg_NHP.Columns[1].Width = 200;
                dtg_NHP.Columns[2].Width = 150;
                dtg_NHP.Columns[3].Width = dtg_NHP.Width - 610;
                dtg_NHP.Columns[4].Width = 150;
                dtg_NHP.RowHeight = 35;
            }
            else
            {
                this.Close();
            }
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            if (status == 0)
            {
                NV_ThemNHP add = new NV_ThemNHP();
                add.ShowDialog();
                List<DTO_NHPMo> L_NHPM = BUS_NHPMo.getNHPM();
                dtg_NHP.ItemsSource = L_NHPM;
                dtg_NHP.Columns[0].Width = 200;
                dtg_NHP.FontSize = 20;
                dtg_NHP.RowHeight = 35;
                dtg_NHP.Columns[1].Width = 400;
                dtg_NHP.Columns[2].Width = dtg_NHP.Width - 720;
                dtg_NHP.Columns[3].Width = 100;
            }
            else
            {
                if (cbb_student.Text != " ")
                {
                    string notifi = BUS_DangKyNHP.addDKNHP(cbb_student.Text.Substring(0, cbb_student.Text.IndexOf(" ")), ClassNHP);
                    MessageBox.Show(notifi);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn Học viên!");
                }
            }
        }

        private void bt_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_off_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_NHP.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                DTO_NHPMo NHPM = (DTO_NHPMo)dtg_NHP.SelectedItem;
                string notifi = BUS_NHPMo.updateIsFull(NHPM);
                MessageBox.Show(notifi);
                List<DTO_NHPMo> L_NHPM = BUS_NHPMo.getNHPM();
                dtg_NHP.ItemsSource = L_NHPM;
                dtg_NHP.Columns[0].Width = 200;
                dtg_NHP.FontSize = 20;
                dtg_NHP.RowHeight = 35;
                dtg_NHP.Columns[1].Width = 400;
                dtg_NHP.Columns[2].Width = dtg_NHP.Width - 720;
                dtg_NHP.Columns[3].Width = 100;
            }   
        }
    }
}
