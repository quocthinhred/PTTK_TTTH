
namespace GUI_TTTH
{
    partial class NV_ThemNHP
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
            this.cbb_nhp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbb_nhp
            // 
            this.cbb_nhp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nhp.FormattingEnabled = true;
            this.cbb_nhp.Location = new System.Drawing.Point(118, 131);
            this.cbb_nhp.Name = "cbb_nhp";
            this.cbb_nhp.Size = new System.Drawing.Size(320, 33);
            this.cbb_nhp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM NHPM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.BackColor = System.Drawing.Color.Black;
            this.bt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OK.ForeColor = System.Drawing.Color.White;
            this.bt_OK.Location = new System.Drawing.Point(206, 222);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(151, 45);
            this.bt_OK.TabIndex = 2;
            this.bt_OK.Text = "Xác Nhận";
            this.bt_OK.UseVisualStyleBackColor = false;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // NV_ThemNHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 322);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_nhp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NV_ThemNHP";
            this.Text = "NV_ThemNHP";
            
            this.ResumeLayout(false);
            this.PerformLayout();
            this.CenterToScreen();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_nhp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_OK;
    }
}