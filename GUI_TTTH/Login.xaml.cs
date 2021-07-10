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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            DTO_Account account = BUS_Account.checkLogin(tb_username.Text, tb_password.Password);
            if (account == null)
            {
                MessageBox.Show("Có Con Cặc Mà Hack Được App Của Tui!");
            }
            else
            {
                if (account.Type == "1")
                {

                }
                else if (account.Type == "2")
                {
                    Menu_GiangVien giangVien = new Menu_GiangVien(tb_username.Text);
                    this.Hide();
                    giangVien.ShowDialog();
                    this.ShowDialog();
                }
                else
                {
                    Menu_HocVien hocVien = new Menu_HocVien(tb_username.Text);
                    this.Hide();
                    hocVien.ShowDialog();
                    this.ShowDialog();
                }
            }
        }
    }
}
