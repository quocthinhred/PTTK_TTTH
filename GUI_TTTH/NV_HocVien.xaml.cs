﻿using System;
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
    /// Interaction logic for NV_HocVien.xaml
    /// </summary>
    public partial class NV_HocVien : Window
    {
        public NV_HocVien()
        {
            InitializeComponent();
            dtg_student.ItemsSource = BUS_HocVien.AllStudents;
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dtg_student_Loaded(object sender, RoutedEventArgs e)
        {
            dtg_student.Columns[0].Width = 100;
            dtg_student.Columns[1].Width = 300;
            dtg_student.Columns[2].Width = 200;
            dtg_student.Columns[3].Width = dtg_student.Width - 625;
            dtg_student.FontSize = 20;
            dtg_student.RowHeight = 35;
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_student.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_HocVien student = (DTO_HocVien)dtg_student.SelectedItem;
                    string notifi = BUS_HocVien.insertStudent(student);
                    MessageBox.Show(notifi);
                    dtg_student.ItemsSource = null;
                    dtg_student.ItemsSource = BUS_HocVien.AllStudents;
                    dtg_student.Columns[0].Width = 100;
                    dtg_student.Columns[1].Width = 300;
                    dtg_student.Columns[2].Width = 200;
                    dtg_student.Columns[3].Width = dtg_student.Width - 625;
                    dtg_student.FontSize = 20;
                    dtg_student.RowHeight = 35;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void bt_delete_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_student.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_HocVien student = (DTO_HocVien)dtg_student.SelectedItem;
                    string notifi = BUS_HocVien.deleteStudent(student);
                    MessageBox.Show(notifi);
                    List<DTO_HocVien> students = BUS_HocVien.AllStudents;
                    for (int i = 0; i < students.Count; i++)
                    {
                        if (student.ID == students[i].ID)
                        {
                            students.RemoveAt(i);
                            break;
                        }
                    }
                    dtg_student.ItemsSource = null;
                    dtg_student.ItemsSource = students;
                    dtg_student.Columns[0].Width = 100;
                    dtg_student.Columns[1].Width = 300;
                    dtg_student.Columns[2].Width = 200;
                    dtg_student.Columns[3].Width = dtg_student.Width - 625;
                    dtg_student.FontSize = 20;
                    dtg_student.RowHeight = 35;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void bt_edit_Click(object sender, RoutedEventArgs e)
        {
            if (dtg_student.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
            }
            else
            {
                try
                {
                    DTO_HocVien student = (DTO_HocVien)dtg_student.SelectedItem;
                    string notifi = BUS_HocVien.updateStudent(student);
                    MessageBox.Show(notifi);
                    List<DTO_HocVien> students = BUS_HocVien.AllStudents;
                    dtg_student.ItemsSource = null;
                    dtg_student.ItemsSource = students;
                    dtg_student.Columns[0].Width = 100;
                    dtg_student.Columns[1].Width = 300;
                    dtg_student.Columns[2].Width = 200;
                    dtg_student.Columns[3].Width = dtg_student.Width - 625;
                    dtg_student.FontSize = 20;
                    dtg_student.RowHeight = 35;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}
