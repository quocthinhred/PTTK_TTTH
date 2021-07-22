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
    /// Interaction logic for NV_LopCC.xaml
    /// </summary>
    public partial class NV_LopCC : Window
    {
        DTO_LopCCMo LCCM = new DTO_LopCCMo();
        int status = 0;
        public NV_LopCC()
        {
            InitializeComponent();
            dtg_chungchi.ItemsSource = BUS_Lop.getLopCCMo();
            List<DTO_HocVien> Students = BUS_HocVien.getAllStudents();
            for (int i = 0; i < Students.Count; i++)
            {
                string item = Students[i].ID + " - " + Students[i].Name;
                cbb_student.Items.Add(item);
            }
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            if (status == 1)
            {
                status = 0;
                bt_off.Visibility = Visibility.Visible;
                bt_add.Visibility = Visibility.Visible;
                cbb_student.Visibility = Visibility.Hidden;
                bt_add.Content = "THÊM LỚP CC";
                lb_title.Content = "DANH SÁCH LỚP CHỨNG CHỈ MỞ";
                dtg_chungchi.ItemsSource = BUS_Lop.getLopCCMo();
                dtg_chungchi.Columns[0].Width = 100;
                dtg_chungchi.FontSize = 20;
                dtg_chungchi.RowHeight = 35;
                dtg_chungchi.Columns[1].Width = 250;
                dtg_chungchi.Columns[2].Width = 100;
                dtg_chungchi.Columns[3].Width = dtg_chungchi.Width - 675;
                dtg_chungchi.Columns[4].Width = 100;
                dtg_chungchi.Columns[5].Width = 100;
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
                NV_AddLCC add = new NV_AddLCC("LCC");
                add.ShowDialog();
                bt_off.Visibility = Visibility.Visible;
                bt_add.Visibility = Visibility.Visible;
                bt_add.Content = "THÊM LỚP CC";
                lb_title.Content = "DANH SÁCH LỚP CHỨNG CHỈ MỞ";
                dtg_chungchi.ItemsSource = BUS_Lop.getLopCCMo();
                dtg_chungchi.Columns[0].Width = 100;
                dtg_chungchi.FontSize = 20;
                dtg_chungchi.RowHeight = 35;
                dtg_chungchi.Columns[1].Width = 250;
                dtg_chungchi.Columns[2].Width = 100;
                dtg_chungchi.Columns[3].Width = dtg_chungchi.Width - 675;
                dtg_chungchi.Columns[4].Width = 100;
                dtg_chungchi.Columns[5].Width = 100;
            }
            else
            {
                if (cbb_student.Text != " ")
                {
                    string notifi = BUS_DangKyLopChungChi.addStudent(cbb_student.Text.Substring(0, cbb_student.Text.IndexOf(" ")), LCCM);
                    MessageBox.Show(notifi);
                    cbb_student.Visibility = Visibility.Visible;
                    bt_off.Visibility = Visibility.Hidden;
                    bt_add.Content = "THÊM HỌC VIÊN";
                    lb_title.Content = "DANH SÁCH HỌC VIÊN";
                    status = 1;
                    DTO_Lop Class = BUS_Lop.getClass(LCCM.ID, LCCM.ID_Course);
                    List<DTO_BangDiemHV> Students = BUS_BangDiemHV.GV_LopHoc(Class);
                    dtg_chungchi.ItemsSource = Students;
                    dtg_chungchi.Columns[0].Width = 150;
                    dtg_chungchi.Columns[1].Width = 300;
                    dtg_chungchi.Columns[2].Visibility = Visibility.Hidden;
                    dtg_chungchi.Columns[3].Visibility = Visibility.Hidden;
                    dtg_chungchi.Columns[4].Visibility = Visibility.Hidden;
                    dtg_chungchi.Columns[5].Width = 200;
                    dtg_chungchi.Columns[6].Width = dtg_chungchi.Width - 660;
                    dtg_chungchi.Columns[7].Visibility = Visibility.Hidden;
                    if (dtg_chungchi.Items.Count == 10)
                    {
                        cbb_student.Visibility = Visibility.Hidden;
                        bt_add.Visibility = Visibility.Hidden;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn Học viên!");
                }
            }
        }

        private void bt_on_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_off_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_chungchi.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                LCCM = (DTO_LopCCMo)dtg_chungchi.SelectedItem;
                string notifi = BUS_Lop.LCC_updateIsFull(LCCM);
                MessageBox.Show(notifi);
                dtg_chungchi.ItemsSource = BUS_Lop.getLopCCMo();
                dtg_chungchi.Columns[0].Width = 100;
                dtg_chungchi.FontSize = 20;
                dtg_chungchi.RowHeight = 35;
                dtg_chungchi.Columns[1].Width = 250;
                dtg_chungchi.Columns[2].Width = 100;
                dtg_chungchi.Columns[3].Width = dtg_chungchi.Width - 675;
                dtg_chungchi.Columns[4].Width = 100;
                dtg_chungchi.Columns[5].Width = 100;
            }
        }

        private void dtg_chungchi_Loaded_1(object sender, RoutedEventArgs e)
        {
            dtg_chungchi.Columns[0].Width = 100;
            dtg_chungchi.FontSize = 20;
            dtg_chungchi.RowHeight = 35;
            dtg_chungchi.Columns[1].Width = 250;
            dtg_chungchi.Columns[2].Width = 100;
            dtg_chungchi.Columns[3].Width = dtg_chungchi.Width - 675;
            dtg_chungchi.Columns[4].Width = 100;
            dtg_chungchi.Columns[5].Width = 100;
        }

        private void dtg_chungchi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (status == 0)
            {
                cbb_student.Visibility = Visibility.Visible;
                bt_off.Visibility = Visibility.Hidden;
                bt_add.Content = "THÊM HỌC VIÊN";
                lb_title.Content = "DANH SÁCH HỌC VIÊN";
                status = 1;
                LCCM = (DTO_LopCCMo)dtg_chungchi.SelectedItem;
                if (LCCM.IsFull == "1")
                {
                    cbb_student.Visibility = Visibility.Hidden;
                    bt_add.Visibility = Visibility.Hidden;
                }
                DTO_Lop Class = BUS_Lop.getClass(LCCM.ID, LCCM.ID_Course);
                List<DTO_BangDiemHV> Students = BUS_BangDiemHV.GV_LopHoc(Class);
                dtg_chungchi.ItemsSource = Students;
                dtg_chungchi.Columns[0].Width = 150;
                dtg_chungchi.Columns[1].Width = 300;
                dtg_chungchi.Columns[2].Visibility = Visibility.Hidden;
                dtg_chungchi.Columns[3].Visibility = Visibility.Hidden;
                dtg_chungchi.Columns[4].Visibility = Visibility.Hidden;
                dtg_chungchi.Columns[5].Width = 200;
                dtg_chungchi.Columns[6].Width = dtg_chungchi.Width - 660;
                dtg_chungchi.Columns[7].Visibility = Visibility.Hidden;
            }
            else
            {
                
            }
        }
    }
}
