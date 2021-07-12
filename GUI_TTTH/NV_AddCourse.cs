using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_TTTH;
using BUS_TTTH;

namespace GUI_TTTH
{
    public partial class NV_AddCourse : Form
    {
        public NV_AddCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            DTO_Khoa course = BUS_Khoa.getNewCourse();
            string newIDCourse = course.ID;
            string temp = newIDCourse.Substring(1);
            int intTemp = Int32.Parse(temp);
            intTemp++;
            temp = intTemp.ToString();
            newIDCourse = "K" + temp;
            string startDate = date_start.Value.ToString().Substring(0, date_start.Value.ToString().IndexOf(" "));
            string endDate = date_end.Value.ToString().Substring(0, date_end.Value.ToString().IndexOf(" "));
            DTO_Khoa newCourse = new DTO_Khoa(newIDCourse, startDate, endDate);
            List<DTO_Khoa> Courses = BUS_Khoa.addCourse(newCourse);
            MessageBox.Show("Thêm thành công!");
            Course MH_course = new Course(Courses);
            this.Close();
            MH_course.ShowDialog();
        }
    }
}
