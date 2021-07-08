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
using DTO_TTTH;
using BUS_TTTH;

namespace GUI_TTTH
{
    /// <summary>
    /// Interaction logic for GV_LopHoc.xaml
    /// </summary>
    public partial class GV_LopHoc : Window
    {
        int status = 0;
        string id2;
        string id_student;
        string id_class;
        public GV_LopHoc()
        {
            InitializeComponent();
        }

        public GV_LopHoc(string id)
        {
            id2 = id;
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

        private void dtg_class_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (status == 0)
            {
                status = 1;
                DTO_Lop Class = (DTO_Lop)dtg_class.SelectedItem;
                id_class = Class.ID_Class;
                List<DTO_HocVien> Students = BUS_HocVien.GV_LopHoc(Class);
                dtg_class.ItemsSource = Students;
                dtg_class.Columns[0].Width = 100;
                dtg_class.Columns[1].Width = 200;
                dtg_class.Columns[2].Width = 150;
                dtg_class.Columns[3].Width = dtg_class.Width - 465;
            }
            else
            {
                status = 0;
                DTO_HocVien student = (DTO_HocVien)dtg_class.SelectedItem;
                id_student = student.ID;
                GV_BangDiem table = new GV_BangDiem();
                this.Hide();
                table.ShowDialog();
                this.ShowDialog();
            }
        }

        private void bt_back_Click(object sender, RoutedEventArgs e)
        {
            if (status == 1)
            {
                List<DTO_Lop> Classes = new List<DTO_Lop>();
                Classes = BUS_Lop.getClassesTeacher(id2);
                dtg_class.ItemsSource = Classes;
                
                dtg_class.Columns[0].Width = 100;
                dtg_class.Columns[1].Width = 200;
                dtg_class.Columns[2].Width = 150;
                dtg_class.Columns[3].Width = dtg_class.Width - 460;
                dtg_class.Columns[4].Visibility = Visibility.Hidden;

                status = 0;
            }
            else
            {
                this.Close();
            }
        }
    }
}
