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
    /// Interaction logic for NV_GiangVien.xaml
    /// </summary>
    public partial class NV_GiangVien : Window
    {
        public NV_GiangVien()
        {
            InitializeComponent();
            dtg_teacher.ItemsSource = BUS_GiangVien.AllTeachers;
        }



        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_teacher.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_GiangVien teacher = (DTO_GiangVien)dtg_teacher.SelectedItem;
                    string notifi = BUS_GiangVien.insertTeacher(teacher);
                    MessageBox.Show(notifi);
                    dtg_teacher.ItemsSource = null;
                    dtg_teacher.ItemsSource = BUS_GiangVien.AllTeachers;
                    dtg_teacher.Columns[0].Width = 100;
                    dtg_teacher.Columns[1].Width = 300;
                    dtg_teacher.Columns[2].Width = 200;
                    dtg_teacher.Columns[3].Width = dtg_teacher.Width - 625;
                    dtg_teacher.FontSize = 20;
                    dtg_teacher.RowHeight = 35;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void bt_edit_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_teacher.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_GiangVien teacher = (DTO_GiangVien)dtg_teacher.SelectedItem;
                    string notifi = BUS_GiangVien.updateTeacher(teacher);
                    MessageBox.Show(notifi);
                    dtg_teacher.ItemsSource = null;
                    List<DTO_GiangVien> Teachers = BUS_GiangVien.AllTeachers;
                    dtg_teacher.ItemsSource = Teachers;
                    dtg_teacher.Columns[0].Width = 100;
                    dtg_teacher.Columns[1].Width = 300;
                    dtg_teacher.Columns[2].Width = 200;
                    dtg_teacher.Columns[3].Width = dtg_teacher.Width - 625;
                    dtg_teacher.FontSize = 20;
                    dtg_teacher.RowHeight = 35;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void bt_delete_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_teacher.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_GiangVien teacher = (DTO_GiangVien)dtg_teacher.SelectedItem;
                    string notifi = BUS_GiangVien.deleteTeacher(teacher);
                    MessageBox.Show(notifi);
                    dtg_teacher.ItemsSource = null;
                    List<DTO_GiangVien> Teachers = BUS_GiangVien.AllTeachers;
                    for (int i = 0; i < Teachers.Count; i++)
                    {
                        if (teacher.ID == Teachers[i].ID)
                        {
                            Teachers.RemoveAt(i);
                            break;
                        }
                    }
                    dtg_teacher.ItemsSource = Teachers;
                    dtg_teacher.Columns[0].Width = 100;
                    dtg_teacher.Columns[1].Width = 300;
                    dtg_teacher.Columns[2].Width = 200;
                    dtg_teacher.Columns[3].Width = dtg_teacher.Width - 625;
                    dtg_teacher.FontSize = 20;
                    dtg_teacher.RowHeight = 35;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dtg_teacher_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_teacher.Columns[0].Width = 100;
            dtg_teacher.Columns[1].Width = 300;
            dtg_teacher.Columns[2].Width = 200;
            dtg_teacher.Columns[3].Width = dtg_teacher.Width - 625;
            dtg_teacher.FontSize = 20;
            dtg_teacher.RowHeight = 35;
        }
    }
}
