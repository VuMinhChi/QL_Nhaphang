
using System;

namespace QL_Nhaphang
{
    partial class frmPhieuNhap
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
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DSPhieunhap = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMaCanTim = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhieunhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(166, 86);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(157, 28);
            this.cbxMaNV.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DSPhieunhap
            // 
            this.DSPhieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSPhieunhap.Location = new System.Drawing.Point(39, 324);
            this.DSPhieunhap.Name = "DSPhieunhap";
            this.DSPhieunhap.RowHeadersWidth = 51;
            this.DSPhieunhap.RowTemplate.Height = 29;
            this.DSPhieunhap.Size = new System.Drawing.Size(725, 171);
            this.DSPhieunhap.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(166, 51);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(157, 27);
            this.txtMa.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông tin chung";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtMaCanTim
            // 
            this.txtMaCanTim.Location = new System.Drawing.Point(166, 195);
            this.txtMaCanTim.Name = "txtMaCanTim";
            this.txtMaCanTim.Size = new System.Drawing.Size(189, 27);
            this.txtMaCanTim.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nhập mã cần tìm";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(614, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 499);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaCanTim);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DSPhieunhap);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuNhap";
            this.Text = "Danh mục phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSPhieunhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DSPhieunhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMaCanTim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}