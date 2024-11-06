using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhanhHang;

namespace QuanLyKhachHang
{
    public partial class Form1 : Form
    {
        private quanlykhachhang qlkh = new quanlykhachhang();
        private QLDichvu qldv = new QLDichvu();
        private QLHoadon qlhd = new QLHoadon();
        public Form1()
        {
            InitializeComponent();
            LoadDichvu();
            dataGridViewKhachhang.CellClick += dataGridViewKhachhang_CellContentClick;
        }
        private void LoadDichvu()
        {
            qldv.Adddichvu(1,"com rang", 25000);
            qldv.Adddichvu(2,"pho", 30000);
            qldv.Adddichvu(3,"bun", 25000);
            qldv.Adddichvu(4, "mi tron", 50000);
            qldv.Adddichvu(5, "banh mi", 10000);
            qldv.Adddichvu(6, "xoi", 10000);
            // Hiển thị danh sách dịch vụ vào dataGridViewDichvu
            dataGridViewDichvu.DataSource = qldv.GEtAlldv();

            // Thêm cột checkbox để chọn dịch vụ
            if (!dataGridViewDichvu.Columns.Contains("Chon"))
            {
                DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
                chkColumn.Name = "Chon";
                chkColumn.HeaderText = "Chọn";
                dataGridViewDichvu.Columns.Insert(0, chkColumn);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //them kh moi
            var KH = qlkh.AddKhachhang(txtTenkhachhang.Text, txtSodienthoai.Text, txtDiachi.Text);

            //cap nhap du lieu
            dataGridViewKhachhang.DataSource = null;
            dataGridViewKhachhang.DataSource = qlkh.GetAllKh();

            // thong bao
            MessageBox.Show("them thanh cong !");
            // clear lai cac textBox
            txtTenkhachhang.Clear();
            txtSodienthoai.Clear();
            txtDiachi.Clear();
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            int Makh;
            if (!int.TryParse(txtMakhachhang.Text, out Makh))
            {
                MessageBox.Show("Ma khach hang khong hop le.");
                return;
            }
            bool kq = qlkh.EditKh(Makh,txtTenkhachhang.Text, txtSodienthoai.Text, txtDiachi.Text);

            // kiem tra ma
            if (kq)
            {
                // cap nhat lai du lieu
                dataGridViewKhachhang.DataSource = null;
                dataGridViewKhachhang.DataSource = qlkh.GetAllKh();
                //thong bao
                MessageBox.Show("them thanh cong");
            }
            else
            {
                MessageBox.Show("khong tim thay khach hang co ma nay");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Makh;
            if (!int.TryParse(txtMakhachhang.Text, out Makh))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ.");
                return;
            }
            // xoa kh
            bool kq = qlkh.DeleteKh(Makh);
            if (kq)
            {
                // cap nhat lai du lieu
                dataGridViewKhachhang.DataSource = null;
                dataGridViewKhachhang.DataSource = qlkh.GetAllKh();
                //thong bao
                MessageBox.Show("xoa thanh cong");
            }
            else
            {
                MessageBox.Show("khong tim thay khach hang co ma nay");
            }

        }

        private void btnTaohoadon_Click(object sender, EventArgs e)
        {
            int maKH;
            if (int.TryParse(txtMakhachhang.Text, out maKH))
            {
                var khachhang = qlkh.GetAllKh().FirstOrDefault(c => c.Makh == maKH);
                if (khachhang != null)
                {
                    var dichvu = GetDVchon();
                    var hoadon = qlhd.Taohoadon( khachhang, dichvu);
                    DisplayHoadon(hoadon);
                }
                else
                {
                    MessageBox.Show("Khong tim thay khach hang voi ma nay.");
                }
            }
            else
            {
                MessageBox.Show("Ma khach hang khong hop le.");
            }
        }

        private List<Dichvu> GetDVchon()
        {
            List<Dichvu> dvchon = new List<Dichvu>();

            // Duyệt qua các hàng của dataGridViewDichvu để kiểm tra dịch vụ nào được chọn
            foreach (DataGridViewRow row in dataGridViewDichvu.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Chon"].Value); // Cột "Chon" là cột checkbox
                if (isSelected)
                {
                    int madv = Convert.ToInt32(row.Cells["Madv"].Value);
                    string Tendv = row.Cells["Tendv"].Value.ToString();
                    decimal Gia = Convert.ToDecimal(row.Cells["Gia"].Value);

                    Dichvu dv = new Dichvu(madv,Tendv, Gia);
                    dvchon.Add(dv);
                }
            }
            return dvchon;
        }

        private void DisplayHoadon(Hoadon hoadon)
        {
            dataGridViewHoadon.DataSource = null;
            dataGridViewHoadon.DataSource = hoadon.Dvchon;
            lblTongtien.Text = $"Tổng tiền: {hoadon.Tongtien}";
            lblMahoadon.Text = $"Mã hóa đơn:{hoadon.Mahoadon}";
            lblTenkhachhang.Text =$"Tên khách hàng :{hoadon.Khachhang.Tenkh}";
        }

        private void dataGridViewKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số hàng được chọn hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewKhachhang.Rows[e.RowIndex];

                // Hiển thị thông tin vào các TextBox
                txtMakhachhang.Text = row.Cells["Makh"].Value.ToString();
                txtTenkhachhang.Text = row.Cells["Tenkh"].Value.ToString();
                txtSodienthoai.Text = row.Cells["Sdt"].Value.ToString();
                txtDiachi.Text = row.Cells["Diachi"].Value.ToString();
            }
        }
    }
}
