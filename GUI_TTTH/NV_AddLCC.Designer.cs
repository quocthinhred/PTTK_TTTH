
namespace GUI_TTTH
{
    partial class NV_AddLCC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_id = new System.Windows.Forms.ComboBox();
            this.tb_course = new System.Windows.Forms.TextBox();
            this.tb_schedule = new System.Windows.Forms.TextBox();
            this.cbb_teacher = new System.Windows.Forms.ComboBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Lớp Chứng Chỉ";
            // 
            // cbb_id
            // 
            this.cbb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_id.FormattingEnabled = true;
            this.cbb_id.Location = new System.Drawing.Point(107, 159);
            this.cbb_id.Name = "cbb_id";
            this.cbb_id.Size = new System.Drawing.Size(397, 33);
            this.cbb_id.TabIndex = 1;
            this.cbb_id.SelectedIndexChanged += new System.EventHandler(this.cbb_id_SelectedIndexChanged);
            // 
            // tb_course
            // 
            this.tb_course.BackColor = System.Drawing.Color.White;
            this.tb_course.Enabled = false;
            this.tb_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course.Location = new System.Drawing.Point(107, 338);
            this.tb_course.Name = "tb_course";
            this.tb_course.ReadOnly = true;
            this.tb_course.Size = new System.Drawing.Size(397, 30);
            this.tb_course.TabIndex = 2;
            this.tb_course.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_schedule
            // 
            this.tb_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_schedule.Location = new System.Drawing.Point(107, 518);
            this.tb_schedule.Name = "tb_schedule";
            this.tb_schedule.Size = new System.Drawing.Size(397, 30);
            this.tb_schedule.TabIndex = 3;
            this.tb_schedule.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbb_teacher
            // 
            this.cbb_teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_teacher.FormattingEnabled = true;
            this.cbb_teacher.Location = new System.Drawing.Point(107, 429);
            this.cbb_teacher.Name = "cbb_teacher";
            this.cbb_teacher.Size = new System.Drawing.Size(397, 33);
            this.cbb_teacher.TabIndex = 4;
            // 
            // bt_OK
            // 
            this.bt_OK.BackColor = System.Drawing.Color.Black;
            this.bt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OK.ForeColor = System.Drawing.Color.White;
            this.bt_OK.Location = new System.Drawing.Point(229, 592);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(121, 49);
            this.bt_OK.TabIndex = 5;
            this.bt_OK.Text = "Xác Nhận";
            this.bt_OK.UseVisualStyleBackColor = false;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã LCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Khoá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã GV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lịch Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên LCC";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.Enabled = false;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(107, 250);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(397, 30);
            this.tb_name.TabIndex = 10;
            // 
            // NV_AddLCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.cbb_teacher);
            this.Controls.Add(this.tb_schedule);
            this.Controls.Add(this.tb_course);
            this.Controls.Add(this.cbb_id);
            this.Controls.Add(this.label1);
            this.Name = "NV_AddLCC";
            this.Text = "NV_AddLCC";
            this.ResumeLayout(false);
            this.PerformLayout();
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_id;
        private System.Windows.Forms.TextBox tb_course;
        private System.Windows.Forms.TextBox tb_schedule;
        private System.Windows.Forms.ComboBox cbb_teacher;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name;
    }
}