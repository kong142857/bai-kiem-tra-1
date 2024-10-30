using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai_kiem_tra_1
{
    public partial class Form1 : Form
    {
        private ShoppingCart shoppingCart = new ShoppingCart();
        private List<Product> productList = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            InitializeProductList();
            DisplayProductList();
            CapNhatDataGridView();
        }
        private void InitializeProductList()
        {
            productList.Add(new Product("San pham A", 100000, 1));
            productList.Add(new Product("San pham B", 200000, 1));
            // Thêm sản phẩm mẫu khác vào đây
        }

        private void DisplayProductList()
        {
            dataGridViewProduct.DataSource = null;
            dataGridViewProduct.DataSource = productList;
        }

        private void CapNhatDataGridView()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = shoppingCart.CartItems;
            txtTongtien.Text = shoppingCart.CalculateTotal().ToString("C");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoakhoigiohang_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.CurrentRow != null)
            {
                // Xóa sản phẩm được chọn khỏi giỏ hàng
                var selectedProduct = (Product)dataGridViewCart.CurrentRow.DataBoundItem;
                shoppingCart.RemoveProduct(selectedProduct);
                CapNhatDataGridView();
            }
        }

        private void btnThemvaogiohang_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentRow != null)
            {
                var selectedProduct = (Product)dataGridViewProduct.CurrentRow.DataBoundItem;

                // Thêm sản phẩm vào giỏ hàng
                shoppingCart.AddProduct(selectedProduct);
                CapNhatDataGridView();
            }
        }

        private void lblTongtien_Click(object sender, EventArgs e)
        {

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThanhtoan_Click(object sender, EventArgs e)
        {
            if (shoppingCart.CartItems.Count > 0)
            {
                MessageBox.Show("Đơn hàng của bạn đã được thanh toán thành công!", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                shoppingCart.ClearCart();
                CapNhatDataGridView();
            }
            else
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProduct.CurrentRow != null)
            {
                // Lấy sản phẩm đang được chọn
                var selectedProduct = (Product)dataGridViewProduct.CurrentRow.DataBoundItem;

                // Hiển thị thông tin sản phẩm vào các TextBox
                txtTensanpham.Text = selectedProduct.Name;
                txtGia.Text = selectedProduct.Price.ToString();
                txtSoluong.Text = selectedProduct.Quantity.ToString();
            }
        }
    }
}
