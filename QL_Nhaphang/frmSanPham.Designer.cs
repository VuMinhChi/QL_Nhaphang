
namespace QL_Nhaphang
{
    partial class frmSanPham
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtKichthuoc = new System.Windows.Forms.TextBox();
            this.DSSanPham = new System.Windows.Forms.DataGridView();
            this.txtMaCanTim = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cbxMaBST = new System.Windows.Forms.ComboBox();
            this.cbxMaLoai = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(152, 41);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(210, 27);
            this.txtMa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã bộ sưu tập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hình ảnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kích thước";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Đơn giá";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(712, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sản phẩm";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(712, 13);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(250, 165);
            this.picAnh.TabIndex = 3;
            this.picAnh.TabStop = false;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(152, 81);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(210, 27);
            this.txtTen.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(152, 114);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(210, 27);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(152, 180);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(210, 27);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtKichthuoc
            // 
            this.txtKichthuoc.Location = new System.Drawing.Point(494, 110);
            this.txtKichthuoc.Name = "txtKichthuoc";
            this.txtKichthuoc.Size = new System.Drawing.Size(178, 27);
            this.txtKichthuoc.TabIndex = 1;
            // 
            // DSSanPham
            // 
            this.DSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSSanPham.Location = new System.Drawing.Point(44, 310);
            this.DSSanPham.Name = "DSSanPham";
            this.DSSanPham.RowHeadersWidth = 51;
            this.DSSanPham.RowTemplate.Height = 29;
            this.DSSanPham.Size = new System.Drawing.Size(957, 221);
            this.DSSanPham.TabIndex = 4;
            // 
            // txtMaCanTim
            // 
            this.txtMaCanTim.Location = new System.Drawing.Point(513, 201);
            this.txtMaCanTim.Name = "txtMaCanTim";
            this.txtMaCanTim.Size = new System.Drawing.Size(193, 27);
            this.txtMaCanTim.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(893, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "Đóng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbxMaBST
            // 
            this.cbxMaBST.FormattingEnabled = true;
            this.cbxMaBST.Location = new System.Drawing.Point(495, 150);
            this.cbxMaBST.Name = "cbxMaBST";
            this.cbxMaBST.Size = new System.Drawing.Size(177, 28);
            this.cbxMaBST.TabIndex = 6;
            // 
            // cbxMaLoai
            // 
            this.cbxMaLoai.FormattingEnabled = true;
            this.cbxMaLoai.Location = new System.Drawing.Point(152, 148);
            this.cbxMaLoai.Name = "cbxMaLoai";
            this.cbxMaLoai.Size = new System.Drawing.Size(210, 28);
            this.cbxMaLoai.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(494, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 29);
            this.button5.TabIndex = 0;
            this.button5.Text = "Thêm ảnh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 543);
            this.Controls.Add(this.cbxMaLoai);
            this.Controls.Add(this.cbxMaBST);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DSSanPham);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtKichthuoc);
            this.Controls.Add(this.txtMaCanTim);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmSanPham";
            this.Text = "Danh Mục Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtKichthuoc;
        private System.Windows.Forms.DataGridView DSSanPham;
        private System.Windows.Forms.TextBox txtMaCanTim;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cbxMaBST;
        private System.Windows.Forms.ComboBox cbxMaLoai;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}