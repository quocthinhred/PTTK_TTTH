
namespace GUI_TTTH
{
    partial class NV_AddCourse
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
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.bt_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Khoá";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // date_start
            // 
            this.date_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_start.Location = new System.Drawing.Point(61, 126);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(391, 30);
            this.date_start.TabIndex = 3;
            this.date_start.Value = new System.DateTime(2021, 7, 15, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày kết thúc";
            // 
            // date_end
            // 
            this.date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_end.Location = new System.Drawing.Point(61, 232);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(391, 30);
            this.date_end.TabIndex = 5;
            // 
            // bt_OK
            // 
            this.bt_OK.BackColor = System.Drawing.Color.Black;
            this.bt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OK.ForeColor = System.Drawing.Color.White;
            this.bt_OK.Location = new System.Drawing.Point(198, 338);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(114, 47);
            this.bt_OK.TabIndex = 7;
            this.bt_OK.Text = "Xác Nhận";
            this.bt_OK.UseVisualStyleBackColor = false;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // NV_AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 424);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.label1);
            this.Name = "NV_AddCourse";
            this.Text = "NV_AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.CenterToScreen();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Button bt_OK;
    }
}