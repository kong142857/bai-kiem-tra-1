namespace QuanLyKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaohoadon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhsua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.txtMakhachhang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKhachhang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDichvu = new System.Windows.Forms.DataGridView();
            this.dataGridViewHoadon = new System.Windows.Forms.DataGridView();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.groupHoadon = new System.Windows.Forms.GroupBox();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.lblMahoadon = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachhang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadon)).BeginInit();
            this.groupHoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaohoadon);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnChinhsua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtSodienthoai);
            this.groupBox1.Controls.Add(this.txtTenkhachhang);
            this.groupBox1.Controls.Add(this.txtMakhachhang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý danh sách khách hàng";
            // 
            // btnTaohoadon
            // 
            this.btnTaohoadon.Location = new System.Drawing.Point(334, 182);
            this.btnTaohoadon.Name = "btnTaohoadon";
            this.btnTaohoadon.Size = new System.Drawing.Size(132, 39);
            this.btnTaohoadon.TabIndex = 12;
            this.btnTaohoadon.Text = "Tạo hóa đơn";
            this.btnTaohoadon.UseVisualStyleBackColor = true;
            this.btnTaohoadon.Click += new System.EventHandler(this.btnTaohoadon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(334, 128);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 39);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhsua
            // 
            this.btnChinhsua.Location = new System.Drawing.Point(334, 83);
            this.btnChinhsua.Name = "btnChinhsua";
            this.btnChinhsua.Size = new System.Drawing.Size(132, 39);
            this.btnChinhsua.TabIndex = 10;
            this.btnChinhsua.Text = "Chỉnh sửa";
            this.btnChinhsua.UseVisualStyleBackColor = true;
            this.btnChinhsua.Click += new System.EventHandler(this.btnChinhsua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(334, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 39);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(156, 188);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(146, 26);
            this.txtDiachi.TabIndex = 8;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(156, 141);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(146, 26);
            this.txtSodienthoai.TabIndex = 7;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(156, 94);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(146, 26);
            this.txtTenkhachhang.TabIndex = 6;
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Location = new System.Drawing.Point(156, 52);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.Size = new System.Drawing.Size(146, 26);
            this.txtMakhachhang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng :";
            // 
            // dataGridViewKhachhang
            // 
            this.dataGridViewKhachhang.AllowUserToDeleteRows = false;
            this.dataGridViewKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachhang.Location = new System.Drawing.Point(521, 65);
            this.dataGridViewKhachhang.Name = "dataGridViewKhachhang";
            this.dataGridViewKhachhang.ReadOnly = true;
            this.dataGridViewKhachhang.RowHeadersWidth = 62;
            this.dataGridViewKhachhang.RowTemplate.Height = 28;
            this.dataGridViewKhachhang.Size = new System.Drawing.Size(463, 499);
            this.dataGridViewKhachhang.TabIndex = 0;
            this.dataGridViewKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachhang_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDichvu);
            this.groupBox2.Location = new System.Drawing.Point(12, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 224);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dịch vụ";
            // 
            // dataGridViewDichvu
            // 
            this.dataGridViewDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichvu.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewDichvu.Name = "dataGridViewDichvu";
            this.dataGridViewDichvu.RowHeadersWidth = 62;
            this.dataGridViewDichvu.RowTemplate.Height = 28;
            this.dataGridViewDichvu.Size = new System.Drawing.Size(483, 150);
            this.dataGridViewDichvu.TabIndex = 0;
            // 
            // dataGridViewHoadon
            // 
            this.dataGridViewHoadon.AllowUserToDeleteRows = false;
            this.dataGridViewHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoadon.Location = new System.Drawing.Point(21, 109);
            this.dataGridViewHoadon.Name = "dataGridViewHoadon";
            this.dataGridViewHoadon.ReadOnly = true;
            this.dataGridViewHoadon.RowHeadersWidth = 62;
            this.dataGridViewHoadon.RowTemplate.Height = 28;
            this.dataGridViewHoadon.Size = new System.Drawing.Size(466, 326);
            this.dataGridViewHoadon.TabIndex = 3;
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(41, 461);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(83, 20);
            this.lblTongtien.TabIndex = 4;
            this.lblTongtien.Text = "Tổng tiền :";
            // 
            // groupHoadon
            // 
            this.groupHoadon.Controls.Add(this.lblTenkhachhang);
            this.groupHoadon.Controls.Add(this.lblMahoadon);
            this.groupHoadon.Controls.Add(this.dataGridViewHoadon);
            this.groupHoadon.Controls.Add(this.lblTongtien);
            this.groupHoadon.Location = new System.Drawing.Point(990, 65);
            this.groupHoadon.Name = "groupHoadon";
            this.groupHoadon.Size = new System.Drawing.Size(503, 499);
            this.groupHoadon.TabIndex = 5;
            this.groupHoadon.TabStop = false;
            this.groupHoadon.Text = "Hóa đơn";
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Location = new System.Drawing.Point(17, 74);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(131, 20);
            this.lblTenkhachhang.TabIndex = 6;
            this.lblTenkhachhang.Text = "Tên khách hàng :";
            // 
            // lblMahoadon
            // 
            this.lblMahoadon.AutoSize = true;
            this.lblMahoadon.Location = new System.Drawing.Point(23, 34);
            this.lblMahoadon.Name = "lblMahoadon";
            this.lblMahoadon.Size = new System.Drawing.Size(101, 20);
            this.lblMahoadon.TabIndex = 5;
            this.lblMahoadon.Text = "Mã hóa đơn :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 576);
            this.Controls.Add(this.groupHoadon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKhachhang);
            this.Name = "Form1";
            this.Text = "Quản lý khách hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachhang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoadon)).EndInit();
            this.groupHoadon.ResumeLayout(false);
            this.groupHoadon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewKhachhang;
        private System.Windows.Forms.DataGridView dataGridViewDichvu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.TextBox txtMakhachhang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhsua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaohoadon;
        private System.Windows.Forms.DataGridView dataGridViewHoadon;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.GroupBox groupHoadon;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.Label lblMahoadon;
    }
}

