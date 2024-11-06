using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachHang;

namespace QuanLyKhanhHang
{
    public class Hoadon
    {
        public int Mahoadon { get; set; }
        public Khachhang Khachhang { get; set; }
        public List<Dichvu> Dvchon { get; set; } = new List<Dichvu>();
        public decimal Tongtien =>Dvchon.Sum(s =>s .Gia);
    }
    internal class QLHoadon
    {
        private List<Hoadon> qlhd = new List<Hoadon>();
        private int nextMahd = 1;

        public Hoadon Taohoadon (Khachhang Khachhang, List<Dichvu> dvchon)
        {
            var hd = new Hoadon
            {
                Mahoadon = nextMahd++,
                Khachhang = Khachhang,
                Dvchon = new List<Dichvu>(dvchon)
            };
            qlhd.Add(hd);
            return hd;
        }
        
        public List<Hoadon> GetAllhoadon()
        {
            return qlhd;
        }
    }
}
