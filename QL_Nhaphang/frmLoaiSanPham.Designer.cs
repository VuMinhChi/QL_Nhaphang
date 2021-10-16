
namespace QL_Nhaphang
{
    partial class frmLoaiSanPham
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
            this.DSLoaiSP = new System.Windows.Forms.DataGridView();
            this.txtMaL = new System.Windows.Forms.TextBox();
            this.txtTenL = new System.Windows.Forms.TextBox();
            this.txtMaCanTim = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DSLoaiSP
            // 
            this.DSLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSLoaiSP.Location = new System.Drawing.Point(34, 268);
            this.DSLoaiSP.Name = "DSLoaiSP";
            this.DSLoaiSP.RowHeadersWidth = 51;
            this.DSLoaiSP.RowTemplate.Height = 29;
            this.DSLoaiSP.Size = new System.Drawing.Size(733, 170);
            this.DSLoaiSP.TabIndex = 2;
            // 
            // txtMaL
            // 
            this.txtMaL.Location = new System.Drawing.Point(209, 29);
            this.txtMaL.Multiline = true;
            this.txtMaL.Name = "txtMaL";
            this.txtMaL.Size = new System.Drawing.Size(183, 27);
            this.txtMaL.TabIndex = 3;
            // 
            // txtTenL
            // 
            this.txtTenL.Location = new System.Drawing.Point(209, 69);
            this.txtTenL.Multiline = true;
            this.txtTenL.Name = "txtTenL";
            this.txtTenL.Size = new System.Drawing.Size(183, 27);
            this.txtTenL.TabIndex = 3;
            // 
            // txtMaCanTim
            // 
            this.txtMaCanTim.Location = new System.Drawing.Point(209, 131);
            this.txtMaCanTim.Multiline = true;
            this.txtMaCanTim.Name = "txtMaCanTim";
            this.txtMaCanTim.Size = new System.Drawing.Size(183, 27);
            this.txtMaCanTim.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(626, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 0;
            this.button5.Text = "Đóng";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã cần tìm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã loại sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaCanTim);
            this.Controls.Add(this.txtTenL);
            this.Controls.Add(this.txtMaL);
            this.Controls.Add(this.DSLoaiSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmLoaiSanPham";
            this.Text = "Danh mục loại sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiSanPham_FormClosing_1);
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DSLoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DSLoaiSP;
        private System.Windows.Forms.TextBox txtMaL;
        private System.Windows.Forms.TextBox txtTenL;
        private System.Windows.Forms.TextBox txtMaCanTim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}