namespace C_Sharp_banhcuuchuong
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.btnkq1 = new System.Windows.Forms.Button();
            this.lbsketqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng Cửu Chương";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(611, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bạn Muốn Xem Cửu Chương Mấy";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(244, 155);
            this.txtso1.Multiline = true;
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(197, 32);
            this.txtso1.TabIndex = 1;
            this.txtso1.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            // 
            // btnkq1
            // 
            this.btnkq1.Location = new System.Drawing.Point(467, 155);
            this.btnkq1.Name = "btnkq1";
            this.btnkq1.Size = new System.Drawing.Size(106, 32);
            this.btnkq1.TabIndex = 2;
            this.btnkq1.Text = "Xem Kết Qủa";
            this.btnkq1.UseVisualStyleBackColor = true;
            this.btnkq1.Click += new System.EventHandler(this.btnkq1_Click);
            // 
            // lbsketqua
            // 
            this.lbsketqua.FormattingEnabled = true;
            this.lbsketqua.Location = new System.Drawing.Point(244, 193);
            this.lbsketqua.Name = "lbsketqua";
            this.lbsketqua.Size = new System.Drawing.Size(329, 199);
            this.lbsketqua.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbsketqua);
            this.Controls.Add(this.btnkq1);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Button btnkq1;
        private System.Windows.Forms.ListBox lbsketqua;
    }
}

