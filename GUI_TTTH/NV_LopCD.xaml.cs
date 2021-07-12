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
    /// Interaction logic for NV_LopCD.xaml
    /// </summary>
    public partial class NV_LopCD : Window
    {
        int status = 0;
        DTO_LopCDMo LCDM = new DTO_LopCDMo();
        public NV_LopCD()
        {
            InitializeComponent();
            dtg_chuyende.ItemsSource = BUS_Lop.getLopCDMo();
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
                bt_add.Content = "THÊM LỚP CC";
                lb_title.Content = "DANH SÁCH LỚP CHỨNG CHỈ MỞ";
                dtg_chuyende.ItemsSource = BUS_Lop.getLopCDMo();
                dtg_chuyende.Columns[0].Width = 100;
                dtg_chuyende.FontSize = 20;
                dtg_chuyende.RowHeight = 35;
                dtg_chuyende.Columns[1].Width = 250;
                dtg_chuyende.Columns[2].Width = 100;
                dtg_chuyende.Columns[3].Width = dtg_chuyende.Width - 675;
                dtg_chuyende.Columns[4].Width = 100;
                dtg_chuyende.Columns[5].Width = 100;
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
                NV_AddLCC add = new NV_AddLCC();
                add.ShowDialog();
                bt_off.Visibility = Visibility.Visible;
                bt_add.Visibility = Visibility.Visible;
                bt_add.Content = "THÊM LỚP CC";
                lb_title.Content = "DANH SÁCH LỚP CHỨNG CHỈ MỞ";
                dtg_chuyende.ItemsSource = BUS_Lop.getLopCDMo();
                dtg_chuyende.Columns[0].Width = 100;
                dtg_chuyende.FontSize = 20;
                dtg_chuyende.RowHeight = 35;
                dtg_chuyende.Columns[1].Width = 250;
                dtg_chuyende.Columns[2].Width = 100;
                dtg_chuyende.Columns[3].Width = dtg_chuyende.Width - 675;
                dtg_chuyende.Columns[4].Width = 100;
                dtg_chuyende.Columns[5].Width = 100;
            }
            else
            {
                if (cbb_student.Text != " ")
                {
                    string notifi = BUS_DangKyLopChuyenDe.addStudent(cbb_student.Text.Substring(0, cbb_student.Text.IndexOf(" ")), LCDM);
                    MessageBox.Show(notifi);
                    cbb_student.Visibility = Visibility.Visible;
                    bt_off.Visibility = Visibility.Hidden;
                    bt_add.Content = "THÊM HỌC VIÊN";
                    lb_title.Content = "DANH SÁCH HỌC VIÊN";
                    status = 1;
                    DTO_Lop Class = BUS_Lop.getClass(LCDM.ID, LCDM.ID_Course);
                    List<DTO_BangDiemHV> Students = BUS_BangDiemHV.GV_LopHoc(Class);
                    dtg_chuyende.ItemsSource = Students;
                    dtg_chuyende.Columns[0].Width = 150;
                    dtg_chuyende.Columns[1].Width = 300;
                    dtg_chuyende.Columns[2].Visibility = Visibility.Hidden;
                    dtg_chuyende.Columns[3].Visibility = Visibility.Hidden;
                    dtg_chuyende.Columns[4].Visibility = Visibility.Hidden;
                    dtg_chuyende.Columns[5].Width = 200;
                    dtg_chuyende.Columns[6].Width = dtg_chuyende.Width - 660;
                    dtg_chuyende.Columns[7].Visibility = Visibility.Hidden;
                    if (dtg_chuyende.Items.Count == 10)
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
            if (dtg_chuyende.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                LCDM = (DTO_LopCDMo)dtg_chuyende.SelectedItem;
                string notifi = BUS_Lop.LCD_updateIsFull(LCDM);
                MessageBox.Show(notifi);
                dtg_chuyende.ItemsSource = BUS_Lop.getLopCDMo();
                dtg_chuyende.Columns[0].Width = 100;
                dtg_chuyende.FontSize = 20;
                dtg_chuyende.RowHeight = 35;
                dtg_chuyende.Columns[1].Width = 250;
                dtg_chuyende.Columns[2].Width = 100;
                dtg_chuyende.Columns[3].Width = dtg_chuyende.Width - 675;
                dtg_chuyende.Columns[4].Width = 100;
                dtg_chuyende.Columns[5].Width = 100;
            }
        }

        private void dtg_chuyende_Loaded_1(object sender, RoutedEventArgs e)
        {
            dtg_chuyende.Columns[0].Width = 100;
            dtg_chuyende.FontSize = 20;
            dtg_chuyende.RowHeight = 35;
            dtg_chuyende.Columns[1].Width = 250;
            dtg_chuyende.Columns[2].Width = 100;
            dtg_chuyende.Columns[3].Width = dtg_chuyende.Width - 675;
            dtg_chuyende.Columns[4].Width = 100;
            dtg_chuyende.Columns[5].Width = 100;
        }

        private void dtg_chuyende_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (status == 0)
            {
                cbb_student.Visibility = Visibility.Visible;
                bt_off.Visibility = Visibility.Hidden;
                bt_add.Content = "THÊM HỌC VIÊN";
                lb_title.Content = "DANH SÁCH HỌC VIÊN";
                status = 1;
                LCDM = (DTO_LopCDMo)dtg_chuyende.SelectedItem;
                if (LCDM.IsFull == "1")
                {
                    cbb_student.Visibility = Visibility.Hidden;
                    bt_add.Visibility = Visibility.Hidden;
                }
                DTO_Lop Class = BUS_Lop.getClass(LCDM.ID, LCDM.ID_Course);
                List<DTO_BangDiemHV> Students = BUS_BangDiemHV.GV_LopHoc(Class);
                dtg_chuyende.ItemsSource = Students;
                dtg_chuyende.Columns[0].Width = 150;
                dtg_chuyende.Columns[1].Width = 300;
                dtg_chuyende.Columns[2].Visibility = Visibility.Hidden;
                dtg_chuyende.Columns[3].Visibility = Visibility.Hidden;
                dtg_chuyende.Columns[4].Visibility = Visibility.Hidden;
                dtg_chuyende.Columns[5].Width = 200;
                dtg_chuyende.Columns[6].Width = dtg_chuyende.Width - 660;
                dtg_chuyende.Columns[7].Visibility = Visibility.Hidden;
            }
            else
            {

            }
        }
    }
}
