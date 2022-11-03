namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtSothu1 = new System.Windows.Forms.TextBox();
            this.txtSoThu2 = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Toán";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // lbKetQua
            // 
            this.lbKetQua.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbKetQua.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKetQua.Location = new System.Drawing.Point(337, 238);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(215, 35);
            this.lbKetQua.TabIndex = 4;
            // 
            // txtSothu1
            // 
            this.txtSothu1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSothu1.Location = new System.Drawing.Point(337, 121);
            this.txtSothu1.Multiline = true;
            this.txtSothu1.Name = "txtSothu1";
            this.txtSothu1.Size = new System.Drawing.Size(215, 34);
            this.txtSothu1.TabIndex = 5;
            // 
            // txtSoThu2
            // 
            this.txtSoThu2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoThu2.Location = new System.Drawing.Point(337, 177);
            this.txtSoThu2.Multiline = true;
            this.txtSoThu2.Name = "txtSoThu2";
            this.txtSoThu2.Size = new System.Drawing.Size(215, 34);
            this.txtSoThu2.TabIndex = 6;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCong.Location = new System.Drawing.Point(589, 316);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(96, 77);
            this.btCong.TabIndex = 7;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtSoThu2);
            this.Controls.Add(this.txtSothu1);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbKetQua;
        private TextBox txtSothu1;
        private TextBox txtSoThu2;
        private Button btCong;
    }
}