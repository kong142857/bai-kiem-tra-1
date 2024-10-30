namespace bai_kiem_tra_1
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
            lblAnhsanpham = new Label();
            pictureBox1 = new PictureBox();
            txtSoluong = new TextBox();
            lblSoluong = new Label();
            txtGia = new TextBox();
            lblGia = new Label();
            txtTensanpham = new TextBox();
            lblTensanpham = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridViewProduct = new DataGridView();
            btnThemvaogiohang = new Button();
            btnXoakhoigiohang = new Button();
            groupBox2 = new GroupBox();
            lblTongtien = new Label();
            txtTongtien = new TextBox();
            txtThanhtoan = new Button();
            dataGridViewCart = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // lblAnhsanpham
            // 
            lblAnhsanpham.AutoSize = true;
            lblAnhsanpham.Location = new Point(18, 116);
            lblAnhsanpham.Name = "lblAnhsanpham";
            lblAnhsanpham.Size = new Size(87, 15);
            lblAnhsanpham.TabIndex = 7;
            lblAnhsanpham.Text = "Anh san pham:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.d422ac04be270de2755a90c2f99213d3;
            pictureBox1.Location = new Point(124, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(354, 113);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(100, 23);
            txtSoluong.TabIndex = 5;
            // 
            // lblSoluong
            // 
            lblSoluong.AutoSize = true;
            lblSoluong.Location = new Point(272, 116);
            lblSoluong.Name = "lblSoluong";
            lblSoluong.Size = new Size(57, 15);
            lblSoluong.TabIndex = 4;
            lblSoluong.Text = "So luong:";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(354, 44);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(100, 23);
            txtGia.TabIndex = 3;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(302, 47);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(27, 15);
            lblGia.TabIndex = 2;
            lblGia.Text = "Gia:";
            // 
            // txtTensanpham
            // 
            txtTensanpham.Location = new Point(124, 44);
            txtTensanpham.Name = "txtTensanpham";
            txtTensanpham.Size = new Size(100, 23);
            txtTensanpham.TabIndex = 1;
            txtTensanpham.TextChanged += txtTensanpham_TextChanged;
            // 
            // lblTensanpham
            // 
            lblTensanpham.AutoSize = true;
            lblTensanpham.Location = new Point(22, 47);
            lblTensanpham.Name = "lblTensanpham";
            lblTensanpham.Size = new Size(83, 15);
            lblTensanpham.TabIndex = 0;
            lblTensanpham.Text = "Ten san pham:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 30);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "Ban hang online";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewProduct);
            groupBox1.Controls.Add(lblTensanpham);
            groupBox1.Controls.Add(txtSoluong);
            groupBox1.Controls.Add(lblSoluong);
            groupBox1.Controls.Add(txtTensanpham);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblAnhsanpham);
            groupBox1.Controls.Add(lblGia);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 345);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin san pham:";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(115, 176);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.Size = new Size(240, 150);
            dataGridViewProduct.TabIndex = 8;
            // 
            // btnThemvaogiohang
            // 
            btnThemvaogiohang.Location = new Point(202, 210);
            btnThemvaogiohang.Name = "btnThemvaogiohang";
            btnThemvaogiohang.Size = new Size(135, 23);
            btnThemvaogiohang.TabIndex = 8;
            btnThemvaogiohang.Text = "Them vao gio hang";
            btnThemvaogiohang.UseVisualStyleBackColor = true;
            btnThemvaogiohang.Click += btnThemvaogiohang_Click;
            // 
            // btnXoakhoigiohang
            // 
            btnXoakhoigiohang.Location = new Point(31, 210);
            btnXoakhoigiohang.Name = "btnXoakhoigiohang";
            btnXoakhoigiohang.Size = new Size(135, 23);
            btnXoakhoigiohang.TabIndex = 9;
            btnXoakhoigiohang.Text = "Xoa khoi gio hang";
            btnXoakhoigiohang.UseVisualStyleBackColor = true;
            btnXoakhoigiohang.Click += btnXoakhoigiohang_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTongtien);
            groupBox2.Controls.Add(txtTongtien);
            groupBox2.Controls.Add(txtThanhtoan);
            groupBox2.Controls.Add(dataGridViewCart);
            groupBox2.Controls.Add(btnXoakhoigiohang);
            groupBox2.Controls.Add(btnThemvaogiohang);
            groupBox2.Location = new Point(499, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 345);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gio hang";
            // 
            // lblTongtien
            // 
            lblTongtien.AutoSize = true;
            lblTongtien.Location = new Point(107, 259);
            lblTongtien.Name = "lblTongtien";
            lblTongtien.Size = new Size(59, 15);
            lblTongtien.TabIndex = 13;
            lblTongtien.Text = "Tong tien:";
            lblTongtien.Click += lblTongtien_Click;
            // 
            // txtTongtien
            // 
            txtTongtien.Location = new Point(202, 256);
            txtTongtien.Name = "txtTongtien";
            txtTongtien.Size = new Size(100, 23);
            txtTongtien.TabIndex = 12;
            txtTongtien.TextChanged += txtTongtien_TextChanged;
            // 
            // txtThanhtoan
            // 
            txtThanhtoan.Location = new Point(202, 303);
            txtThanhtoan.Name = "txtThanhtoan";
            txtThanhtoan.Size = new Size(75, 23);
            txtThanhtoan.TabIndex = 11;
            txtThanhtoan.Text = "Thanh toan";
            txtThanhtoan.UseVisualStyleBackColor = true;
            txtThanhtoan.Click += txtThanhtoan_Click;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(31, 30);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.Size = new Size(306, 150);
            dataGridViewCart.TabIndex = 10;
            dataGridViewCart.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTensanpham;
        private Label lblTensanpham;
        private TextBox txtGia;
        private Label lblGia;
        private Label label1;
        private TextBox txtSoluong;
        private Label lblSoluong;
        private Label lblAnhsanpham;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnXoakhoigiohang;
        private Button btnThemvaogiohang;
        private GroupBox groupBox2;
        private Label lblTongtien;
        private TextBox txtTongtien;
        private Button txtThanhtoan;
        private DataGridView dataGridViewCart;
        private DataGridView dataGridViewProduct;
    }
}
